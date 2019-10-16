using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Test
{
    class Program
    {
        // просто поля для счетчика цикла и задержки
        public static int gain = 10;
        public static int delay = 500;
        public static int delayForTask = 7000;
        static void Main(string[] args)
        {
            // чтобы не смотреть на секундомер
            Stopwatch watch = new Stopwatch();
            watch.Start();

            Console.WriteLine("Started test");
            // запустили асинхронный метод
            var t = Test();
            //Test().Wait();
            // получили свойства главного потока, начали крутить цикл в главном потоке
            Thread threaMain = Thread.CurrentThread;
            Console.WriteLine("Started for in the  main");
            for (int i = 0; i < gain; i++)
            {
                // на вывод бросаем Y и номер потока
                Console.WriteLine($"Print Y from main: Y, thread {threaMain.ManagedThreadId}");
                Thread.Sleep(delay);
            }
           // Console.WriteLine($"Get result in the main {t.Result}");
            Console.WriteLine("Finish main");

            watch.Stop();
            Console.WriteLine($"Timewas spent {watch.Elapsed.Seconds.ToString()} sec");
            Console.ReadKey();
        }
        public static int MakeSomeWork()
        // public static async Task<int> MakeSomeWork()
        {
            Console.WriteLine("In the MakeSomeWorkMethod");
            // получили свойства рабоченр потока, начали крутить цикл в рабочем потоке 
            Thread threadInWork = Thread.CurrentThread;
            //Thread.Sleep(delay);
            for (int i = 0; i < gain; i++)
            {
                Console.WriteLine($"Print X from MakeSomeWork: X, thread {threadInWork.ManagedThreadId}");
                //вариант 1
                Thread.Sleep(delay);

                //вариант 2
                //Task.Delay(delayForTask)

                // вариант 3 (вместе с изменением самого метода на async
                //await Task.Delay(delayForTask);
            }
            Console.WriteLine("Finish MakeSomeWork");
            return 1;
        }
        private static async Task<int> Test()
        {
            Console.WriteLine($"In the test");
            // запустили асинхронно другую работу
            var result = await Task.Run(MakeSomeWork);
            //var result2=await MakeSomeWork();
            return result;
        }
    }

}
