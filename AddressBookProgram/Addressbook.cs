using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    public class Addressbook
    {
        Contact contact = new Contact();
        List<Contact> contactList = new List<Contact>();
        public void CreatContact()
        {
            Console.WriteLine("Enter the First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter the City Name");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter the State Name");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter the Zipcode");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Email");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number");
            contact.PhoneNumber = Console.ReadLine();
            contactList.Add(contact);
            Console.WriteLine();
        }
        public void Display()
        {
            foreach (var contact in contactList)
            {
                Console.WriteLine("================\n*****Contact Details Of User =>=>=>" + "\nFirst Name:-" + contact.FirstName + "\nLast Name:-" + contact.LastName + "\nAddress:-" + contact.Address +
                    "\nCity:-" + contact.City + "\nState:-" + contact.State + "\nZip Code:-" + contact.Zip + "\nPhone Number:-" + contact.PhoneNumber + "\nEmail:-" + contact.Email + "\n================");
            }
        }
        public void EditContact(string name)
        {
            foreach (Contact contact in contactList)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("\nSelect 1: To Edit First Name\n" +
                        "Select 2: To Edit Last Name\n" +
                        "Select 3: To Edit Address\n" +
                        "Select 4: To Edit City Name\n" +
                        "Select 5: To Edit State Name\n" +
                        "Select 6: To Edit Zip Code\n" +
                        "Select 7: To Edit Email Address\n" +
                        "Select 8: To Edit Phone NUmber\n");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter New Name");
                            contact.FirstName = Console.ReadLine(); break;
                        case 2:
                            Console.WriteLine("Enter New Last Name");
                            contact.LastName = Console.ReadLine(); break;
                        case 3:
                            Console.WriteLine("Enter New Address");
                            contact.Address = Console.ReadLine(); break;
                        case 4:
                            Console.WriteLine("Enter New City Name");
                            contact.City = Console.ReadLine(); break;
                        case 5:
                            Console.WriteLine("Enter New State Name");
                            contact.State = Console.ReadLine(); break;
                        case 6:
                            Console.WriteLine("Enter New Zip Code");
                            contact.Zip = Convert.ToInt32(Console.ReadLine()); break;
                        case 7:
                            Console.WriteLine("Enter New Email Address");
                            contact.Email = Console.ReadLine(); break;
                        case 8:
                            Console.WriteLine("Enter Updated Phone Number");
                            contact.PhoneNumber = Console.ReadLine(); break;
                        case 9:
                            Console.WriteLine("Invalid Option Please Choose Within Range 1-8"); break;
                    }
                }
                else
                {
                    Console.WriteLine("***********\nInvalid Name Choose Correct option\n***********");
                    Console.WriteLine("Since You Have Change The First Name You Won't Be Able To Edit Further Details");
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the first name of person to be removed");
            string verifyingName = Console.ReadLine();
            foreach (var contact in contactList)
            {
                if (contact.FirstName.Equals(verifyingName))
                {
                    contactList.Remove(contact);
                    Console.WriteLine("Contact Deleted Sucessfully");
                    break;
                }
                else
                { Console.WriteLine("Enter Valid Name"); Console.ReadLine(); }
            }

        }
    }
}
