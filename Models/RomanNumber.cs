using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberCalculator.Models
{
    public class RomanNumber : ICloneable, IComparable
    {
        protected string romanRepresentation { get; set; }//римское представление
        public ushort numericalRepresentation { get; protected set; }//числовое представление
        public static RomanNumber? Current;
        protected Dictionary<ushort, string> romanDictionary { get; private set; } = new Dictionary<ushort, string>()
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC"},
        { 50, "L" },
        { 40, "XL" },
        { 10, "X"},
        { 9, "IX"},
        { 5, "V"},
        { 4, "IV"},
        { 1, "I"}
    };//Словарь с римской записью некоторых чисел
      //Конструктор принимает число от 1 и переводит его в римскoе
        public RomanNumber(ushort n = 1)
        {
            if (n <= 0) throw new RomanNumberException("Римское число не может быть нулем или ниже");
            string result = String.Empty;
            ushort i = n;
            while (i > 0)
                foreach (var roman in romanDictionary)
                {
                    while (i >= roman.Key)
                    {
                        result += roman.Value;
                        i -= roman.Key;
                    }
                }
            romanRepresentation = result;
            numericalRepresentation = n;
        }
        //Сложение римских чисел
        public static RomanNumber operator +(RomanNumber? n1, RomanNumber? n2)
        {
            ushort number = 0;
            number = (ushort)(n1.numericalRepresentation + n2.numericalRepresentation);
            RomanNumber roman = new RomanNumber(number);
            return roman;
        }
        //Вычитание римских чисел
        public static RomanNumber operator -(RomanNumber? n1, RomanNumber? n2)
        {
            ushort number = 0;
            number = (ushort)(n1.numericalRepresentation - n2.numericalRepresentation);
            if (n1.numericalRepresentation - n2.numericalRepresentation <= 0) throw new RomanNumberException("Римское число не может быть нулем или ниже");
            else
            {
                RomanNumber roman = new RomanNumber(number);
                return roman;
            }
        }
        //Умножение римских чисел
        public static RomanNumber operator *(RomanNumber? n1, RomanNumber? n2)
        {
            ushort number = 0;
            if (n1.numericalRepresentation <= 0 && n2.numericalRepresentation <= 0) throw new RomanNumberException("Римское число не может быть нулем или ниже");
            number = (ushort)(n1.numericalRepresentation * n2.numericalRepresentation);
            RomanNumber roman = new RomanNumber(number);
            return roman;
        }
        //Целочисленное деление римских чисел
        public static RomanNumber operator /(RomanNumber? n1, RomanNumber? n2)
        {
            ushort number = 0;
            if (n2.numericalRepresentation <= 0) throw new RomanNumberException("Делить на 0 нельзя");
            number = (ushort)(n1.numericalRepresentation / n2.numericalRepresentation);
            if (n1.numericalRepresentation <= 0 && n2.numericalRepresentation <= 0) throw new RomanNumberException("Римское число не может быть нулем или ниже");
            RomanNumber roman = new RomanNumber(number);
            return roman;
        }
        //Возвращает строковое представление римского числа
        public override string ToString()
        {
            return romanRepresentation;
        }
        //Реализация интерфейса IClonable
        public object Clone()
        {
            return new RomanNumber(numericalRepresentation);
        }
        //Реализация интерфейса IComparable
        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber number) return numericalRepresentation.CompareTo(number.numericalRepresentation);
            else throw new RomanNumberException("Некорректный ввод");
        }
    }
}
