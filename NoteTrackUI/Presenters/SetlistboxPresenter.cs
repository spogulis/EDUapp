using ModelLibrary.Models.Set;
using NoteTrackUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace NoteTrackUI.Presenters
{
    public class SetlistboxPresenter : Form, ISetlistboxPresenter
    {
        public SetListboxView _setlistboxView;
        SetModel _setModel;
        List<SetModel> _setModels;
        MainView _mainView;

        public delegate void SetDoubleClicked(object sender, MouseEventArgs e);
        public event SetDoubleClicked OnSetDoubleClicked;
        
        
        public SetlistboxPresenter(SetModel setModel, List<SetModel> setModels, MainView mainView, SetListboxView setListboxView)
        {
            _setModel = setModel;
            _setModels = setModels;
            _mainView = mainView;
            _setlistboxView = setListboxView;

            GenerateSetlist(); //Populate HomeSetlist with set names
            ShowSetlist();
            _setlistboxView.Load += OnSetListViewLoadedEventRaised;
            _setlistboxView.HomeSetList.MouseClick += HomeSetList_MouseClick;
            _setlistboxView.HomeSetList.MouseDoubleClick += HomeSetList_MouseDoubleClick;
        }

        private void HomeSetList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (OnSetDoubleClicked != null)
            {
                OnSetDoubleClicked(this, e);
            }
        }

        private void HomeSetList_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (_setlistboxView.HomeSetList.SelectedIndex != -1)
            {
                SimpleListViewVisualItem item = _setlistboxView.HomeSetList.ElementTree.GetElementAtPoint(e.Location) as SimpleListViewVisualItem;
                
                if (item == null)
                {
                    SetModel.SelectedSet = null;
                    _setlistboxView.HomeSetList.SelectedIndex = -1;
                }
                else
                {
                    SetModel.SelectedSet =  item.Text;
                }
                
            } else
            {
                SetModel.SelectedSet = null;
            }
        }

        public void ShowSetlist()
        {
            _mainView.MainPanel.Controls.Add(_setlistboxView.Controls[0], 1, 0);
        }

        public void CloseSetlistbox()
        {
            _mainView.MainPanel.Controls.Clear();
            _setlistboxView.Close();
            this.Dispose();
        }

        public void GenerateSetlist()
        {
            _setlistboxView.HomeSetList.Items.Clear();
            foreach(SetModel set in _setModels)
            {
                _setModel.SetID = set.SetID;
                _setModel.SetName = set.SetName;
                _setModel.SetTopics = set.SetTopics;
                _setlistboxView.HomeSetList.Items.Add(_setModel.SetName);
            }
        }

        public void OnSetListViewLoadedEventRaised(object sender, EventArgs e)
        {
            
            _setlistboxView.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
