using System;
using System.Collections.Generic;

namespace NewTalentsDioBootcamp
{
    public class Calculator
    {
        private readonly LimitedStack<string> historic = new LimitedStack<string>(3);

        public int Sum(int val1, int val2)
        {
            var res = val1 + val2;
            historic.Push("Val: " + res);
            return res;
        }

        public int Subtract(int val1, int val2)
        {
            var res = val1 - val2;
            historic.Push("Val " + res);

            return res;
        }

        public int Multiply(int val1, int val2)
        {
            var res = val1 * val2;
            historic.Push("Val " + res);
            return res;
        }

        public int Divide(int val1, int val2)
        {
            if (val2 == 0) throw new DivideByZeroException();

            var res = val1 / val2;
            historic.Push("Val " + res);
            return res;
        }

        public LimitedStack<string> Historic()
        {
            return historic;
        }
}
}
