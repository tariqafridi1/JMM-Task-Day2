using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Start Asynchronous Tasks");

        
        Task task1 = Task.Run(async () =>
        {
            Console.WriteLine("Task 1 started");
            await Task.Delay(10000); 
            Console.WriteLine("Task 1 completed");
        });

        Task task2 = Task.Run(async () =>
        {
            Console.WriteLine("Task 2 started");
            await Task.Delay(4000); 
            Console.WriteLine("Task 2 completed");
        });

        
        await Task.WhenAll(task1, task2);

        Console.WriteLine("End Asynchronous Tasks");
    }
}