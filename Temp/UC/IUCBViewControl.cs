namespace Temp.UC
{
    public interface IUCBViewControl
    {
        int PlayPointer { get; set; }

        void OpenFile(string fileName);

        void Play();

        void Stop();

        void MoveNext();

        void MovePrevious();

        void UpdateBView();

        xfBViewMode ViewMode { get; set; }

        int RefreshRate { get; set; }

        int PlaySpeed { get; set; }

        int MaxPointer { get; }

        BViewDrawSettingParameter DrawSettingParameter { get; set; }
    }
}