using System.IO;

namespace ThDanConfig
{
    class th15 : th14
    {
        public th15()
        {
            validLen = 108;
            pos_FLAGS = 0x28;
            pos_FLAGS2 = 0x29;
            pos_winPosX = 0x2C;
            pos_winPosY = 0x30;
        }

        public override bool isDataValid(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x00] != 0x02) return false;
            if (b[0x02] != 0x15) return false;
            foreach (int i in new int[] { 0x01, 0x03, 0x05, 0x07, 0x09, 0x0B, 0x17 })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }

    }
}
