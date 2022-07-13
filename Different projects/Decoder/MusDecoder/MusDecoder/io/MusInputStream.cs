using System;
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
        private FileStream fs;

        public MusInputStream(FileStream fileStream, int hashCode)
        {
            fs = fileStream;
            hash = hashCode;
        }

        private byte Decode(byte b)
        {
            b = (byte)(b ^ hash >> 8);
            hash = hash * 498729871 + 85731 * b;
            return b;
        }

        //@Override
        public int Read()
        {
            return Decode((byte)fs.ReadByte());
        }

        //@Override
        public int Read(byte[] b, int off, int len)
        {
            len = Read(b, off, len);
                
            for (int i = 0; i < len; ++i)
                b[off + i] = Decode(b[off + i]);

            return len;
        }
    }
}