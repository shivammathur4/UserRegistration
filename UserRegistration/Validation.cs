using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Validation
    {
        public static string PASSWORD2_REGEX = "^(?=.*?[A-Z])[A-Za-z0-9!@#$%^&*]{8,}$";
        public bool ValidatePassword(string name)
        {
            return Regex.IsMatch(name, PASSWORD2_REGEX);
        }
    }
}
