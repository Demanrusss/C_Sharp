using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusDecoder
{
    public class MusCoder
    {
        public static string outFilePath = String.Empty;

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

        private static void Decode(string file)
        {
            try
            {
                FileStream inputFile =
                    new FileStream(file, FileMode.Open, FileAccess.Read);

                outFilePath = Path.ChangeExtension(file, _extension);

                FileStream outputFile =
                    new FileStream(outFilePath, FileMode.Create, FileAccess.Write);

                using (BinaryReader binReader = new BinaryReader(inputFile))
                {
                    using (BinaryWriter binWriter = new BinaryWriter(outputFile))
                    {
                        byte readByte;
                        byte toWriteByte;
                        int hash = inputFile.GetHashCode();
                        byte[] buffer = new byte[inputFile.Length];
                        int i = 0;

                        do
                        {
                            readByte = binReader.ReadByte();
                            toWriteByte = ByteDecode.Decode(readByte, hash);
                            buffer[i++] = toWriteByte;

                        } while (binReader.ReadByte() != 0);

                        binWriter.Write(buffer);
                    }
                }

                inputFile.Close();
                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong with\n {ex.Message}");
            }
        }
    }
}