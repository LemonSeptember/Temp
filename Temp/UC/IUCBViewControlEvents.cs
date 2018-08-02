using System;

namespace Temp.UC
{
    public interface IUCBViewControlEvents
    {
        event OnPeplayInfoUpdateedDelegate OnReplayInfoUpdated;
    }



    public delegate void OnPeplayInfoUpdateedDelegate(object sender, ReplayInfoUpdatedEventArgs e);

    public class ReplayInfoUpdatedEventArgs : EventArgs
    {

        /// <summary>
        /// Initializes a new instance of the ReplayInfoUpdatedEventArgs class.
        /// </summary>
        public ReplayInfoUpdatedEventArgs(ReplayInfo replayInfo)
        {
            ReplayInfo = replayInfo;
        }

        public ReplayInfo ReplayInfo { get; private set; }
    }
}    