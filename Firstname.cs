using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Day24_assignments
{
     class pattern
    {
        // charcter class 

        //. --------- Match any chacrcter except new line
        // \d ----- Digit(0-9)
        // \D ----- Not a digit(0-9)
        // \w ------ word charcter (a-z ,A-Z,0-9,_)
        // \W ------ Not a word chacter 
        // \s ------ whitespace,new Line
        // \S ------- Not whitespace 
        // [] --------- Matches charcter in bracket
        // [^ ] ------- Matches charcter not in bracket
        // | ------ Either or
        // () ---- group
        // \b ---- work boundary(means space)
        // \B ---- Not a work boundary
        // ^ ---- Begining of a string
        // $ ---- ending of string

        // Quantifier

        // * -------- 0 or More
        // + -------- 1 or more
        // ? -------- 0 or 1
        // {3} ------ only 3
        // {3,7} ----- bw 3 and 7.

        public static void Check(string pat, string input)
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

        }

        public void ValidFirstname()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            string rx = @"^[A-Z]{1}[a-z]{3,}$";
            pattern.Check(rx, name);
        }

        public void ValidateLastName()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            string rx = @"^[A-Z]{1}[a-z]{3,}$";
            pattern.Check(rx, name);
        }

        public void ValidEmailid()
        {
            Console.WriteLine("enter Email ");
            string name = Console.ReadLine();
            string rx = @"^[a-zA-Z0-9]+([.][A-Za-z0-9]+)?[@][\w]{2, }[.][a-zA-Z]{2,3}[.][a-zA-Z]{2, }?$";
            pattern.Check(rx, name);
        }
       
        public void Phonenumber()
        {
            Console.WriteLine("enter phonenumber ");
            string name = Console.ReadLine();
            string rx = @"^ [1-9]{2,}\s[6-9][0-9]{9}$";
            pattern.Check(rx, name);

        }

        public void Password()
        {
            Console.WriteLine("enter password ");
            string name = Console.ReadLine();
            string rx = @"^[a-zA-Z]{8,}$";
            pattern.Check(rx, name);

        }

        public void Password1()
        {
            Console.WriteLine("enter password ");
            string name = Console.ReadLine();
            string rx = "^((?=.*[A-Z])(?=.{8,}))";
            pattern.Check(rx, name);

        }

        public void Password2()
        {
            Console.WriteLine("enter password ");
            string name = Console.ReadLine();
            string rx = "^((?=.*[!@#$%^&*~])[A-Za-z]{8,}$";
            pattern.Check(rx, name);

        }

        public void EmailSample()
        {
            Console.WriteLine("enter Emails for sample ");
            string name = Console.ReadLine();
            string rx = "^[a-zA-Z0-9-.+]{3,}[@][a-z]{3,5}[.][com|au|net|com.com|com.net|com.au]$";
            pattern.Check(rx, name);

        }

    }
}
