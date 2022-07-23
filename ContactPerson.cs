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


    }

    public class AddPerson:ContactPerson
    {
        public static void AddContact()
        {
            AddPerson person = new AddPerson();     //creating object of class
            List<AddPerson> addressBook = new List<AddPerson>();   //creating list containg objects of same class

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

            addressBook.Add(person);   //Adding object to list
        }

    }

}