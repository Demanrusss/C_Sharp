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
        private int _hash;
        private FileStream _fs;

        public MusInputStream(FileStream fileStream, int hashCode)
        {
            _fs = fileStream;
            _hash = hashCode;
        }

        private byte Decode(byte b)
        {
            b = (byte)(b ^ _hash >> 8);
            _hash = _hash * 498729871 + 85731 * b;
            return b;
        }

        public int Read()
        {
            return Decode((byte)_fs.ReadByte());
        }

        public int Read(byte[] b, int off, int len)
        {
            len = Read(b, off, len);
                
            for (int i = 0; i < len; ++i)
                b[off + i] = Decode(b[off + i]);

            return len;
        }
    }
}