using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        private int a, b;
        public int FindMinimum(int number1, int number2)
        {
            return number1 < number2 ? number1 : number2;
        }
        public int FindMinimum(int number1, int number2, float number3)
        {
            a = number1 < number2 ? number1 : number2;
            b = number2 < number3 ? number2 : (int)number3;
            return number3 < number1 ? (int)number3 : number1;
        }
        public int FindMaximum(int number1, int number2)
        {
            return number1 > number2 ? number1 : number2;
        }
        public int FindMaximum(int number1, int number2, int number3)
        {
            a = number1 > number2 ? number1 : number2;
            b = number2 > number3 ? number2 : (int)number3;
            return number3 > number1 ? (int)number3 : number1;
        }
    }
}
