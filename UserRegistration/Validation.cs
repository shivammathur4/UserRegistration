using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Validation
    {
        public static string FIRSTNAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public static string LASTNAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public static string MOBILE_REGEX = "^[1-9]{1}[0-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        public static string PASSWORD4_REGEX = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&+-.]*[!@#$%&+-.][^!@#$%&+-.]*$)[\\S]{8,}$";
        public static string EMAILSAMPLE_REGEX = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        private List<string> sampleMails = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };
        public bool ValidateFirstName(string name1) => (Regex.IsMatch(name1, FIRSTNAME_REGEX));
        public bool ValidateLastName(string name2) => (Regex.IsMatch(name2, LASTNAME_REGEX));
        public bool ValidateEmail(string name3) => (Regex.IsMatch(name3, EMAIL_REGEX));
        public bool ValidateMobileNumber(string name4) => (Regex.IsMatch(name4, MOBILE_REGEX));
        public bool ValidatePassword(string name5) => (Regex.IsMatch(name5, PASSWORD4_REGEX));
        public bool ValidateEmailSample(string name6) => (Regex.IsMatch(name6, EMAILSAMPLE_REGEX));
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
        public List<string> GetList()
        {
            return sampleMails;
        }
    }
}