using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Start Asynchronous Tasks");

        // Task 1: Simulate a time-consuming operation asynchronously
        Task task1 = Task.Run(async () =>
        {
            Console.WriteLine("Task 1 started");
            await Task.Delay(10000); // Simulate a 2-second delay asynchronously
            Console.WriteLine("Task 1 completed");
        });

        // Task 2: Simulate another time-consuming operation asynchronously
        Task task2 = Task.Run(async () =>
        {
            Console.WriteLine("Task 2 started");
            await Task.Delay(4000); // Simulate a 2-second delay asynchronously
            Console.WriteLine("Task 2 completed");
        });

        // Wait for both tasks to complete (non-blocking)
        await Task.WhenAll(task1, task2);

        Console.WriteLine("End Asynchronous Tasks");
    }
}