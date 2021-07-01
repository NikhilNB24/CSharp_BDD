using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator1
{
    class Calculator
    {
        public int firstNumber;
        public int secondNumber;

        public int add()
        {
            return firstNumber + secondNumber;
        }
        public int subtract()
        {
            return firstNumber - secondNumber;
        }
        public int multiply()
        {
            return firstNumber * secondNumber;
        }
        public int divide()
        {
            return firstNumber / secondNumber;
        }
    }
}
