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
        private MusCoder()
        {
        }

 /*       public static void decode(FileStream musFile)
        {
            String oggPath = File.removeExtension(musFile.getPath()) + ".ogg";
            FileStream oggFile = new FileStream(oggPath);

            MusInputStream is = new MusInputStream(new FileInputStream(musFile), musFile.getName().hashCode());
            FileUtils.copyInputStreamToFile(is, oggFile);
            FileUtils.deleteQuietly(musFile);
        }*/
    }
}