using System.Collections;
using System.Collections.Generic;

namespace Address_Book_System
{
    public class ContactPerson
    {
        public string FirstName;
        public string LastName;
        public string city;
        public string address;
        public string PhoneNumber;
        public string State;
        public string Zip;
        public string Email;
        


        public ContactPerson AddContact()
        {
            ContactPerson person = new ContactPerson();     //creating object of class

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.address = Console.ReadLine();

            Console.Write("Enter City: ");
            person.city = Console.ReadLine();

            Console.Write("Enter Zip code: ");
            person.Zip = Console.ReadLine();

            Console.Write("Enter State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();

            
            return person;

        }

        public static void DisplayList(List<ContactPerson> addressBook)
        {
            if (addressBook.Count == 0)
                Console.WriteLine("Empty! Please Add the contact ");
            else
            {
                foreach (var item in addressBook)
                    PrintPerson(item);
            }
            

        }

        public static void EditContact(List<ContactPerson> addressBook)
        {
            string firstName, lastName;
            int flag = 0;
            if (addressBook.Count == 0)
                Console.WriteLine("Empty! Please Add the contact ");
            else
            {
                Console.WriteLine("Enter the First_Name");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter the Last Name");
                lastName = Console.ReadLine();
                for (int i = 0; i < addressBook.Count; i++)
                {
                    if (addressBook[i].FirstName == firstName && addressBook[i].LastName == lastName)
                    {
                        Console.WriteLine("Contact Found! - Please Enter the correct details ");
                        ContactPerson person = new ContactPerson();
                        addressBook[i] = person.AddContact();
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine("Sorry Contact Not Found");
            }

            
        }

        public static void Search(Dictionary<string, List<ContactPerson>> Mydict)
        {
            Console.WriteLine("Pleae Enter City");
            var temp_city = Console.ReadLine();
            Console.WriteLine("Please Enter State");
            var temp_state = Console.ReadLine();

            int count = 0;

            foreach(var item in Mydict.Keys)
            {
               //List<T> addressbook = Mydict[item];
               List<ContactPerson> addressbook = Mydict[item];
               foreach (ContactPerson person in addressbook)
                {
                    if ((person.city.Equals(temp_city)) || (person.State.Equals(temp_state)))
                    {
                        Console.WriteLine(item);
                        PrintPerson(person);
                        count++;
                    }
                }
               
            }

            Console.WriteLine("Total Search Result = "+count);
        }


        public static void RemoveContact(List<ContactPerson> addressBook)
        {
            string firstName, lastName;
            int flag = 0;

            if (addressBook.Count == 0)
                Console.WriteLine("Empty! Please Add the contact ");
            else
            {
                Console.WriteLine("Enter the First_Name");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter the Last Name");
                lastName = Console.ReadLine();

                for (int i = 0; i < addressBook.Count; i++)
                {
                    if (addressBook[i].FirstName == firstName && addressBook[i].LastName == lastName)
                    {
                        Console.WriteLine("Contact Found and Deleted from Contact List");
                        addressBook.Remove(addressBook[i]);
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                    Console.WriteLine("Sorry! Contact Not Found");

            }

        }

        public static void PrintPerson(ContactPerson person)
        {
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address: " + person.address);
            Console.WriteLine("City: " + person.city);
            Console.WriteLine("State: " + person.State);
            Console.WriteLine("Email: " + person.Email);


            Console.WriteLine("-------------------------------------------");
        }

    }
}

