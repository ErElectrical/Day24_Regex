using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day24_assignments
{
    public class UnitTestToAll
    {

        public bool ValidFirstName(string name)
        {
           
            string rx = @"^[A-Z]{1}[a-z]{3,}$";
            Regex rxName= new Regex(rx);
            bool result = rxName.IsMatch(name);

            return result;


        }

        public bool ValidLastName(string name)
        {
           
            string rx = @"^[A-Z]{1}[a-z]{3,}$";
            Regex rxName = new Regex(rx);
            bool result = rxName.IsMatch(name);

            return result;


        }

        public bool Phonenumber(string name)
        {
            
            string rx = @"^ [1-9]{2,}\s[6-9][0-9]{9}$";
            Regex rxName = new Regex(rx);
            bool result = rxName.IsMatch(name);

            return result;


        }

        public bool PassWord(string name)
        {
          
            string rx = "^((?=.*[!@#$%^&*~])[A-Za-z]{8,}$";

            Regex rxName = new Regex(rx);
            bool result = rxName.IsMatch(name);

            return result;




        }


    }
}
