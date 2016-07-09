

namespace ThDanConfig
{
    class th125 : th11
    {
        public th125()
        {
            // validLen is still 60
            // pos are exactly the same as th11
        }

        public override bool isDataValid(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x00] != 0x01) return false;
            if (b[0x01] != 0x05) return false;
            if (b[0x02] != 0x12) return false;
            foreach (int i in new int[] { 0x03, 0x05, 0x07, 0x09, 0x0B })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }
    }
}
