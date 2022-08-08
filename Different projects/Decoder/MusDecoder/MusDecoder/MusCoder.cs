using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MusDecoder.IO;

namespace MusDecoder
{
    public class MusCoder
    {
        private static string _extension = String.Empty;

        public static void Transcode(string file)
        {
            string? ext = Path.GetExtension(file);

            if (ext.Equals(".mus"))
            {
                _extension = ".ogg";
                Decode(file);
            } 
            else if (ext.Equals(".ogg"))
            {
                _extension = ".mus";
                Decode(file);
            }
            else
            {
                throw new FileFormatException("Invalid file extension");
            }
        }

        public static void Decode(string file)
        {
            FileStream inputFile = 
                new FileStream(file, FileMode.Open, FileAccess.Read);

            string outFilePath = Path.ChangeExtension(file, _extension);

            FileStream outputFile = 
                new FileStream(outFilePath, FileMode.OpenOrCreate, FileAccess.Write);

            MusInputStream mis = 
                new MusInputStream(inputFile, inputFile.Name.GetHashCode());

            mis.

            inputFile.Close();
            outputFile.Close();
        }

 /*       public static void Encode(FileStream oggFile)
        {
            string musPath = Path.ChangeExtension(oggFile.Name, ".mus");
 
            FileStream musFile = new FileStream(musPath, FileMode.OpenOrCreate);
            MusOutputStream mos = new MusOutputStream(oggFile, oggFile.Name.GetHashCode());

            oggFile.Close();
            musFile.Close();
        }*/
    }
}