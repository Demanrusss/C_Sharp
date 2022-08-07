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
        public static void Transcode(FileStream file)
        {
            string? ext = Path.GetExtension(file.Name);

            if (ext.Equals(".mus"))
            {
                Decode(file);
            } 
            else if (ext.Equals(".ogg"))
            {
                Encode(file);
            }
            else
            {
                throw new FileFormatException("Invalid file extension");
            }
        }

        public static void Decode(FileStream musFile)
        {
            string oggPath = 
                Path.GetFileNameWithoutExtension(musFile.Name) + ".ogg";
            
            FileStream oggFile = new FileStream(oggPath, FileMode.OpenOrCreate);

            MusInputStream mis = new MusInputStream(musFile, musFile.Name.GetHashCode());

            musFile.Close();
        }

        public static void Encode(FileStream oggFile)
        {
//            FileStream inOggFile = null;
//            FileStream outOggFile = null;

            string musPath = 
                Path.Combine(Path.GetFileNameWithoutExtension(oggFile.Name), ".mus");
            FileStream musFile = new FileStream(musPath, FileMode.OpenOrCreate);

 /*           try
            {
                inOggFile = File.OpenRead(oggFile.Name);
                outOggFile = new MusOutputStream(musFile, musFile.Name.GetHashCode());
                File.Copy(inOggFile, outOggFile);
                IOUtils.closeQuietly(is);
            } */
        }
    }
}