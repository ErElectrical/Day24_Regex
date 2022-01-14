using System;

namespace Day24_assignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Regex pattern ");

            pattern p= new pattern();
            Console.WriteLine("enter what you want to validate ");
            Console.WriteLine("1. firstName " +
                "\n 2. Lastname " +
                "\n 3. Emailid " +
                "\n 4. PhoneNumber " +
                "\n 5. password rule 1 " +
                "\n 6. Password rule 2 " +
                "\n 7. password rule 3 " +
                "\n 8. Email sample ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        p.ValidFirstname();
                        break;
                    }
                case 2:
                    {
                        p.ValidateLastName();
                        break;
                    }
                case 3:
                    {
                        p.ValidEmailid();
                        break;
                    }
                case 4:
                    {
                        p.Phonenumber();
                        break;
                    }
                case 5:
                    {
                        p.Password();
                        break;
                    }
                case 6:
                    {
                        p.Password1();
                        break;
                    }
                case 7:
                    {
                        p.Password2();
                        break;
                    }
                case 8:
                    {
                        p.EmailSample();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("read again and choice correct ");
                        break;
                    }

            }
            Console.ReadKey();
        }
    }
}
