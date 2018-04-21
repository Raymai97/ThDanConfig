using System.IO;

namespace MaiSoft
{
    class th14 : thCom_th11
    {
        public th14()
        {
            validLen = 92;
            pos_joyX = 0x18;
            pos_joyY = 0x1A;
            pos_FLAGS = 0x38;
            pos_FLAGS2 = 0x39;
            pos_winPosX = 0x28;
            pos_winPosY = 0x2C;
            pos_color = 0x1C;
            pos_display = 0x1F;
            pos_fps = 0x20;
            pos_inputLat = 0x25;
            pos_bgmVol = 0x22;
            pos_seVol = 0x23;
            pos_bgmMode = 0x1D;
            pos_seEnabled = 0x1E;
        }

        public int validDataLength()
        {
            return validLen;
        }

        public override bool validate(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x00] != 0x02) return false;
            if (b[0x02] != 0x14) return false;
            foreach (int i in new int[] { 0x01, 0x03, 0x05, 0x07, 0x09, 0x0B, 0x17 })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }

        public new DISP3 display
        {
            get
            {
                switch (data[pos_display])
                {
                    case 0: return DISP3.LOW;
                    case 1: return DISP3.MED;
                    case 2: return DISP3.HIGH;
                    case 3: return DISP3.LOW_WIN;
                    case 4: return DISP3.MED_WIN;
                    case 5: return DISP3.HIGH_WIN;
                    default: throw new InvalidDataException();
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case DISP3.LOW: val = 0; break;
                    case DISP3.MED: val = 1; break;
                    case DISP3.HIGH: val = 2; break;
                    case DISP3.LOW_WIN: val = 3; break;
                    case DISP3.MED_WIN: val = 4; break;
                    case DISP3.HIGH_WIN: val = 5; break;
                    default: return;
                }
                data[pos_display] = val;
            }
        }

        // FLAGS
        public bool hasRunGameOnce
        {
            get
            {
                return hasFlag(FLAGS.HAS_RUN_GAME_ONCE, data[pos_FLAGS]);
            }
        }


    }
}
