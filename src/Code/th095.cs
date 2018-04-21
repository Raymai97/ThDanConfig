using System;

namespace MaiSoft
{
    class th095 : thCom_th09_th095
    {
        public th095()
        {
            validLen = 200;
            pos_joyX = 0xA8;
            pos_joyY = 0xAA;
            pos_FLAGS = 0xC4; // th095 has OLDFLAGS3 only
            pos_color = 0xAC;
            pos_display = 0xAF;
            pos_fps = 0xB0;
            pos_bgmVol = 0xB5;
            pos_seVol = 0xB6;
            pos_effectQuality = 0xB1;
            pos_seEnabled = 0xAE;
        }

        public override bool validate(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0xA4] != 0x01) return false;
            if (b[0xA5] != 0x50) return false;
            if (b[0xA6] != 0x09) return false;
            foreach (int i in new int[] {0x01, 0x05, 0x07, 0xA7})
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }


        [Obsolete("TH095 doesn't have difficult mode selection.", true)]
        public new DIFFICULTY defDifficulty
        {
            set { }
        }

        [Obsolete("TH095 doesn't have 'life' (LOL), the game over when you died once.", true)]
        public new int initialLife
        {
            set { }
        }

    }
}
