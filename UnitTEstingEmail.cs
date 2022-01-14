using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Day24_assignments
{
    public class UnitTestingEmail
    {
        public static bool Check(string pat,string input)
        {
            Regex rxName = new Regex(pat);
            bool result = rxName.IsMatch(input);
            if (result == false)
            {
                Console.WriteLine("not valid");
                Console.WriteLine(" read manual");

            }
            else
            {
                Console.WriteLine("valid");

            }
            return result;



        }
        public bool EmailSample(string email)
        {

            string rx = @"^[a-zA-Z0-9]+([.][A-Za-z0-9]+)?[@][\w]{2, }[.][a-zA-Z]{2,3}[.][a-zA-Z]{2, }?$";



            Regex rxName = new Regex(rx);
            bool result = rxName.IsMatch(email);
         
            return result;




        }

    }
}
