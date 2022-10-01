using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class ComplexNumbers
    {
        public double _realPart { get; private set; }
        public double _imaginaryUnit { get; private set; }
        public ComplexNumbers(double realPart, double imaginaryUnit)
        {
            _realPart = realPart;
            _imaginaryUnit = imaginaryUnit;
        }

       
        public ComplexNumbers Plus(ComplexNumbers number2)
        {
             ComplexNumbers result = new ComplexNumbers(_realPart + number2._realPart, _imaginaryUnit + number2._imaginaryUnit);

             return result;
        }
        public ComplexNumbers Minus(ComplexNumbers number2)
        {
            ComplexNumbers result = new ComplexNumbers(_realPart - number2._realPart, _imaginaryUnit - number2._imaginaryUnit);

            return result;
        }

        public void PrintNumber()
        {
            Console.WriteLine($"({_realPart}, {_imaginaryUnit}");
        }


    }




}

