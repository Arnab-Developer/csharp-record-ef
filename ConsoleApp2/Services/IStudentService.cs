using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    internal interface IStudentService
    {
        Task Insert();
        Task Update();
        Task Delete();
    }
}
