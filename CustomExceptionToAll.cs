using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_assignments
{
    public class CustomExceptionToAll:Exception
    {
        public enum ExceptionType
        {
            Invalid_FirstName,Invalid_Lastname,
            Invalid_Email,Invalid_Phone,
            Invalid_Password

        }

        private readonly ExceptionType exceptionType;

        public CustomExceptionToAll(ExceptionType exceptionType,string message):base(message)
        {
            this.exceptionType=exceptionType;
        }
    }
 
}
