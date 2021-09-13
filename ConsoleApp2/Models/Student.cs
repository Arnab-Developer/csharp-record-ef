namespace ConsoleApp2.Models
{
    public record Student
    {
        public int Id { get; set; }
        public Name Name { get; set; }

#pragma warning disable CS8618
        public Student()
        {
        }
#pragma warning restore CS8618

        public Student(int id, Name name)
        {
            Id = id;
            Name = name;
        }
    }
}
