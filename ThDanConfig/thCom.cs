using System;

namespace ThDanConfig
{
    abstract class thCom : IValidate
    {
        public abstract bool isDataValid(byte[] b);

        protected byte[] data;
        protected bool hasMIDI { get; set; }
        protected byte pos_FLAGS { get; set; }
        protected byte pos_FLAGS2 { get; set; }
        protected byte pos_color { get; set; }
        protected byte pos_display { get; set; }
        protected byte pos_fps { get; set; }
        protected byte pos_joyX { get; set; }
        protected byte pos_joyY { get; set; }
        protected byte pos_bgmMode { get; set; }
        protected byte pos_seEnabled { get; set; }
        protected byte pos_bgmVol { get; set; }
        protected byte pos_seVol { get; set; }
        protected int validLen { get; set; }

        /// <summary>
        /// Note: BGM.MIDI will become BGM.WAV unless 'hasMIDI = true'.
        /// </summary>
        public BGM bgmMode
        {
            get
            {
                switch (data[pos_bgmMode])
                {
                    case 0: return BGM.OFF;
                    case 1: return BGM.WAV;
                    case 2: return (hasMIDI ? BGM.WAV : BGM.MID);
                    default: throw new InvalidByteData("bgmMode");
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case BGM.OFF: val = 0; break;
                    case BGM.WAV: val = 1; break;
                    case BGM.MID: val = (byte)(hasMIDI ? 2 : 1); break;
                    default: return;
                }
                data[pos_bgmMode] = val;
            }
        }
        public int bgmVol
        {
            get
            {
                byte val = data[pos_bgmVol];
                if (val > 100) throw new InvalidByteData("bgmVol");
                return val;
            }
            set
            {
                makeSureWithin(ref value, 0, 100);
                data[pos_bgmVol] = (byte)value;
            }
        }
        public COLOR color
        {
            get
            {
                switch (data[pos_color])
                {
                    case 0: return COLOR._32BIT;
                    case 1: return COLOR._16BIT;
                    default: throw new InvalidByteData("color");
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case COLOR._32BIT: val = 0; break;
                    case COLOR._16BIT: val = 1; break;
                    default: return;
                }
                data[pos_color] = val;
            }
        }
        public DISP display
        {
            get
            {
                switch (data[pos_display])
                {
                    case 0: return DISP.FULL;
                    case 1: return DISP.WIN;
                    default: throw new InvalidByteData("display");
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case DISP.FULL: val = 0; break;
                    case DISP.WIN: val = 1; break;
                    default: return;
                }
                data[pos_display] = val;
            }
        }
        public FPS fps
        {
            get
            {
                switch (data[pos_fps])
                {
                    case 0: return FPS._60FPS;
                    case 1: return FPS._30FPS;
                    case 2: return FPS._20FPS;
                    default: throw new InvalidByteData("fps");
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case FPS._60FPS: val = 0; break;
                    case FPS._30FPS: val = 1; break;
                    case FPS._20FPS: val = 2; break;
                    default: return;
                }
                data[pos_fps] = val;
            }
        }
        public int joypadSen
        {
            get
            {
                int val = data[pos_joyX] + (data[pos_joyX + 1] * 256);
                if (val > 1000) throw new InvalidByteData("joypadSen");
                return val;
            }
            set
            {
                makeSureWithin(ref value, 0, 1000);
                data[pos_joyX] = (byte)(value % 256);
                data[pos_joyX + 1] = (byte)(value / 256);
                data[pos_joyY] = data[pos_joyX];
                data[pos_joyY + 1] = data[pos_joyX + 1];
            }
        }
        public bool seEnabled
        {
            get
            {
                byte val = data[pos_seEnabled];
                if (val > 1) throw new InvalidByteData("seEnabled");
                return (val == 1);
            }
            set
            {
                data[pos_seEnabled] = (byte)(value ? 1 : 0);
            }
        }
        public int seVol
        {
            get
            {
                byte val = data[pos_seVol];
                if (val > 100) throw new InvalidByteData("seVol");
                return val;
            }
            set
            {
                makeSureWithin(ref value, 0, 100);
                data[pos_seVol] = (byte)value;
            }
        }


        public void inData(byte[] b)
        {
            data = b;
        }

        public byte[] outData()
        {
            byte[] copy = new byte[validLen];
            Array.Copy(data, copy, validLen);
            return copy;
        }

        public enum DISP
        {
            FULL = 0,
            WIN = 1
        }

        public enum DISP2
        {
            FULL = 0,
            LOW_WIN = 1, // 640x480
            MED_WIN = 2, // 920x720
            HIGH_WIN = 3 // 1280x960
        }

        public enum DISP3
        {
            LOW = 0, // 640x480
            MED = 1, // 920x720
            HIGH = 2, // 1280x960
            LOW_WIN = 3,
            MED_WIN = 4,
            HIGH_WIN = 5
        }

        public enum FPS
        {
            _60FPS = 0,
            _30FPS = 1,
            _20FPS = 2
        }

        public enum INPUT_LAT
        {
            STABLE = 0,
            NORMAL = 1,
            AUTO = 2,
            FAST = 3
        }

        public enum COLOR
        {
            _32BIT = 0,
            _16BIT = 1
        }

        // legacy option before th10

        public enum BGM
        {
            OFF = 0,
            WAV = 1,
            MID = 2
        }

        public enum DIFFICULTY
        {
            EASY = 0,
            NORMAL = 1,
            HARD = 2,
            LUNATIC = 3
        }

        public enum EFFECT
        {
            LOW = 0,
            MED = 1,
            HIGH = 2
        }

        // only for 2P mode in TH09
        public enum CONTROL_TYPE
        {
            GAMEPAD1 = 0,
            GAMEPAD2 = 1,
            KEYBOARD_ALL = 2,
            KEYBOARD_LEFT = 3,
            KEYBOARD_RIGHT = 4
        }

        // gg : Not supported by...
        //
        // FORCE_60_FRAMES
        // If your monitor refresh rate is higher than 60Hz,
        // tick this to ensure the game runs well.

        [Flags()]
        protected enum OLDFLAGS //0x34 th06/07, 0x38 th08
        {
            DONT_USE_TRIALVER_MENU_COLOR = 0x01, //only th06
            NO_VERTEX_BUFFER = 0x02,
            USE_16BIT_TEXTURES = 0x04,
            CLEAR_BACKBUFFER_ON_REFRESH = 0x08,
            SHOW_MIN_GRAPHICS = 0x10,
            USE_LESSER_GOURAUD_SHADING = 0x20,
            NO_DEPTH_TEST = 0x40,
            FORCE_60_FRAMES = 0x80
        }

        // All OLDFLAGS2 are officially supported in th07&08.

        [Flags()]
        protected enum OLDFLAGS2 //0x35 th06/07, 0x39 th08
        {
            NO_COLOR_COMPO_TO_TEXTURES = 0x01,
            USE_REF_RASTERIZER = 0x02,
            NO_FOG = 0x04,
            NO_DIRECTINPUT_FOR_JOYPAD = 0x08,
            FULLY_REDRAW_ON_REFRESH = 0x10, //gg th06
            LOAD_BGM_INTO_RAM = 0x20, //gg th06
            NO_VERTICAL_SYNC = 0x40  //gg th06
        }

        [Flags()]
        protected enum OLDFLAGS3 //0xC8 th09, 0xC4 th095
        { 
            USE_16BIT_TEXTURES = 0x01,
            USE_REF_RASTERIZER = 0x02,
            NO_FOG = 0x04,
            NO_DIRECTINPUT_FOR_JOYPAD = 0x08,
            LOAD_BGM_INTO_RAM = 0x10,
            NO_VERTICAL_SYNC = 0x20
        }

        [Flags()]
        protected enum FLAGS
        {
            HAS_RUN_GAME_ONCE = 0x01, //th14++ only
            NO_DIRECTINPUT_FOR_JOYPAD = 0x08,
            SHOW_FAITH_METER_NEAR_PLAYER = 0x80 //th10 only
        }

        [Flags()]
        protected enum FLAGS2
        {
            ASK_AT_STARTUP = 0x01,
            FOCUS_WHILE_SHOT = 0x02
        }

        protected bool hasFlag(FLAGS flag, byte b)
        {
            return hasFlag((byte)flag, b);
        }
        protected bool hasFlag(FLAGS2 flag, byte b)
        {
            return hasFlag((byte)flag, b);
        }
        protected bool hasFlag(OLDFLAGS flag, byte b)
        {
            return hasFlag((byte)flag, b);
        }
        protected bool hasFlag(OLDFLAGS2 flag, byte b)
        {
            return hasFlag((byte)flag, b);
        }
        protected bool hasFlag(OLDFLAGS3 flag, byte b)
        {
            return hasFlag((byte)flag, b);
        }
        protected void setFlag(FLAGS flag, bool unset, ref byte b)
        {
            setFlag((byte)flag, unset, ref b);
        }
        protected void setFlag(FLAGS2 flag, bool unset, ref byte b)
        {
            setFlag((byte)flag, unset, ref b);
        }
        protected void setFlag(OLDFLAGS flag, bool unset, ref byte b)
        {
            setFlag((byte)flag, unset, ref b);
        }
        protected void setFlag(OLDFLAGS2 flag, bool unset, ref byte b)
        {
            setFlag((byte)flag, unset, ref b);
        }
        protected void setFlag(OLDFLAGS3 flag, bool unset, ref byte b)
        {
            setFlag((byte)flag, unset, ref b);
        }

        protected bool hasFlag(byte flag, byte b)
        {
            return ((b & flag) == flag);
        }

        protected void setFlag(byte flag, bool unset, ref byte b)
        {
            byte FLAG = (byte)flag;
            if (unset)
            {
                b = (byte)(b & ~FLAG);
            }
            else
            {
                b |= FLAG;
            }
        }

        protected void makeSureWithin(ref int value, int min, int max)
        {
            if (value < min) value = min;
            if (value > max) value = max;
        }

    }

    public class InvalidByteData : Exception
    {
        public InvalidByteData(string msg)
        {
            msg = "'" + msg + "' byte data is invalid!";
            throw new System.IO.InvalidDataException(msg);
        }
    }
}
