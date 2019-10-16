using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDateTimeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int int_f = 1000;
            double d_f = 1000;
            //Console.WriteLine(DateTime.Now);
            try
            {
                int result_int = checked(Recursion.Factorial(int_f));
                Console.WriteLine($"factorial of int={int_f} is {result_int}");

                //double result_double = checked(Recursion.Factorial(d_f));
                //Console.WriteLine($"factorial of int={d_f} is {result_double}");

                //int result2 = Recursion.OverFlow(n);
                // Console.WriteLine($"Overflow {n} is {result2}");

                //byte result3 = Recursion.OverFlowByte((byte)n);
                //Console.WriteLine($"Overflow byte {n} is {result3}");

            }
            catch (ArithmeticException)
            {
                Console.WriteLine("value is too big");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.ReadKey();
        }
    }
}
