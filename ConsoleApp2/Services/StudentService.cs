using ConsoleApp2.Data;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    internal class StudentService : IStudentService
    {
        async Task IStudentService.Insert()
        {
            StudentContext studentContext = GetDbContext();

            Name name = new("test firstname", "test lastname");
            Student student = new(5, name);
            studentContext.Students!.Add(student);
            await studentContext.SaveChangesAsync();

            IEnumerable<Student> students = studentContext.Students!.OrderBy(s => s.Id).ToList();
        }

        async Task IStudentService.Update()
        {
            StudentContext studentContext = GetDbContext();

            Student student = studentContext.Students!.First(s => s.Id == 5);
            student.Name.LastName = "updated lastname";
            await studentContext.SaveChangesAsync();
        }

        async Task IStudentService.Delete()
        {
            StudentContext studentContext = GetDbContext();

            Student student = studentContext.Students!.First(s => s.Id == 5);
            studentContext.Students!.Remove(student);
            await studentContext.SaveChangesAsync();
        }

        private static StudentContext GetDbContext()
        {
            string conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDb;Integrated Security=True";
            DbContextOptions<StudentContext> options = new DbContextOptionsBuilder<StudentContext>()
                .UseSqlServer(conStr).Options;
            StudentContext studentContext = new(options);
            return studentContext;
        }
    }
}
