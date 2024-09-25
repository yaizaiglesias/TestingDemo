using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Operations
    {
        public int Add(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo; 
        }

        public bool isEven(int number)
        {
            if(number%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double AddDecimal(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
