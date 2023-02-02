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
        List<Contact> contacts = new List<Contact>();
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
        public void EditContact()
        {
            Console.WriteLine("Enter the first name you have to want to edit");
            string FirstName = Console.ReadLine();
            foreach (var data in contacts)
            {
                if (contacts.Contains(data))
                {
                    if (data.FirstName == FirstName)
                    {
                        Console.WriteLine("To edit contacts enter 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string firstname = Console.ReadLine();
                                data.FirstName = FirstName;
                                break;
                            case 2:
                                string lastname = Console.ReadLine();
                                data.LastName = lastname;
                                break;
                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("contact edit succsessfully");
                    }
                }

            }
        }
        
    }
}
