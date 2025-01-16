using System;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting tasks using Task Parallel Library...");

            // Create and start tasks
            Task task1 = Task.Run(() => PrintNumbers());
            Task task2 = Task.Run(() => PrintCharacters());

            // Wait for both tasks to complete concurrently
            await Task.WhenAll(task1, task2);

            Console.WriteLine("All tasks have completed execution.");
        }

        public static void PrintNumbers()
        {
            for (int n = 1; n <= 10; n++)
            {
                Console.WriteLine(n);
                Task.Delay(100);
            }
        }

        public static void PrintCharacters()
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.WriteLine(ch);
                Task.Delay(100);
            }
        }
    }
}
