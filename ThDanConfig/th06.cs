using System;

namespace ThDanConfig
{
    class th06 : thCom_th06_07_08
    {
        public th06()
        {
            validLen = 56;
            pos_joyX = 0x20;
            pos_joyY = 0x22;
            pos_FLAGS = 0x34;
            pos_FLAGS2 = 0x35;
            pos_color = 0x1A;
            pos_display = 0x1E;
            pos_fps = 0x1F;
            pos_bgmMode = 0x1B;
            pos_defDifficulty = 0x1D;
            pos_initialLife = 0x18;
            pos_seEnabled = 0x1C;
            hasMIDI = true;
            min_initialLife = 1;
            max_initialLife = 5;
        }

        public override bool isDataValid(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x14] != 0x02) return false;
            if (b[0x15] != 0x01) return false;
            foreach (int i in new int[] { 0x01, 0x03, 0x05, 0x16, 0x17 })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }

        public int initialBomb
        {
            get
            {
                return data[0x19];
            }
            set
            {
                makeSureWithin(ref value, 0, 3);
                data[0x19] = (byte)value;
            }
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
        [Obsolete("Not supported by TH06.", true)]
        public new EFFECT effectQuality
        {
            set { }
        }

        // th06-only OLDFLAGS
        public bool dontUseTrialVerMenuColor
        {
            get
            {
                return hasFlag(OLDFLAGS.DONT_USE_TRIALVER_MENU_COLOR, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS.DONT_USE_TRIALVER_MENU_COLOR, !value, ref data[pos_FLAGS]);
            }
        }

    }
}
