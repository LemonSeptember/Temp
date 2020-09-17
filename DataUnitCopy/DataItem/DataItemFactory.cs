using System;

namespace DataUnitCopy
{
    public class DataItemFactory
    {
        public static IDataItem GetStepPulseItem()
        {
            return new StepPulseItem();
        }

        public static IDataItem GetDoubleB1ChanItem(short _d, short _h)
        {
            return new B1ChanALeftItem(_d, _h);
        }

        public static IDataItem GetDateItem(DateTime _date)
        {
            return new DateItem((short)_date.Year, (short)_date.Month, (short)_date.Day);
        }

        public static IDataItem GetDateItem(short _year, short _month, short _date)
        {
            return new DateItem(_year, _month, _date);
        }
    }
}
