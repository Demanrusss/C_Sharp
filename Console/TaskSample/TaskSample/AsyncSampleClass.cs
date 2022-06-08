using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TaskSample
{
    internal class AsyncSampleClass
    {
        public async Task<string> AccessTheWebAsync()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("http://www.flenov.info/robots.txt");

            return await getStringTask;
        }

        public int SyncFactorial(int value)
        {
            int result = 1;

            for (int i = 1; i <= value; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
