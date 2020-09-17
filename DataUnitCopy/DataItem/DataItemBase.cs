namespace DataUnitCopy
{
    public abstract class DataItemBase : IDataItem
    {
        public virtual short ActCode { get; }
        public virtual short Length { get; }
    }
}
