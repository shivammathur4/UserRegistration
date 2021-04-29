using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User registration using unit testing!");
            Validation regex = new Validation();
            Console.WriteLine("Enter your Mobile Number with country code:");
            string name = Console.ReadLine();
            bool result = regex.ValidateMobileNumber(name);
            Console.WriteLine("MobileNumber: " + result);
        }
    }
}
