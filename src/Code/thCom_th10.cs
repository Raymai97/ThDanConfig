

namespace MaiSoft
{
    // Common stuff since TH10
    abstract class thCom_th10 : thCom
    {

        // FLAGS and FLAGS2
        public bool askAtStartup
        {
            get
            {
                return hasFlag(FLAGS2.ASK_AT_STARTUP, data[pos_FLAGS2]);
            }
            set
            {
                setFlag(FLAGS2.ASK_AT_STARTUP, !value, ref data[pos_FLAGS2]);
            }
        }
        public bool focusWhileShot
        {
            get
            {
                return hasFlag(FLAGS2.FOCUS_WHILE_SHOT, data[pos_FLAGS2]);
            }
            set
            {
                setFlag(FLAGS2.FOCUS_WHILE_SHOT, !value, ref data[pos_FLAGS2]);
            }
        }
        public bool noDirectInputForJoypad
        {
            get
            {
                return hasFlag(FLAGS.NO_DIRECTINPUT_FOR_JOYPAD, data[pos_FLAGS]);
            }
            set
            {
                setFlag(FLAGS.NO_DIRECTINPUT_FOR_JOYPAD, !value, ref data[pos_FLAGS]);
            }
        }

    }
}
