namespace ConsoleApp2.Models
{
    internal record Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

#pragma warning disable CS8618
        public Name()
        {
        }
#pragma warning restore CS8618

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
