// See https://aka.ms/new-console-template for more information
using System;
using RegexPatterns;
namespace Regex
{
    class Program
    {
        public static void Main(string[] args)
        {
            First_Name patterns = new First_Name();
            //Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
            if (patterns.validateString("411046"))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
                Console.ReadKey();
            }
        }
                   
        
       
        
    }
            
    
       
}

