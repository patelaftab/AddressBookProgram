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
            addressbook.CreatContact();
            addressbook.Display();
            Console.ReadLine();
        }
    }
}
