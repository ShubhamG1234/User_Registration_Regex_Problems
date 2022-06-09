using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Pattern
    {
        public string regex_pattern = "^[0-9]{1}[0-9]{2}[' ']*[0-9]{2}[0-9]{1}$";
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, regex_pattern);
        }
    }
}
