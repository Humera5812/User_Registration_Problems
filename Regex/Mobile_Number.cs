using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex.Patterns
{
    internal class Mobile_Number
    {
        public static string RegexRules = "((00)?(+)?d{1,3})[-s]+(d{1,3})[-s]+(d{4,10})";
        internal bool validateString(string v)
        {
            throw new NotImplementedException();
        }
        //public static string Regex_Pincode = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        //public static string regex = "^[A-Za-z0-9]+([.#_+][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-z]{2,3}([.][a-z]{2})?$";
        //public static string regex = "^[A-Za-z0-9]+([._#%+][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public bool validateString(string sample, string RegexRules)
        {
            return Regex(sample, RegexRules);

        }
        public bool Regex(string sample, string RegexRules)
        {
            throw new NotImplementedException();
        }
    }
}
