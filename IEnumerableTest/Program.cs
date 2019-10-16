using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //            List<int> myIntList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // создали лист int, при выводе  печатает 1    2    3    4    5    6    7    8    9
            //            ...
            //IEnumerable<int> myQuery = myIntList.FindAll((x) => x > 3); // сделали выборку по листу, на печать ожидаемо идет  4    5    6    7    8    9
            //            ...
            //myIntList[5] = 1;// изменили 5й элемент в листе с 6 на 1
            //            ...
            //// при выводе myIntList и myQuery вывод не изменился
            //а теперь вопрос: а где хранит данные IEnumerable<int> myQuery??
            //я полагал, что IEnumerable<int> myQuery = myIntList.FindAll((x) => x > 3) делает выборку элементов базового List и работает со ссылками на исходный List.
            //А теперь получается, что IEnumerable<int> myQuery имеет собственную копию данных, хотя это вроде как интерфейс и полей у него нет?


            // при вызове FIndAll идет возврат List<int>, который возвращает новый List
            // при вызове Where идет возврат IEnumerable<int>, что сохраняет ссылку на исходный List


            List<int> myIntList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var item in myIntList)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine();
            IEnumerable<int> myQuery = myIntList.FindAll((x) => x > 3);
            IEnumerable<int> mySecondQuery = myIntList.Where((x) => x > 3);
            foreach (var item in myQuery)
            {
                Console.Write($"{item,5}");
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', 20));
            myIntList[5] = 1;

            foreach (var item in myIntList)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine();

            foreach (var item in mySecondQuery)
            {
                Console.Write($"{item,5}");
            }

            Console.ReadKey();


        }
    }
}
