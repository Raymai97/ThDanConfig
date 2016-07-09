

namespace ThDanConfig
{
    class th128 : th11
    {
        public th128()
        {
            // validLen is still 60
            // pos are exactly the same as th11
        }

        public override bool isDataValid(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x00] != 0x01) return false;
            if (b[0x01] != 0x80) return false;
            if (b[0x02] != 0x12) return false;
            foreach (int i in new int[] { 0x03, 0x05, 0x07, 0x09, 0x0B, 0x0D })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }

    }
}
