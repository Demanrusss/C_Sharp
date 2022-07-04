/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusDecoder.io
{
    public class MusInputStream
    {
        private int hash;

        public MusInputStream(FileStream in, int hashCode)
        {
            hash = hashCode;
        }

        private byte decode(byte b)
        {
            b = (byte)(b ^ hash >> 8);
            hash = hash * 498729871 + 85731 * b;
            return b;
        }

        //@Override
        public int read()
        {
            return decode((byte)in.read());
        }

        //@Override
        public int read(byte[] b, int off, int len)
        {
            len = read(b, off, len);
                
            for (int i = 0; i < len; ++i)
                b[off + i] = decode(b[off + i]);

            return len;
        }
    }
}*/