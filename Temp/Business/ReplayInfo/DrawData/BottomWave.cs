namespace Temp
{
    public class BottomWave
    {
        /// <summary>
        /// Initializes a new instance of the BottomWave class.
        /// </summary>
        public BottomWave(int index, short value, short channel, xfActCode actionCode)
        {
            Index = index;
            Value = value;
            Channel = channel;
            ActionCode = actionCode;
        }

        /// <summary>
        /// bot tom[0]
        /// </summary>
        public int Index { get; private set; }

        /// <summary>
        /// bottom[1]
        /// </summary>
        public short Value { get; private set; }

        /// <summary>
        /// bottom[2]
        /// </summary>
        public short Channel { get; private set; }

        /// <summary>
        /// bottom[3]
        /// </summary>
        public xfActCode ActionCode { get; private set; }
    }
}