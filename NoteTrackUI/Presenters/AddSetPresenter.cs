using FileHandlerLibrary.FileHandlers;
using ModelLibrary.Models.Set;
using ModelLibrary.Models.Topic;
using NoteTrackUI.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTrackUI.Presenters
{
    public class AddSetPresenter : Control, IAddSetPresenter
    {
        MainView _mainView;
        AddSetView _addSetView;
        SetModel _setModel;
        TopicModel _topicModel;
        AddSet _addSet;

        public delegate void SubmitClicked(object sender, EventArgs e);
        public event SubmitClicked OnSubmitClicked;
        
        public AddSetPresenter(MainView mainView, SetModel setModel, TopicModel topicModel)
        {
            _addSetView = new AddSetView();
            _addSet = new AddSet();
            _addSetView.SubmitBtn.Click += SubmitBtn_Click;
            _mainView = mainView;
            _setModel = setModel;
            _topicModel = topicModel;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //SubmitNewSet();
            if (SubmitNewSet() == true)
            {
                OnSubmitClicked(this, new EventArgs());
            }
        }

        public void ShowAddSetView()
        {
            _mainView.MainPanel.Controls.Add(_addSetView.AddSetViewOuterPanel, 1, 0);
        }

        public bool SubmitNewSet()
        {
            string illegalChars = "^[\\w ]+$";
            Regex regex = new Regex(illegalChars);
            if (_addSetView.TitleInput.Text == "" || _addSetView.TopicInput.Text == "")
            {
                MessageBox.Show("Please fill out all fields!");
                return false;
            }
            else if (!regex.IsMatch(_addSetView.TitleInput.Text) || !regex.IsMatch(_addSetView.TopicInput.Text))
            {
                MessageBox.Show("Only Letters and numbers are allowed in set name");
                return false;
            }
            else
            {
                
                _setModel.SetTopics.Clear();
                _setModel.SetID = 0; //TODO: Check if setting SetID to 0 will have negative consequences later
                _setModel.SetName = _addSetView.TitleInput.Text;
                if (GetBySetName.GetByName(_setModel.SetName) != null) //TODO: check if getbyname not broken
                {
                    MessageBox.Show("Such a set already exists, choose a different name");
                    return false;
                }
                else
                {
                    _topicModel.TopicName = _addSetView.TopicInput.Text;
                    byte[] topicFileInByte = Encoding.ASCII.GetBytes(_addSetView.TopicContentInput.Rtf); //Get content of TopicInput as bytes
                
                    //_topicModel.TopicFile = ms;
                    _topicModel.TopicFile = topicFileInByte;
                    _setModel.SetTopics.Add(_topicModel);
                
                    _mainView.btnAdd.Visible = true;
                    _mainView.btnDel.Visible = true;
                    _mainView.btnRename.Visible = true;

                    //Add rtf file to topic
                    _addSet.Add(_setModel, _topicModel, _topicModel.TopicFile); //Create set

                    //TODO: Reset setlistbox
                    
                    return true;
                }
            }

        }
    }
}
