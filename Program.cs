namespace Address_Book_System
{
    internal class Program
    {
        public static List<ContactPerson> addressBook = new List<ContactPerson>();
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome To Address Book System");
            int options;
            do
            {
                Console.WriteLine("Choose Below options");
                Console.WriteLine("1 - ADD to Contact");
                Console.WriteLine("2 - Display Contact List");
                Console.WriteLine("3 - Edit a Contact");
                Console.WriteLine("4 - Close the Application");
                Console.WriteLine("5 - Continue");

                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        ContactPerson obj = new ContactPerson();
                        addressBook.Add(obj.AddContact());
                        break;

                    case 2:
                        ContactPerson.DisplayList(addressBook);
                        break;
                    case 3:
                        ContactPerson.EditContact(addressBook);
                        break;
                    case 4:
                        break;
                    case 5:
                        continue;

                }

            }
            while (options != 4);
                
            

        }

    }
}