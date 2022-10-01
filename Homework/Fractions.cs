using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Fractions
    {
        public double Numerator { get; protected set; }
        public double Denominator { get; protected set; }

        public Fractions(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("you can't divide by zero", nameof(denominator));
            }
            if (denominator < 0)
            {
                throw new ArgumentException("denominator can't be less than zero", nameof(denominator));
            }
            Numerator = numerator;
            Denominator = denominator;

        }

        public Fractions(Fractions fraction) : this(fraction.Numerator, fraction.Denominator)
        {

        }

        public override string ToString() => $"{Numerator}/{Denominator}";

        public static Fractions operator +(Fractions a) => a;
        public static Fractions operator -(Fractions a) => new Fractions(-a.Numerator, a.Denominator);
        public static Fractions operator +(Fractions a, Fractions b) => new Fractions(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        public static Fractions operator +(Fractions a, double b)
        {
            var temp = new Fractions(a.Denominator * b, a.Denominator);
            return a + temp;
        }
        public static Fractions operator -(Fractions a, Fractions b) => a + (-b);
        public static Fractions operator -(Fractions a, double b)
        {
            var temp = new Fractions(a.Denominator * b, a.Denominator);
            return a - temp;
        }

        public static Fractions operator *(Fractions a, Fractions b) => new Fractions(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        public static Fractions operator *(Fractions a, double b)
        {
            var temp = new Fractions(a.Denominator * b, a.Denominator);
            return a * temp;
        }
        public static Fractions operator /(Fractions a, Fractions b)
        {
            var num = a.Numerator * b.Denominator;
            var den = a.Denominator * b.Numerator;
            if (den < 0)
            {
                num *= -1;
                den *= -1;
            }
            return new Fractions(num, den);
        }

        public static Fractions operator /(Fractions a, double b)
        {
            var temp = new Fractions(a.Denominator * b, a.Denominator);
            return a / temp;
        }
    }
    public class FractWithIntPart : Fractions
    {
        public double IntPart { get; private set; }


        public FractWithIntPart(double intPart, double numerator, double denominator) : base(numerator, denominator)
        {

            IntPart = intPart;

            ConvertFraction();
        }

        public FractWithIntPart(double numerator, double denominator) : this(0, numerator, denominator)
        {

        }
        public FractWithIntPart(FractWithIntPart fraction) : base(fraction)
        {
            IntPart = fraction.IntPart;
            ConvertFraction();
        }
        public FractWithIntPart(Fractions fraction) : base(fraction)
        {
            ConvertFraction();
        }


        protected void ConvertFraction()
        {
            if (Numerator >= Denominator)
            {
                IntPart += (int)(Numerator / Denominator);
                Numerator %= Denominator;
            }


        }



        public FractWithIntPart(double intPart) : this(intPart, 0, 1)
        {
        }
        public override string ToString() => Numerator == 0 ? IntPart.ToString() : $"{IntPart} {base.ToString()}";
        public static FractWithIntPart operator +(FractWithIntPart a) => a;
        public static FractWithIntPart operator -(FractWithIntPart a) => new FractWithIntPart(-a.IntPart, -a.Numerator, a.Denominator);
        public static FractWithIntPart operator +(FractWithIntPart a, FractWithIntPart b) => new FractWithIntPart(a.IntPart + b.IntPart, a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);
        public static FractWithIntPart operator +(FractWithIntPart a, double b) => new FractWithIntPart(a.IntPart + b, a.Numerator, a.Denominator);
        public static FractWithIntPart operator -(FractWithIntPart a, FractWithIntPart b) => a + (-b);
        public static FractWithIntPart operator -(FractWithIntPart a, double b)
        {
            var temp = new FractWithIntPart(a.Denominator * b, a.Denominator);
            return a - temp;

        }
        public static FractWithIntPart operator *(FractWithIntPart a, FractWithIntPart b)
        {
            var den = a.Denominator * b.Denominator;

            var num = (a.Numerator + (a.IntPart * a.Denominator)) * (b.Numerator + (b.IntPart * b.Denominator));

            return new FractWithIntPart(num, den);

        }
        public static FractWithIntPart operator /(FractWithIntPart a, FractWithIntPart b)
        {
            var num = (a.Numerator + (a.IntPart * a.Denominator)) * b.Denominator;

            var den = (b.Numerator + (b.IntPart * b.Denominator)) * a.Denominator;

            return new FractWithIntPart(num, den);
        }
    }
}





