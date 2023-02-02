using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookPracticeProblem
{
    public class AddressBookMain
    {
        public List<Contact> contacts = new List<Contact>();
        public void AddContact()
        {
            Contact contacts = new Contact();
            Console.WriteLine("Enter first name");
            contacts.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            contacts.LastName = Console.ReadLine();
            Console.WriteLine("Enter address");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter city name");
            contacts.City = Console.ReadLine();
            Console.WriteLine("Enter state name");
            contacts.State = Console.ReadLine();
            Console.WriteLine("Enter zipcode");
            contacts.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phonenumber");
            contacts.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the email");
            contacts.Email = Console.ReadLine();
            this.contacts.Add(contacts);
            Console.WriteLine("Contacts Added SuccessFully");

        }
        public static void DeleteContact()
        {
            List<Contact> contacts = new List<Contact>();
            Console.WriteLine("Enter the first name");
            string name = Console.ReadLine();
            foreach (var data in contacts)
            {
                if (data.FirstName == name)
                {
                    contacts.Remove(data);

                    Console.WriteLine("\nContact delete Successfully");
                }

            }
        }
    }
}
