using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {

        private static Random random = new Random();

        //CTRL+M - создает отдельный метод для какой-то функциональности
        static void Main(string[] args)
        {

            //========================================

            ////ПЕРВЫЙ МЕТОД
            //Task.Factory.StartNew(() =>
            //{ 
            //    printSomething();
            //});

            ////второй метод
            //var task1 = new Task(printSomething);

            ////третий метод
            //var task2 = new Task(delegate
            //{
            //    printSomething();
            //});
            ////четвертый метод
            //var task3 = new Task(() => { printSomething(); });

            //для методов
            //task1.Start();
            //task2.Start();
            //task3.Start();


            //===================================

            //var task1 = new Task(new Action<object>(printSomething), 1);
            //var task2 = new Task(printSomething, 1);
            //var task3 = new Task(x => printSomething(x), 2);
            //var task4 = new Task(printSomething, 3);


            //====================================

            //string[] msgs = { "one", "two", "three" };
            //foreach (var msg in msgs)
            //{
            //    var result = new Task(printSomething, msg);
            //    result.Start();
            //}


            //==================================

            //Task<int> task = new Task<int>( z =>
            //{
            //    int s = 0;
            //    for (int i = 0; i < (int) z; ++i)
            //        s += i;
            //    return s;
            //}, 10 );
            //task.Start();

            //var result = task.Result;
            //Console.WriteLine(result);


            //======================================

            //var tcs = new CancellationTokenSource();
            //var token = tcs.Token;

            //Task task = new Task(() => 
            //{

            //    for (int i = 0; i<int.MaxValue; ++i)
            //    {
            //        if (token.IsCancellationRequested)
            //        {
            //            Console.WriteLine("cancelend:(");
            //            throw new OperationCanceledException(token);
            //        } else
            //        {
            //            Console.Write(".");
            //        }
            //    }

            //}, token);

            //Task task2 = new Task(() =>
            //{
            //    token.WaitHandle.WaitOne();
            //    Console.WriteLine("TASK 2 WORKING");
            //});
            //task2.Start();

            //token.Register(() =>
            //{
            //    Console.WriteLine("cancel delegate called");
            //});

            //Console.WriteLine("press <enter> to start");
            //Console.ReadLine();
            //task.Start();

            //Console.ReadLine();
            //Console.WriteLine("canceling task");
            //tcs.Cancel();
            //Console.WriteLine("ALL DONE");
            //Console.ReadKey();


            //==================================================================================================

            var cts1 = new CancellationTokenSource();
            var cts2 = new CancellationTokenSource();
            var cts3 = new CancellationTokenSource();

            var cts = CancellationTokenSource.CreateLinkedTokenSource(cts1.Token, cts2.Token, cts3.Token);

            var task = new Task(() =>
            {
                Console.WriteLine("Waiting");
                bool cancelend = cts.Token.WaitHandle.WaitOne(5000);
                Console.WriteLine("Canceled");
                if (cancelend)
                    throw new OperationCanceledException(cts.Token);
            });

            task.Start();
            task.Wait(2000);
            Console.ReadLine();

        }

        private static void printSomething(object x)
        {
            Console.WriteLine("Hello task " + x);
        }
    }
}
