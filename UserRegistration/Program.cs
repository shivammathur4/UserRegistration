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
            Console.WriteLine("Enter your name:");
            string name1 = Console.ReadLine();
            bool result = regex.ValidateFirstName(name1);
            Console.WriteLine("Name: " + result);
            Console.WriteLine("Enter your last name:");
            string name2 = Console.ReadLine();
            bool lastresult = regex.ValidateLastName(name2);
            Console.WriteLine("Last Name: " + lastresult);
            Console.WriteLine("Enter your EmailID:");
            string name3 = Console.ReadLine();
            bool emailresult = regex.ValidateEmail(name3);
            Console.WriteLine("EmailID: " + emailresult);
            Console.WriteLine("Enter your Mobile Number with country code:");
            string name4 = Console.ReadLine();
            bool mobileresult = regex.ValidateMobileNumber(name4);
            Console.WriteLine("MobileNumber: " + mobileresult);
            Console.WriteLine("Enter your Password");
            string name5 = Console.ReadLine();
            bool passwordresult = regex.ValidatePassword(name5);
            Console.WriteLine("Password: " + passwordresult);
            Console.WriteLine("Enter your Email ID");
            string name6 = Console.ReadLine();
            bool emailsampleresult = regex.ValidateEmailSample(name6);
            Console.WriteLine("Email ID: " + emailsampleresult);
        }
    }
}
