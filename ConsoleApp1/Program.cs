using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Start Synchronous Tasks");

        Task task1 = Task.Run(() =>
        {
            Console.WriteLine("Task 1 started");
            Thread.Sleep(2000); 
            Console.WriteLine("Task 1 completed");
        });

       Task task2 = Task.Run(() =>
       {
           Console.WriteLine("Task 2 started");
           Thread.Sleep(8000); 
           Console.WriteLine("Task 2 completed");
       });

        
        Task.WaitAll( );

        Console.WriteLine("End Synchronous Tasks");
    }
}