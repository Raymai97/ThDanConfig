

namespace ThDanConfig
{
    class th10 : thCom_th10
    {
        public th10()
        {
            validLen = 52;
            pos_joyX = 0x16;
            pos_joyY = 0x18;
            pos_FLAGS = 0x30;
            pos_FLAGS2 = 0x31;
            pos_color = 0x1A;
            pos_display = 0x1D;
            pos_fps = 0x1E;
            pos_bgmVol = 0x20;
            pos_seVol = 0x21;
            pos_bgmMode = 0x1B;
            pos_seEnabled = 0x1C;
        }

        public override bool isDataValid(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0x00] != 0x03) return false;
            if (b[0x02] != 0x10) return false;
            foreach (int i in new int[] { 0x01, 0x03, 0x05, 0x07, 0x09, 0x0B, 0x15 })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }

        // th10-only FLAGS
        public bool showFaithMeterNearPlayer
        {
            get
            {
                return hasFlag(FLAGS.SHOW_FAITH_METER_NEAR_PLAYER, data[pos_FLAGS]);
            }
            set
            {
                setFlag(FLAGS.SHOW_FAITH_METER_NEAR_PLAYER, !value, ref data[pos_FLAGS]);
            }
        }



    }
}
