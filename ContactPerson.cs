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
                Console.WriteLine("Empty");
            foreach (var item in addressBook)
                PrintPerson(item);

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

/* 

public class ContactList:ContactPerson
    {
        public static void DisplayList()
        {
            ContactList obj = new ContactList();
            
            if (obj.addressBook.Count == 0)
            {
                Console.WriteLine("address book is empty");

            }

            foreach (var item in obj.addressBook)
            {
                Console.WriteLine(item);
            }

             static void PrintPerson(ContactPerson person)
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

    

}
*/

