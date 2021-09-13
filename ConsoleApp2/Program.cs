using ConsoleApp2.Data;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

Name name = new("rahul1", "bose1");
Student student = new(4, name);

string conStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentDb;Integrated Security=True";
DbContextOptions<StudentContext> options = new DbContextOptionsBuilder<StudentContext>()
    .UseSqlServer(conStr).Options;
StudentContext studentContext = new(options);

studentContext.Students!.Add(student);
await studentContext.SaveChangesAsync();

var s = studentContext.Students!.OrderBy(s => s.Id).ToList();