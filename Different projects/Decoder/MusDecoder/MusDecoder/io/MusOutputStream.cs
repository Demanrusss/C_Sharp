using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusDecoder.IO
{
    public class MusOutputStream
    {
        private int _hash;
        private FileStream _fs;

        public MusOutputStream(FileStream fileStream, int hashCode)
        {
            _fs = fileStream;
            _hash = hashCode;
        }

        private byte Encode(byte b)
        {
            byte b2 = (byte)(b ^ _hash >> 8);
            _hash = _hash * 498729871 + 85731 * b;
            return b2;
        }

        public void Write(byte b)
        {
            _fs.WriteByte(Encode(b));
        }

        public void Write(byte[] b, int off, int len)
        {
            for (int i = 0; i < len; ++i)
                b[off + i] = Encode(b[off + i]);

            _fs.Write(b, off, len);
        }
    }
}