/*using System;
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

        public MusOutputStream(Stream out, int hashCode)
        {
            super(out);
            hash = hashCode;
        }

        private byte encode(byte b)
        {
            byte b2 = (byte)(b ^ hash >> 8);
            hash = hash * 498729871 + 85731 * b;
            return b2;
        }

        //@Override
        public void write(int b)
        {
            out.write(encode((byte)b));
        }

        //@Override
        public void write(byte[] b, int off, int len)
        {
            for (int i = 0; i < len; ++i)
                b[off + i] = encode(b[off + i]);

                out.write(b, off, len);
        }
    }
}
*/