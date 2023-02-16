using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO Address Book Problem");
            Addressbook addressbook = new Addressbook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select 1: For Creating Contact\n" +
                    "Select 2:Edit Existing Contact\n"+
                    "Select 3:To Delete Contact\n"+
                    "Select 4:To Display\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.CreatContact();
                        addressbook.Display();
                        break;
                    case 2:
                        string name= Console.ReadLine();
                        addressbook.EditContact(name);
                        addressbook.Display();
                        break;
                    case 3:
                        Console.WriteLine("enter Name To Delete");
                        //name=Console.ReadLine();
                        addressbook.DeleteContact();
                        //addressbook.Display();
                        break;
                    case 4:
                        addressbook.Display();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
