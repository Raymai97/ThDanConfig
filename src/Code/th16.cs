using System;
using System.Collections.Generic;
using System.Text;

namespace MaiSoft
{
    class th16 : th15
    {
        public th16()
        {
            validLen = 100;
        }

        public override bool validate(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x00] != 0x02) return false;
            if (b[0x02] != 0x16) return false;
            foreach (int i in new int[] { 0x01, 0x03, 0x05, 0x07, 0x09, 0x0B, 0x17 })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }
    }
}
