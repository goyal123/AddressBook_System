namespace Address_Book_System
{
    internal class Program
    {
        List<AddPerson> addressBook = new List<AddPerson>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System");
            AddPerson.AddContact();
            

        }

    }
}