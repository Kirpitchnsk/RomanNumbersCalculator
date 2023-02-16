using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberCalculator.Models
{
    public class RomanNumberExtend:RomanNumber
    {
        public RomanNumberExtend(string num)
        {
            ushort dec = 0;
            string n = num;
            foreach (var roman in romanDictionary)
            {
                while (n.StartsWith(roman.Value))
                {
                    dec += roman.Key;
                    n = n.Substring(roman.Value.Length);
                }
            }
            numericalRepresentation = dec;
            romanRepresentation = n;
        }
    }
}
