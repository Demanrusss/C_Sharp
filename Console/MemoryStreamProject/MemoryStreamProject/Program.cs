using System;
using System.Text;
using System.IO;

namespace MemoryStreamProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string STRING_EXAMPLE = "This string we are going to put into memory";

            // Transform string to array of symbols
            UnicodeEncoding unicode = new UnicodeEncoding();
            byte[] bytes = unicode.GetBytes(STRING_EXAMPLE);
            int string_size = unicode.GetByteCount(STRING_EXAMPLE);

            // Create memory stream and write data into it
            MemoryStream mstream = new MemoryStream(string_size);
            mstream.Write(bytes, 0, string_size);

            // Move to the very beginning of the stream
            mstream.Seek(0, SeekOrigin.Begin);

            // Create buffer
            byte[] buffer = new byte[string_size];

            // Read the stream of data
            mstream.Read(buffer, 0, string_size);
            Console.WriteLine(unicode.GetString(buffer));
        }
    }
}
