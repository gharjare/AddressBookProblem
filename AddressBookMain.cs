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
        Dictionary<string, List<Contact>> book = new Dictionary<string, List<Contact>>();
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
            contacts.PhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the email");
            contacts.Email = Console.ReadLine();
            this.contacts.Add(contacts);
            Console.WriteLine("Contacts Added SuccessFully");

        }
        public void listPerson()
        {
            foreach (var data in contacts)
            {
                Console.WriteLine("FirstName: " + data.FirstName);
                Console.WriteLine("LastName: " + data.LastName);
                Console.WriteLine("PhoneNumber: " + data.PhoneNumber);
                Console.WriteLine("City: " + data.City);
                Console.WriteLine("Zipcode: " + data.Zip);

            }
        }
        public void editContact()
        {
            List<Contact> contacts = new List<Contact>();
            Console.WriteLine("Enter the first name");
            string name = Console.ReadLine();

            foreach (var data in contacts)
            {
                if (contacts.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string FName = Console.ReadLine();
                                data.FirstName = FName;
                                break;
                            case 2:
                                string LName = Console.ReadLine();
                                data.LastName = LName;
                                break;
                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter correct name");
                    }
                }
            }
        }
        public void DeleteContact()
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
        public void AddMultipleContact()
        {
            Console.WriteLine("Enter the contact you want to add");
            int contact = Convert.ToInt32(Console.ReadLine());
            while (contact > 0)
            {
                AddMultipleContact();
                contact--;
            }
        }
        public void NewUser()
        {
            Console.WriteLine("Enter the Bookname: ");
            string Bookname = Console.ReadLine();
            Console.WriteLine("Enter The Number of Contacts To Add");
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                number--;
                AddContact();
            }
            book.Add(Bookname, contacts.ToList());
        }
        public void DisplayList()
        {
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (Contact data in book[pair])
                {
                    Console.WriteLine("First Name: " + data.FirstName);
                    Console.WriteLine("Last Name: " + data.LastName);
                    Console.WriteLine("Address: " + data.Address);
                    Console.WriteLine("City : " + data.City);
                    Console.WriteLine("State: " + data.State);
                    Console.WriteLine("Zip : " + data.Zip);
                    Console.WriteLine("Phone Number: " + data.PhoneNumber);
                    Console.WriteLine("EmailID: " + data.Email);
                }
            }
        }
        public void DuplicateContact()
        {
            Console.WriteLine("enter the name to check: ");
            string personName = Console.ReadLine();
            Console.WriteLine("Enter phonenumber");
            long phnno = long.Parse(Console.ReadLine());
            bool check = contacts.Any(e => e.FirstName == personName && e.PhoneNumber == phnno);
            if (check)
            {
                Console.WriteLine("contact is present");
            }
            else
            {
                Console.WriteLine("Contact is not present");
                NewUser();
            }
        }
        public void SearchPersonByCity()
        {
            Console.WriteLine("enter the name to search: ");
            string personName = Console.ReadLine();
            Console.WriteLine("enter the city to search: ");
            string cityname = Console.ReadLine();
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (var data in contacts.FindAll(e => e.City == cityname && e.FirstName == personName))
                {
                foreach (var item in contacts.FindAll(e => e.City == cityname && e.FirstName == personName))
                    Console.WriteLine("The Contact Details of " + data.City + " are\n:" + data.FirstName + " " + data.LastName + " " + data.Zip + " " + data.PhoneNumber);
                }
            }
        }
        public void ViewPersonsByCity()
        {
            Console.WriteLine("enter the city to search: ");
            string cityname = Console.ReadLine();
            foreach (var pair in book.Keys)
            {
                Console.WriteLine("Address Book Name " + pair);
                foreach (var data in contacts.FindAll(e => e.City == cityname))
                {
                    Console.WriteLine("The Contact Details of " + data.City + " are\n:" + data.FirstName + " " + data.LastName + " " + data.Zip + " " + data.PhoneNumber);
                }
            }
        }
        public void CountPersonByCity()
        {
            Console.WriteLine("enter the city to search: ");
            string cityname = Console.ReadLine();
            int count = 0;
            foreach (var pair in book.Keys)
            {
                foreach (var items in contacts.FindAll(e => e.City == cityname))
                {
                    count++;
                }
                Console.WriteLine("No of contacts {0} in city {1}", count, cityname);
            }
        }
    }
    
}
