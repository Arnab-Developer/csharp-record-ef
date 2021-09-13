using ConsoleApp2.Services;

IStudentService studentService = new StudentService();

await studentService.Insert();
await studentService.Update();
await studentService.Delete();