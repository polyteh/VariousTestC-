using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDateTimeConsole
{
    public static class Recursion
    {
        public static int Factorial(int n)
        {
            if (n > 1)
                return checked(n * Factorial(n - 1));
            return 1;
        }
        public static int OverFlow(int n)
        {
            return checked(int.MaxValue + n);
        }
        public static byte OverFlowByte(byte n)
        {
           return checked((byte)(n*1000));
        }

        public static double Factorial(double n)
        {
            if (n > 1)
                return checked(n * Factorial(n - 1));
            return 1;
        }



    }
}
