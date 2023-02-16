using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberCalculator.Models
{
    public class RomanNumberException : Exception
    {
        private string Message = string.Empty;
        public RomanNumberException(string message = "")
        {
            Message = message;
        }
    }
}
