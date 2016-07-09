

namespace ThDanConfig
{
    class th13 : th11
    {
        public th13()
        {
            // validLen is still 60
            // some pos are same with th11
            pos_joyX = 0x18;
            pos_joyY = 0x1A;
            pos_color = 0x1C;
            pos_display = 0x1F;
            pos_fps = 0x20;
            pos_inputLat = 0x25;
            pos_bgmVol = 0x22;
            pos_seVol = 0x23;
            pos_bgmMode = 0x1D;
            pos_seEnabled = 0x1E;
        }
        
        public override bool isDataValid(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x00] != 0x01) return false;
            if (b[0x02] != 0x13) return false;
            foreach (int i in new int[] { 0x01, 0x03, 0x05, 0x07, 0x09, 0x0B, 0x17 })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }



    }
}
