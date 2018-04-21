using System.IO;

namespace MaiSoft
{
    class th09 : thCom_th09_th095
    {
        public th09()
        {
            validLen = 204;
            pos_joyX = 0xA8;
            pos_joyY = 0xAA;
            pos_FLAGS = 0xC8; // th09 has OLDFLAGS3 only
            pos_color = 0xAD;
            pos_display = 0xB1;
            pos_fps = 0xB2;
            pos_bgmVol = 0xBA;
            pos_seVol = 0xBB;
            pos_bgmMode = 0xAE;
            pos_defDifficulty = 0xB0;
            pos_initialLife = 0xAC;
            pos_effectQuality = 0xB3;
            pos_seEnabled = 0xAF;
            hasMIDI = true;
            min_initialLife = 3;
            max_initialLife = 5;
        }

        public override bool validate(byte[] b)
        {
            if (b.Length != validLen) return false;
            if (b[0xA4] != 0x03) return false;
            if (b[0xA6] != 0x09) return false;
            foreach (int i in new int[] {
                0x01, 0x03, 0x05, 0x07, 0x11,
                0x37, 0x39, 0x3B, 0x3D, 0x47, 0xA5, 0xA7
            })
            {
                if (b[i] != 0x00) return false;
            }
            return true;
        }

        public bool chargeViaShift_1P
        {
            get
            {
                return (data[0xB4] == 1);
            }
            set
            {
                data[0xB4] = (byte)(value ? 1 : 0);
            }
        }
        public bool chargeViaShift_2P
        {
            get
            {
                return (data[0xB5] == 1);
            }
            set
            {
                data[0xB5] = (byte)(value ? 1 : 0);
            }
        }
        public CONTROL_TYPE controlType_1P
        {
            get
            {
                switch (data[0xB7])
                {
                    case 0: return CONTROL_TYPE.GAMEPAD1;
                    case 1: return CONTROL_TYPE.GAMEPAD2;
                    case 2: return CONTROL_TYPE.KEYBOARD_ALL;
                    case 3: return CONTROL_TYPE.KEYBOARD_LEFT;
                    case 4: return CONTROL_TYPE.KEYBOARD_RIGHT;
                    default: throw new InvalidDataException();
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case CONTROL_TYPE.GAMEPAD1: val = 0; break;
                    case CONTROL_TYPE.GAMEPAD2: val = 1; break;
                    case CONTROL_TYPE.KEYBOARD_ALL: val = 2; break;
                    case CONTROL_TYPE.KEYBOARD_LEFT: val = 3; break;
                    case CONTROL_TYPE.KEYBOARD_RIGHT: val = 4; break;
                    default: return;
                }
                data[0xB7] = val;
            }
        }
        public CONTROL_TYPE controlType_2P
        {
            get
            {
                switch (data[0xB8])
                {
                    case 0: return CONTROL_TYPE.GAMEPAD1;
                    case 1: return CONTROL_TYPE.GAMEPAD2;
                    case 2: return CONTROL_TYPE.KEYBOARD_ALL;
                    case 3: return CONTROL_TYPE.KEYBOARD_LEFT;
                    case 4: return CONTROL_TYPE.KEYBOARD_RIGHT;
                    default: throw new InvalidDataException();
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case CONTROL_TYPE.GAMEPAD1: val = 0; break;
                    case CONTROL_TYPE.GAMEPAD2: val = 1; break;
                    case CONTROL_TYPE.KEYBOARD_ALL: val = 2; break;
                    case CONTROL_TYPE.KEYBOARD_LEFT: val = 3; break;
                    case CONTROL_TYPE.KEYBOARD_RIGHT: val = 4; break;
                    default: return;
                }
                data[0xB8] = val;
            }
        }

    }
}
