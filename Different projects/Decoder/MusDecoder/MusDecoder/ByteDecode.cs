using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusDecoder
{
    /// <summary>
    /// Decodes any byte using hashCode from the input file
    /// </summary>
    abstract class ByteDecode
    {
        /// <summary>
        /// Formula is:
        ///      new byte = byte ^ hashCode >> 8;
        ///      hashCode = hashCode * 498729871 + 85731 * byte;
        /// </summary>
        /// <param name="b"></param>
        /// <param name="hashCode"></param>
        /// <returns>new byte after decoding</returns>
        public static byte Decode(byte b, int hashCode)
        {
            b = (byte)(b ^ hashCode >> 8);
            hashCode = hashCode * 498729871 + 85731 * b;
            return b;
        }
    }
}