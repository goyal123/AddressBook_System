namespace Address_Book_System
{
    internal class Program
    {   
        public static List<ContactPerson> addressBook1 = new List<ContactPerson>();
        public static List<ContactPerson> addressBook2 = new List<ContactPerson>();

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome To Address Book System");
            int options,count=0;
            string book;
            do
            {
                Console.WriteLine("Choose Below options");
                Console.WriteLine("7 - Create a new AddressBook");
                Console.WriteLine("1 - ADD to Contact");
                Console.WriteLine("2 - Display Contact List");
                Console.WriteLine("3 - Edit a Contact");
                Console.WriteLine("4 - Delete a Contact");
                Console.WriteLine("5 - Close the Application");
                Console.WriteLine("6 - Continue");


                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        ContactPerson obj = new ContactPerson();
                        Console.WriteLine("Choose the AddressBook from below:");
                        Console.WriteLine("1 - AddressBook1");
                        Console.WriteLine("2 - AddressBook2");
                        var ans = Convert.ToInt32(Console.ReadLine());
                        switch(ans)
                        {
                            case 1:
                                addressBook1.Add(obj.AddContact());
                                break;
                            case 2:
                                addressBook2.Add(obj.AddContact());
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Choose the AddressBook from below:");
                        Console.WriteLine("1 - AddressBook1");
                        Console.WriteLine("2 - AddressBook2");
                        var display_ans = Convert.ToInt32(Console.ReadLine());
                        switch (display_ans)
                        {
                            case 1:
                                ContactPerson.DisplayList(addressBook1);
                                break;
                            case 2:
                                ContactPerson.DisplayList(addressBook2);
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Choose the AddressBook from below:");
                        Console.WriteLine("1 - AddressBook1");
                        Console.WriteLine("2 - AddressBook2");
                        var edit_contact = Convert.ToInt32(Console.ReadLine());
                        switch (edit_contact)
                        {
                            case 1:
                                ContactPerson.EditContact(addressBook1);
                                break;
                            case 2:
                                ContactPerson.EditContact(addressBook2);
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Choose the AddressBook from below:");
                        Console.WriteLine("1 - AddressBook1");
                        Console.WriteLine("2 - AddressBook2");
                        var delete_contact = Convert.ToInt32(Console.ReadLine());
                        switch (delete_contact)
                        {
                            case 1:
                                ContactPerson.RemoveContact(addressBook1);
                                break;
                            case 2:
                                ContactPerson.RemoveContact(addressBook2);
                                break;
                        }
                        break;
                    case 5:
                        break;
                    case 6:
                        continue;
                    
                    case 7:
                        Console.WriteLine("Enter the name");
                        book = Console.ReadLine();
                        
                        ContactPerson objbook = new ContactPerson();
                        
                        //Myarray.Add(objbook.AddContact());

                        
                        break;


                }

            }
            while (options != 5);
                
            

        }

    }
}