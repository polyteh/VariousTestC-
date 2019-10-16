using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary <int, string> myDict=new Dictionary<int, string>();

            //Derived myDerived = new Derived();

            //int i = 1;
            //Console.WriteLine($"i = { ++i}");
            int sum = 5;

            int[] myArray = new int[] {0, 1, 2, 3, 4, 5, 3, 8, 9 };

            Hashtable myHashtable = new Hashtable();

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myHashtable.Add(i, myArray[i]);

            //}
            //myHashtable.val

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myHashtable[sum-myArray[i]]!=i)
            //    {

            //    }
            //}



            Console.ReadKey();

        }
    }
    public class Base
    {
        public static void BasePrint()
        {

            Console.WriteLine("Static base");

        }

    }
    public class Derived : Base
    {

    }
}
