

namespace MaiSoft
{
    class th143 : th14
    {
        public th143()
        {
            // validLen
            // pos
            // ... are exactly the same as base (th14)
        }

        internal new bool validate(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x00] != 0x01) return false;
            if (b[0x01] != 0x01) return false;
            if (b[0x02] != 0x43) return false;
            if (b[0x03] != 0x01) return false;
            foreach (int i in new int[] { 0x05, 0x07, 0x09, 0x0B, 0x17 })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }

    }
}
