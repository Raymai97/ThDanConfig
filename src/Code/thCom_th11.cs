using System;
using System.IO;

namespace MaiSoft
{
    // Common stuff since TH11
    abstract class thCom_th11 : thCom_th10
    {
        protected byte pos_inputLat { get; set; }
        protected byte pos_winPosX { get; set; }
        protected byte pos_winPosY { get; set; }

        public new DISP2 display
        {
            get
            {
                switch (data[pos_display])
                {
                    case 0: return DISP2.FULL;
                    case 1: return DISP2.LOW_WIN;
                    case 2: return DISP2.MED_WIN;
                    case 3: return DISP2.HIGH_WIN;
                    default: throw new InvalidDataException();
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case DISP2.FULL: val = 0; break;
                    case DISP2.LOW_WIN: val = 1; break;
                    case DISP2.MED_WIN: val = 2; break;
                    case DISP2.HIGH_WIN: val = 3; break;
                    default: return;
                }
                data[pos_display] = val;
            }
        }
        public INPUT_LAT inputLatency
        {
            get
            {
                switch (data[pos_inputLat])
                {
                    case 0: return INPUT_LAT.STABLE;
                    case 1: return INPUT_LAT.NORMAL;
                    case 2: return INPUT_LAT.AUTO;
                    case 3: return INPUT_LAT.FAST;
                    default: throw new InvalidDataException();
                }
            }
            set
            {
                byte val;
                switch (value)
                {
                    case INPUT_LAT.STABLE: val = 0; break;
                    case INPUT_LAT.NORMAL: val = 1; break;
                    case INPUT_LAT.AUTO: val = 2; break;
                    case INPUT_LAT.FAST: val = 3; break;
                    default: return;
                }
                data[pos_inputLat] = val;
            }
        }
        public int winPosX
        {
            get
            {
                int val;
                byte[] b = new byte[4];
                b[0] = data[pos_winPosX];
                b[1] = data[pos_winPosX + 1];
                b[2] = data[pos_winPosX + 2];
                b[3] = data[pos_winPosX + 3];
                val = BitConverter.ToInt32(b, 0);
                makeSureWithin(ref val, short.MinValue, short.MaxValue);
                // By default, it is 0x00000080, which is WindowsDefaultLocation
                // but we have to give a value anyway. :/
                if ((b[0] + b[1] + b[2]) == 0 & b[3] == 0x80) val = 0;
                return val;
            }
            set
            {
                makeSureWithin(ref value, short.MinValue, short.MaxValue);
                byte[] b = BitConverter.GetBytes(value);
                data[pos_winPosX] = b[0];
                data[pos_winPosX + 1] = b[1];
                data[pos_winPosX + 2] = b[2];
                data[pos_winPosX + 3] = b[3];
            }
        }

        public int winPosY
        {
            get
            {
                int val;
                byte[] b = new byte[4];
                b[0] = data[pos_winPosY];
                b[1] = data[pos_winPosY + 1];
                b[2] = data[pos_winPosY + 2];
                b[3] = data[pos_winPosY + 3];
                val = BitConverter.ToInt32(b, 0);
                makeSureWithin(ref val, short.MinValue, short.MaxValue);
                // By default, it is 0x00000080, which is WindowsDefaultLocation
                // but we have to give a value anyway. :/
                if ((b[0] + b[1] + b[2]) == 0 & b[3] == 0x80) val = 0;
                return val;
            }
            set
            {
                makeSureWithin(ref value, short.MinValue, short.MaxValue);
                byte[] b = BitConverter.GetBytes(value);
                data[pos_winPosY] = b[0];
                data[pos_winPosY + 1] = b[1];
                data[pos_winPosY + 2] = b[2];
                data[pos_winPosY + 3] = b[3];
            }
        }



    }
}
