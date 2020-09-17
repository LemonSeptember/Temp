namespace DataUnitCopy
{
    public class StepPulseItem : DataItemBase
    {
        public override short ActCode => (short)0;
        public override short Length { get; }

        public StepPulseItem()
        {
            Length = 1;
        }
    }

    public class B1ChanALeftItem : DataItemBase
    {
        public override short ActCode => (short)-10700;
        public override short Length { get; }
        public short Depth { get; }
        public short High { get; }

        public B1ChanALeftItem(short _d, short _h)
        {
            Depth = _d;
            High = _h;
            Length = 3;
        }
    }

    public class DateItem : DataItemBase
    {
        public override short ActCode => (short)-10007;
        public override short Length { get; }
        public short Year;
        public short Month;
        public short Date;

        public DateItem(short _y, short _m, short _d)
        {
            Year = _y;
            Month = _m;
            Date = _d;
            Length = 4;
        }
    }
}
