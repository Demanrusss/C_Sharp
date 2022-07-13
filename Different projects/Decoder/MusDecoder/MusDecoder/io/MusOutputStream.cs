using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusDecoder.io
{
    public class MusOutputStream
    {
        private int hash;
        private FileStream fs;

        public MusOutputStream(FileStream fileStream, int hashCode)
        {
            fs = fileStream;
            hash = hashCode;
        }

        private byte Encode(byte b)
        {
            byte b2 = (byte)(b ^ hash >> 8);
            hash = hash * 498729871 + 85731 * b;
            return b2;
        }

        //@Override
        public void Write(byte b)
        {
            fs.WriteByte(Encode(b));
        }

        //@Override
        public void Write(byte[] b, int off, int len)
        {
            for (int i = 0; i < len; ++i)
                b[off + i] = Encode(b[off + i]);

                fs.Write(b, off, len);
        }
    }
}