using System;

namespace NoteTrackUI.Presenters
{
    public interface ISetlistboxPresenter
    {
        void CloseSetlistbox();
        void GenerateSetlist();
        void OnSetListViewLoadedEventRaised(object sender, EventArgs e);
        void ShowSetlist();
    }
}