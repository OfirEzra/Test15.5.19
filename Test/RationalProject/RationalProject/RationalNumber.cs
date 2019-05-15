using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalProject
{
    class RationalNumber
    {
        private int Numerator; //P
        private int Denominator; //Q
        readonly bool isZero;

        public bool IsZero { get; }

        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            if (Denominator < 1) //if 0 and below its not eligible
            {
                IsZero = true;
            }

        }
        public int getNumerator()
        {
            return Numerator;
        }
        public int getDenominator()
        {
            return Denominator;
        }

        public bool greaterThan(RationalNumber num)
        {
            int a = Numerator;
            int b = Denominator;
            int c = num.getNumerator();
            int d = num.getDenominator();

            if (IsZero)
            {
                return true;
            }
            else
            {
                if (a * d > b * c)
                {
                    return true;
                }
                return false;
            }
        }
        public bool equals(RationalNumber num)
        {
            int a = Numerator;
            int b = Denominator;
            int c = num.getNumerator();
            int d = num.getDenominator();

            if (IsZero)
            {
                return true;
            }
            else
            {
                if (a * d == b * c)
                {
                    return true;
                }
                return false;
            }
        }
        public static RationalNumber operator+(RationalNumber num1,RationalNumber num2)
        {
            int a = num1.getNumerator();
            int b = num1.getDenominator();
            int c = num2.getNumerator();
            int d = num2.getDenominator();

            if (!num1.IsZero & !num2.IsZero)
            {
                return new RationalNumber((a*d)+(b*c),b*d);
            }
            else if(num1.IsZero & !num2.IsZero)
            {
                return num2;
            }
            else if (!num1.IsZero & num2.IsZero)
            {
                return num1;
            }
            else
            {
                return new RationalNumber(0, 0);
            }

        }
        public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
        {
            int a = num1.getNumerator();
            int b = num1.getDenominator();
            int c = num2.getNumerator();
            int d = num2.getDenominator();

            if (!num1.IsZero & !num2.IsZero)
            {
                return new RationalNumber((a * d) - (b * c), b * d);
            }
            else if (num1.IsZero & !num2.IsZero)
            {
                return num2;
            }
            else if (!num1.IsZero & num2.IsZero)
            {
                return num1;
            }
            else
            {
                return new RationalNumber(0, 0);
            }

        }
        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
        {
            int a = num1.getNumerator();
            int b = num1.getDenominator();
            int c = num2.getNumerator();
            int d = num2.getDenominator();

            if (!num1.IsZero & !num2.IsZero)
            {
                return new RationalNumber(a * c, b * d);
            }
            else if (num1.IsZero & !num2.IsZero)
            {
                return num2;
            }
            else if (!num1.IsZero & num2.IsZero)
            {
                return num1;
            }
            else
            {
                return new RationalNumber(0, 0);
            }

        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
