using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day24_assignments
{
    public class TestClassCustomException
    {
        public bool ValidFirstName(string name)
        {

            string rx = @"^[A-Z]{1}[a-z]{3,}$";
            Regex rxName = new Regex(rx);
            
            bool result = rxName.IsMatch(name);
            if(result == false )
            {
                throw new CustomExceptionToAll(CustomExceptionToAll.ExceptionType.Invalid_FirstName, "Not Match");
            }
            else
            {
                Console.WriteLine("Match");
            }
            return result;

            


        }

        public bool ValidLastName(string name)
        {

            string rx = @"^[A-Z]{1}[a-z]{3,}$";
            Regex rxName = new Regex(rx);
            bool result = rxName.IsMatch(name);

            if( result == false )
            {
                throw new CustomExceptionToAll(CustomExceptionToAll.ExceptionType.Invalid_Lastname, "Not Match");

            }

            else
            {
                Console.WriteLine("Match");
            }

            return result;




        }

        public bool Phonenumber(string name)
        {

            string rx = @"^ [1-9]{2,}\s[6-9][0-9]{9}$";
            Regex rxName = new Regex(rx);
            bool result = rxName.IsMatch(name);

            if(result == false)
            {
                throw new CustomExceptionToAll(CustomExceptionToAll.ExceptionType.Invalid_Phone, "Not Match");

            }

            else
            {
                Console.WriteLine("Match");

            }

            return result;


        }

        public bool PassWord(string name)
        {

            string rx = "^((?=.*[!@#$%^&*~])[A-Za-z]{8,}$";

            Regex rxName = new Regex(rx);
            bool result = rxName.IsMatch(name);

            if(result == false)
            {
                throw new CustomExceptionToAll(CustomExceptionToAll.ExceptionType.Invalid_Password, "Not Match");

            }

            return result;




        }

        public bool EmailSample(string email)
        {

            string rx = @"^[a-zA-Z0-9]+([.][A-Za-z0-9]+)?[@][\w]{2, }[.][a-zA-Z]{2,3}[.][a-zA-Z]{2, }?$";



            Regex rxName = new Regex(rx);
            bool result = rxName.IsMatch(email);

            if(result == false)
            {
                throw new CustomExceptionToAll(CustomExceptionToAll.ExceptionType.Invalid_Email, "Not Match");


            }

            return result;




        }
    }
}
