namespace HumanIsLife


{
    class Program
    {
        string? firstName;
        string? lastName;

        Program(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void getFullName()
        {
            Console.WriteLine(this.firstName +" "+this.lastName);
        }

        static void Main(string[] args)
        {
            Program myObj = new Program("Ardi", "Putra");
            myObj.getFullName();
        }
    }
}