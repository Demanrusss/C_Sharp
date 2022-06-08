using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSample
{
    internal class AsyncSampleClass2
    {
        public Task<int> LongRunningFactorial(int value)
        {
            return Task.Run(() =>
            {
                int result = 1;

                for (int i = 1; i <= value; i++)
                {
                    result *= i;
                    Task.Delay(10).Wait();
                }

                return result;
            });
        }
    }
}
