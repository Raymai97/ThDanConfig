using System.IO;

namespace MaiSoft
{

    abstract class thCom_oldGen : thCom
    {
        protected byte pos_defDifficulty { get; set; }
        protected byte pos_initialLife { get; set; }
        protected byte pos_effectQuality { get; set; }
        protected int min_initialLife { get; set; }
        protected int max_initialLife { get; set; }

        public DIFFICULTY defDifficulty
        {
            get
            {
                switch (data[pos_defDifficulty])
                {
                    case 0: return DIFFICULTY.EASY;
                    case 1: return DIFFICULTY.NORMAL;
                    case 2: return DIFFICULTY.HARD;
                    case 3: return DIFFICULTY.LUNATIC;
                    default: throw new InvalidByteData("defDifficulty");
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case DIFFICULTY.EASY: val = 0; break;
                    case DIFFICULTY.NORMAL: val = 1; break;
                    case DIFFICULTY.HARD: val = 2; break;
                    case DIFFICULTY.LUNATIC: val = 3; break;
                    default: return;
                }
                data[pos_defDifficulty] = val;
            }
        }
        public EFFECT effectQuality
        {
            get
            {
                switch (data[0x24])
                {
                    case 0: return EFFECT.LOW;
                    case 1: return EFFECT.MED;
                    case 2: return EFFECT.HIGH;
                    default: throw new InvalidByteData("effectQuality");
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case EFFECT.LOW: val = 0; break;
                    case EFFECT.MED: val = 1; break;
                    case EFFECT.HIGH: val = 2; break;
                    default: return;
                }
                data[0x24] = val;
            }
        }
        public int initialLife
        {
            // min InitialLife always has 0 as the byte data
            get
            {
                byte val = data[pos_initialLife];
                int maxVal = (max_initialLife - min_initialLife);
                if (val > maxVal) throw new InvalidByteData("initialLife");
                return val + min_initialLife;
            }
            set
            {
                makeSureWithin(ref value, min_initialLife, max_initialLife);
                data[pos_initialLife] = (byte)(value - min_initialLife);
            }
        }

    }

    // th06, 07, 08
    abstract class thCom_th06_07_08 : thCom_oldGen
    {

        // OLDFLAGS
        public bool clearBackbufferOnRefresh
        {
            get
            {
                return hasFlag(OLDFLAGS.CLEAR_BACKBUFFER_ON_REFRESH, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS.CLEAR_BACKBUFFER_ON_REFRESH, !value, ref data[pos_FLAGS]);
            }
        } // obsolete th07/08?
        public bool force60frames
        {
            get
            {
                return hasFlag(OLDFLAGS.FORCE_60_FRAMES, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS.FORCE_60_FRAMES, !value, ref data[pos_FLAGS]);
            }
        } // obsolete th07/08?
        public bool noDepthTest
        {
            get
            {
                return hasFlag(OLDFLAGS.NO_DEPTH_TEST, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS.NO_DEPTH_TEST, !value, ref data[pos_FLAGS]);
            }
        }
        public bool noVertexBuffer
        {
            get
            {
                return hasFlag(OLDFLAGS.NO_VERTEX_BUFFER, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS.NO_VERTEX_BUFFER, !value, ref data[pos_FLAGS]);
            }
        } // obsolete th07/08?
        public bool showMinGraphics
        {
            get
            {
                return hasFlag(OLDFLAGS.SHOW_MIN_GRAPHICS, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS.SHOW_MIN_GRAPHICS, !value, ref data[pos_FLAGS]);
            }
        } // obsolete th07/08?
        public bool use16bitTextures
        {
            get
            {
                return hasFlag(OLDFLAGS.USE_16BIT_TEXTURES, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS.USE_16BIT_TEXTURES, !value, ref data[pos_FLAGS]);
            }
        }
        public bool useLesserGouraudShading
        {
            get
            {
                return hasFlag(OLDFLAGS.USE_LESSER_GOURAUD_SHADING, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS.USE_LESSER_GOURAUD_SHADING, !value, ref data[pos_FLAGS]);
            }
        }

        // OLDFLAGS2
        public bool noColorCompoToTextures
        {
            get
            {
                return hasFlag(OLDFLAGS2.NO_COLOR_COMPO_TO_TEXTURES, data[pos_FLAGS2]);
            }
            set
            {
                setFlag(OLDFLAGS2.NO_COLOR_COMPO_TO_TEXTURES, !value, ref data[pos_FLAGS2]);
            }
        }
        public bool noDirectInputForJoypad
        {
            get
            {
                return hasFlag(OLDFLAGS2.NO_DIRECTINPUT_FOR_JOYPAD, data[pos_FLAGS2]);
            }
            set
            {
                setFlag(OLDFLAGS2.NO_DIRECTINPUT_FOR_JOYPAD, !value, ref data[pos_FLAGS2]);
            }
        }
        public bool noFog
        {
            get
            {
                return hasFlag(OLDFLAGS2.NO_FOG, data[pos_FLAGS2]);
            }
            set
            {
                setFlag(OLDFLAGS2.NO_FOG, !value, ref data[pos_FLAGS2]);
            }
        }
        public bool useRefRasterizer
        {
            get
            {
                return hasFlag(OLDFLAGS2.USE_REF_RASTERIZER, data[pos_FLAGS2]);
            }
            set
            {
                setFlag(OLDFLAGS2.USE_REF_RASTERIZER, !value, ref data[pos_FLAGS2]);
            }
        }

    }

    // th07 and th08 only
    abstract class thCom_th07_th08 : thCom_th06_07_08
    {
        // Since pos of focusWhileShot and slowMode for TH07/TH08 are same,
        // I just use hardcoded value as pos instead.
        public bool focusWhileShot
        {
            get
            {
                byte val = data[0x26];
                if (val > 1) throw new InvalidByteData("focusWhileShot");
                return (val == 1);
            }
            set
            {
                data[0x26] = (byte)(value ? 1 : 0);
            }
        }
        public bool slowMode
        {
            get
            {
                byte val = data[0x25];
                if (val > 1) throw new InvalidByteData("slowMode");
                return (val == 1);
            }
            set
            {
                data[0x25] = (byte)(value ? 1 : 0);
            }
        }

        // new OLDFLAGS2 for TH07 and TH08
        public bool fullyRedrawOnRefresh
        {
            get
            {
                return hasFlag(OLDFLAGS2.FULLY_REDRAW_ON_REFRESH, data[pos_FLAGS2]);
            }
            set
            {
                setFlag(OLDFLAGS2.FULLY_REDRAW_ON_REFRESH, !value, ref data[pos_FLAGS2]);
            }
        }
        public bool loadBGMintoRAM
        {
            get
            {
                return hasFlag(OLDFLAGS2.LOAD_BGM_INTO_RAM, data[pos_FLAGS2]);
            }
            set
            {
                setFlag(OLDFLAGS2.LOAD_BGM_INTO_RAM, !value, ref data[pos_FLAGS2]);
            }
        }
        public bool noVerticalSync
        {
            get
            {
                return hasFlag(OLDFLAGS2.NO_VERTICAL_SYNC, data[pos_FLAGS2]);
            }
            set
            {
                setFlag(OLDFLAGS2.NO_VERTICAL_SYNC, !value, ref data[pos_FLAGS2]);
            }
        }
    }


    // th09 and th095 only
    abstract class thCom_th09_th095 : thCom_oldGen
    {
        // OLDFLAGS3
        public bool loadBGMintoRAM
        {
            get
            {
                return hasFlag(OLDFLAGS3.LOAD_BGM_INTO_RAM, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS3.LOAD_BGM_INTO_RAM, !value, ref data[pos_FLAGS]);
            }
        }
        public bool noDirectInputForJoypad
        {
            get
            {
                return hasFlag(OLDFLAGS3.NO_DIRECTINPUT_FOR_JOYPAD, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS3.NO_DIRECTINPUT_FOR_JOYPAD, !value, ref data[pos_FLAGS]);
            }
        }
        public bool noFog
        {
            get
            {
                return hasFlag(OLDFLAGS3.NO_FOG, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS3.NO_FOG, !value, ref data[pos_FLAGS]);
            }
        }
        public bool noVerticalSync
        {
            get
            {
                return hasFlag(OLDFLAGS3.NO_VERTICAL_SYNC, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS3.NO_VERTICAL_SYNC, !value, ref data[pos_FLAGS]);
            }
        }
        public bool use16bitTextures
        {
            get
            {
                return hasFlag(OLDFLAGS3.USE_16BIT_TEXTURES, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS3.USE_16BIT_TEXTURES, !value, ref data[pos_FLAGS]);
            }
        }
        public bool useRefRasterizer
        {
            get
            {
                return hasFlag(OLDFLAGS3.USE_REF_RASTERIZER, data[pos_FLAGS]);
            }
            set
            {
                setFlag(OLDFLAGS3.USE_REF_RASTERIZER, !value, ref data[pos_FLAGS]);
            }
        }

    }

}
