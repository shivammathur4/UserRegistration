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

        public bool ValidateFirstName(string name1)
        {
            return Regex.IsMatch(name1, FIRSTNAME_REGEX);
        }
        public bool ValidateLastName(string name2)
        {
            return Regex.IsMatch(name2, LASTNAME_REGEX);
        }
        public bool ValidateEmail(string name3)
        {
            return Regex.IsMatch(name3, EMAIL_REGEX);
        }
        public bool ValidateMobileNumber(string name4)
        {
            return Regex.IsMatch(name4, MOBILE_REGEX);
        }
        public bool ValidatePassword(string name5)
        {
            return Regex.IsMatch(name5, PASSWORD4_REGEX);
        }

        public bool ValidateEmailSample(string name6)
        {
            return Regex.IsMatch(name6, EMAILSAMPLE_REGEX);
        }
    }
}
