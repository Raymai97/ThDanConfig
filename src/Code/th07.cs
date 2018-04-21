using System;

namespace MaiSoft
{
    class th07 : thCom_th07_th08
    {
        public th07()
        {
            validLen = 56;
            pos_joyX = 0x18;
            pos_joyY = 0x1A;
            pos_initialLife = 0x1C;
            pos_color = 0x1E;
            pos_bgmMode = 0x1F;
            pos_seEnabled = 0x20;
            pos_defDifficulty = 0x21;
            pos_display = 0x22;
            pos_fps = 0x23;
            pos_effectQuality = 0x24;
            // 0x25 and 0x26 are specified in base class
            pos_FLAGS = 0x34;
            pos_FLAGS2 = 0x35;
            hasMIDI = true;
            min_initialLife = 1;
            max_initialLife = 5;
        }

        public override bool validate(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x14] != 0x02) return false;
            if (b[0x16] != 0x07) return false;
            foreach (int i in new int[] { 0x01, 0x03, 0x05, 0x07, 0x11, 0x15, 0x17 })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }

        // unsupported...
        [Obsolete("Not supported by TH06/07.", true)]
        public new int bgmVol
        {
            set { }
        }
        [Obsolete("Not supported by TH06/07.", true)]
        public new int seVol
        {
            set { }
        }



    }
}
