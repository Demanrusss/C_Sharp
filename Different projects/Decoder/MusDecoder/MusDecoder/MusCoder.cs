/*using System;
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

        public static void decode(File musFile)
        {
            InputStream is = null;

            String oggPath = FilenameUtils.removeExtension(musFile.getPath()) + ".ogg";
            File oggFile = new File(oggPath);

            is = new MusInputStream(new FileInputStream(musFile), musFile.getName().hashCode());
            FileUtils.copyInputStreamToFile(is, oggFile);
            FileUtils.deleteQuietly(musFile);
        }
    }
}
*/