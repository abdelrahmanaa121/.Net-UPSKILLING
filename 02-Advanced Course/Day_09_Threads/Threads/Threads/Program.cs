using System;

namespace Threads
{
    internal class Program
    {
        static Queue<int> table = new Queue<int>();
        static int tablecapacity = 5;
        static readonly object lockobject = new object();
        static void Main(string[] args)
        {
            //1- Text Search Engine:
            #region Text Search Engine:
            Console.WriteLine("\n-------------Text Search Engine-------------\n");
            string text = "Hello world\n" +
                      "This is a test line\n" +
                      "We are looking for the target word\n" +
                      "This line should not be processed\n" +
                      "Another line with target but we won't reach it";
            string searchword = "target";
            Console.WriteLine($"Searching for {searchword} .....");
            SearchWordInText(searchword, text);
            #endregion
            //2- Producer-Consumer Problem:
            #region Producer-Consumer Problem : using Thread
            Console.WriteLine("\nProducer-Consumer Problem : using Thread\n");

            Thread producer1 = new Thread(() => Produce(1));
            Thread producer2 = new Thread(() => Produce(2));

            Thread consumer1 = new Thread(() => Consume(1));
            Thread consumer2 = new Thread(() => Consume(2));

            producer1.Start();
            producer2.Start();
            consumer1.Start();
            consumer2.Start();

            Thread.Sleep(5000);
            Console.WriteLine("\n[System shutting down...]");
            Environment.Exit(0); //ShutDown all threads

            #endregion
        }
        public static void SearchWordInText(string word, string text)
        {
            string[] stringlist = text.Split('\n');

            // Define the cancellation token.
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;

            //Task (Short term runnig operation)
            Task[] tasks = new Task[stringlist.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                int linenumber = i;
                string CurrentLine = stringlist[i];
                tasks[i] = Task.Run(() =>
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine($"[STOPPED] Thread for line {{lineNumber}} canceled before searching");
                        return;
                    }
                    Thread.Sleep(100);
                    if (CurrentLine.Contains(word))
                    {
                        Console.WriteLine($"[FOUND] Word '{word}' found in line {linenumber}");
                        source.Cancel();
                    }
                    else
                    {
                        Console.WriteLine($"Line {linenumber} checked. '{word}' Not found.");
                    }
                }, token);
            }
            try
            {
                Task.WaitAll(tasks);
            }
            catch (AggregateException)
            {

                //na
            }
            Console.WriteLine("\nSearch process finished.\n");
        }

        public static void Produce(int producerId)
        {
            int itemNumber = 1;
            while (true)
            {
                lock (lockobject)
                {
                    while (table.Count >= tablecapacity)
                    {
                        Console.WriteLine($"Producer {producerId}: Table is FULL. Waiting...");
                        Monitor.Wait(lockobject);
                    }
                    int item = (producerId * 100) + itemNumber++; //تسمية
                    table.Enqueue(item);
                    Console.WriteLine($" [+] Producer {producerId} produced item {item}. Table count: {table.Count}");
                    //wake other consumers
                    Monitor.PulseAll(lockobject);
                }
                Thread.Sleep(new Random().Next(100, 300)); // timing
            }
        }
        public static void Consume(int consumerId)
        {
            while (true)
            {
                lock (lockobject)
                {
                    while (table.Count == 0)
                    {
                        Console.WriteLine($"Consumer {consumerId}: Table is empty. Waiting...");
                        Monitor.Wait(lockobject);
                    }
                    int item = table.Dequeue();
                    Console.WriteLine($" [-] Consumer {consumerId} consumed item {item}. table count: {table.Count}");
                    Monitor.PulseAll(lockobject);
                }
                Thread.Sleep(new Random().Next(150, 400)); // timing
            }
        }
    }
}
