using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;

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
            string book, addressBook_key,path;
            //string path = @"E:\BRIDGELABZ\Address_Book_System\";
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
                Console.WriteLine("8 - Search a person by city or state");


                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Console.WriteLine("Please Enter the Name of AddressBook");
                        book = Console.ReadLine();
                       
                        try
                        {
                            path = @"E:\BRIDGELABZ\Address_Book_System\";
                            path = path + book + ".txt";
                            using (FileStream fs = new FileStream(path, FileMode.Create))
                            {
                                Console.WriteLine("AddressBook Created Successfully");
                                List<ContactPerson> addressBook = new List<ContactPerson>();
                                Mydict.Add(book, addressBook);
                                break;
                            }
                            path = @"E:\BRIDGELABZ\Address_Book_System\";

                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                                 
                        break;
                    case 2:
                        path = @"E:\BRIDGELABZ\Address_Book_System\";
                        flag = 0;
                        Console.WriteLine("Please Choose an AddressBook");
                        addressBook_key = Console.ReadLine();

                        path = path + addressBook_key + ".txt";

                        foreach (var item in Mydict.Keys)
                        {
                            if (item == addressBook_key)
                            {
                                flag = 1;
                                path = path + item + ".txt";
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
                                if (duplicate == 0)
                                {
                                    Mydict[item].Add(temp);
                                }

                                path = @"E:\BRIDGELABZ\Address_Book_System\";

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
                                ContactPerson.DisplayList(item,Mydict[addressBook_key]);
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
                    case 8:
                        ContactPerson.Search(Mydict);
                        break;
                }

            }
            while (options != 6);
                
            

        }

    }
}