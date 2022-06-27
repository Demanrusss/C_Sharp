using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace HttpClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebRequest request;
            string url = @"http://www.flenov.info";

            try
            {
                request = HttpWebRequest.Create(url);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not download a file");
                return;
            }

            // Another way
            HttpWebRequest request2;
            request2 = (HttpWebRequest)HttpWebRequest.Create(url);

            // Reading data from Web-request
            HttpWebResponse response = (HttpWebResponse)request2.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            StringBuilder pagebuilder = new StringBuilder();

            string line;
            while ((line = reader.ReadLine()) != null)
                pagebuilder.AppendLine(line);

            response.Close();
            reader.Close();
            Console.WriteLine(pagebuilder.ToString());
        }
    }
}
