using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MusDecoder.io;

namespace MusDecoder
{
    public class MusCoder
    {
        private MusCoder()
        {
        }

        public static void decode(FileStream musFile)
        {
            String oggPath = 
                Path.Combine(Path.GetFileNameWithoutExtension(musFile.Name), ".ogg");
            FileStream oggFile = new FileStream(oggPath, FileMode.OpenOrCreate);

            MusInputStream mis = new MusInputStream(musFile, musFile.Name.GetHashCode());

            musFile.Close();
            FileUtils.deleteQuietly(musFile);
        }
    }
}