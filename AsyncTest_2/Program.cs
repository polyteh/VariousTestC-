using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTest_2
{
    class Program
    {
        // просто поля для счетчика цикла и задержки
        public static int gain = 10;
        public static int delay = 500;
        public static int delayForTask = 7000;
        static void Main(string[] args)
        {
            // стрпватч для понимания, что мы таки асинхронны
            Stopwatch myWatch = new Stopwatch();
            myWatch.Start();

            // запустили таску, которая печатает X
            var result = Task<int>.Run(() =>
                {
                    Thread mainTask1 = Thread.CurrentThread;
                    Console.WriteLine($"Task 1 started with thread id {mainTask1.ManagedThreadId}");
                    for (int i = 0; i < gain; i++)
                    {
                        Console.WriteLine($"Print X from Task 1 with thread id {mainTask1.ManagedThreadId}");
                        Thread.Sleep(delay);
                    }
                    Console.WriteLine($"Task 1 completed with thread id {mainTask1.ManagedThreadId}");
                    return 1;
                });

            // запустили в главном потоке цикл, который печатает Y
            Thread mainFunc = Thread.CurrentThread;
            Console.WriteLine($"Main started with thread id {mainFunc.ManagedThreadId}");
            for (int i = 0; i < gain; i++)
            {
                Console.WriteLine($"Print Y from Main with thread id {mainFunc.ManagedThreadId}");
                Thread.Sleep(delay);
            }
            Console.WriteLine($"Main completed with thread id {mainFunc.ManagedThreadId}");

            // дефакто главный поток считает свое, а таска - свое
            Console.WriteLine($"result from task {result.Result}");
            myWatch.Stop();
            Console.WriteLine($"Timewas spent {myWatch.Elapsed.Seconds.ToString()} sec");
            Console.ReadKey();

        }
    }
}
