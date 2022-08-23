namespace Address_Book_System
{
    internal class Program
    {   
        //public static List<ContactPerson> addressBook = new List<ContactPerson>();
        
        public static Dictionary<string, List<ContactPerson>> Mydict = new Dictionary<string, List<ContactPerson>>();


        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome To Address Book System");
            int options,flag=0,duplicate=0;
            string book, addressBook_key;
            do
            {
                Console.WriteLine("Choose Below options");
                Console.WriteLine("1 - Create a new AddressBook");
                Console.WriteLine("2 - ADD to Contact");
                Console.WriteLine("3 - Display Contact List");
                Console.WriteLine("4 - Edit a Contact");
                Console.WriteLine("5 - Delete a Contact");
                Console.WriteLine("6 - Close the Application");
                Console.WriteLine("7 - Continue");


                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Console.WriteLine("Please Enter the Name of AddressBook");
                        book = Console.ReadLine();
                        List<ContactPerson> addressBook = new List<ContactPerson>();
                        Mydict.Add(book, addressBook);
                        break;
                    case 2:
                        flag = 0;
                        Console.WriteLine("Please Choose an AddressBook");
                        addressBook_key = Console.ReadLine();
                        foreach (var item in Mydict.Keys)
                        {
                            if (item == addressBook_key)
                            {
                                flag = 1;
                                ContactPerson obj = new ContactPerson();
                                var temp = obj.AddContact();
                                
                                foreach(var contact in Mydict[item])
                                {
                                    if ((contact.FirstName == temp.FirstName) && (contact.LastName == temp.LastName))
                                    {
                                        Console.WriteLine("Sorry! Record exits with this name");
                                        duplicate = 1;
                                        break;
                                    }
                                }
                                if (duplicate==0)
                                    Mydict[item].Add(temp);
                                
                                //Console.WriteLine(obj.AddContact().FirstName);
                                //Mydict[item].Add(obj.AddContact());
                                break;
                            }

                        }

                        if (flag == 0)
                            Console.WriteLine("No AddressBook Found");

                        break;
                       

                    case 3:
                        flag = 0;
                        Console.WriteLine("Please Choose an AddressBook");
                        addressBook_key = Console.ReadLine();

                        foreach (var item in Mydict.Keys)
                        {
                            if (item == addressBook_key)
                            {
                                flag = 1;
                                ContactPerson.DisplayList(Mydict[addressBook_key]);
                                break;
                            }

                        }

                        if (flag == 0)
                            Console.WriteLine("Not found" );

                        
                        break;
                    case 4:
                        flag = 0;
                        Console.WriteLine("Please Choose an AddressBook");
                        addressBook_key = Console.ReadLine();

                        foreach (var item in Mydict.Keys)
                        {
                            if (item == addressBook_key)
                            {
                                flag = 1;
                                ContactPerson.EditContact(Mydict[addressBook_key]);
                                break;
                            }

                        }

                        if (flag == 0)
                            Console.WriteLine("Not found");

                        break;
                    case 5:
                        flag = 0;
                        Console.WriteLine("Please Choose an AddressBook");
                        addressBook_key = Console.ReadLine();

                        foreach (var item in Mydict.Keys)
                        {
                            if (item == addressBook_key)
                            {
                                flag = 1;
                                ContactPerson.RemoveContact(Mydict[addressBook_key]);
                                break;
                            }

                        }
                        break;
                    case 6:
                        break;
                    case 7:
                        continue;
                }

            }
            while (options != 6);
                
            

        }

    }
}