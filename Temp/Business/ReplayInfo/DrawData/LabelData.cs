using System;

namespace Temp
{
    public class LabelData
    {
        public LabelData(int index, Mile mile, short speed, DateTime time)
        {
            Index = index;
            Mile = mile;
            Speed = speed;
            Time = time;
        }

        public int Index { get; private set; }

        public Mile Mile { get; protected set; }

        public short Speed { get; protected set; }

        public DateTime Time { get; protected set; }

        public string DisplayString(xfMileUnit mileUnit, double speedConfig = 1.0)
        {
            return string.Format("{0} {1:0.0}kmph {2}", Mile.GetDisplayValue(mileUnit), Speed / 10.0 * speedConfig, Time.ToString("HH:mm:ss"));
        }
    }
}