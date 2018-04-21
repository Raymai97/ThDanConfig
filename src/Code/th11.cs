

namespace MaiSoft
{
    class th11 : thCom_th11
    {
        public th11()
        {
            validLen = 60;
            pos_joyX = 0x16;
            pos_joyY = 0x18;
            pos_FLAGS = 0x38;
            pos_FLAGS2 = 0x39;
            pos_winPosX = 0x28;
            pos_winPosY = 0x2C;
            pos_color = 0x1A;
            pos_display = 0x1D;
            pos_fps = 0x1E;
            pos_inputLat = 0x23;
            pos_bgmVol = 0x20;
            pos_seVol = 0x21;
            pos_bgmMode = 0x1B;
            pos_seEnabled = 0x1C;
        }

        public override bool validate(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x00] != 0x03) return false;
            if (b[0x02] != 0x11) return false;
            foreach (int i in new int[] { 0x01, 0x03, 0x05, 0x07, 0x09, 0x0B, 0x15 })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }

    }
}
