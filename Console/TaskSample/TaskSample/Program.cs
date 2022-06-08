using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TaskSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a class
            AsyncSampleClass c = new AsyncSampleClass();

            // Evoke a method for download a file from Internet
            Task<string> asyncContent = c.AccessTheWebAsync();

            // Show the status of a task
            Console.WriteLine("Status of a task: " + asyncContent.Status);

            // Calculate and show the factorial
            Console.WriteLine("Factorial " + c.SyncFactorial(15).ToString());

            // Waiting for completing the download
            string webContent = asyncContent.Result;

            // Content of the file
            Console.WriteLine("The result from the site:");
            Console.WriteLine(webContent);
            Console.ReadLine();

            // Second class
            AsyncSampleClass2 c2 = new AsyncSampleClass2();
            var factorialTask = c2.LongRunningFactorial(12);

            while (factorialTask.Status != TaskStatus.RanToCompletion)
            {
                Console.WriteLine("Status = " + factorialTask.Status);
                Task.Delay(100).Wait();
            }

            Console.WriteLine("Status = " + factorialTask.Status);
            Console.WriteLine("Result = " + factorialTask.Result);
        }
    }
}
