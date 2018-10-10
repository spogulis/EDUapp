using FileHandlerLibrary.FileHandlers;
using ModelLibrary.Models.Set;
using ModelLibrary.Models.Topic;
using NoteTrackUI.Factory;
using NoteTrackUI.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NoteTrackUI.Presenters
{
    /// <summary>
    /// Creates _mainView, _setlistView (Listbox), _allSets (list of sets in /Sets) 
    /// </summary>
    public class MainViewPresenter : Form, IMainViewPresenter
    {
        MainView _mainView;
        SetlistboxPresenter _setlistboxPresenter;
        AddSetPresenter _addSetPresenter;
        SetViewPresenter _setViewPresenter;
        List<SetModel> _setModels;
        

        /// <summary>
        /// MainViewPresenter ctor. Creates MainView, SetListboxView and handles btnAdd, btnBack, btnDel, btnRename
        /// </summary>
        /// <param name="mainView"></param>
        /// 
        public MainViewPresenter(MainView mainView)
        {
            //Create Sets directory upon start
            Directory.CreateDirectory(Base._setsFolder);

            _mainView = mainView; //Load mainView from factory
            _mainView.FormClosed += OnFormClose; //Close app on clicking X
            
            _setModels = (List<SetModel>)GetAllSets.GetAll();
            SetListboxInit(); //Init setListbox on mainViewPresenter load

            //Event handlers
            _mainView.btnAdd.Click += AddSetPresenterInit;
            _mainView.btnBack.Click += OnBtnBackClickEventRaised;
            _mainView.btnDel.Click += OnBtnDelMainClickEventRaised;
            _mainView.btnRename.Click += OnRenameBtnClickEventRaised;
            
        }

        public void ShowMain()
        {
            _mainView.ShowMain();
        }
        

        private void OnFormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        /// <summary>
        /// Initialize SetListbox in MainView.MainPanel control list
        /// </summary>
        private void SetListboxInit()
        {
            if (_setlistboxPresenter != null)
            {
                _setlistboxPresenter.CloseSetlistbox(); //Dispose of setlistboxPresenter

            }
            _mainView.btnBack.Visible = false;
            _mainView.btnAdd.Visible = true;
            _mainView.btnDel.Visible = true;
            _setlistboxPresenter = (SetlistboxPresenter) StaticFactory.CreateSetlistboxPresenter(_mainView, _setModels); //Create and load setlist presenter

            //Set double click @ main view
            _setlistboxPresenter.OnSetDoubleClicked += OnOnSetDoubleClickedEventRaised;
        }


        /// <summary>
        /// Open 'AddSetView' within MainView when clicking on MainView's 'btnAdd' 
        /// </summary>
        private void AddSetPresenterInit(object sender, EventArgs e)
        {
            _addSetPresenter = (AddSetPresenter) StaticFactory.CreateAddSetPresenter(_mainView);
            _addSetPresenter.OnSubmitClicked += OnAddSetViewSubmitClicked;
            _mainView.btnBack.Visible = true;
            _mainView.btnAdd.Visible = false;
            _mainView.btnDel.Visible = false;
            _mainView.btnRename.Visible = false;
            _setlistboxPresenter.CloseSetlistbox(); //Close setlistbox
            _addSetPresenter.ShowAddSetView();
        }


        /// <summary>
        /// Reinitialize SetListbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddSetViewSubmitClicked(object sender, EventArgs e)
        {
            _setModels = StaticFactory.CreateAllSets(); //Renew all set list
            SetListboxInit();
        }


        /// <summary>
        /// BtnBack click logic
        /// </summary>
        public void OnBtnBackClickEventRaised(object sender, EventArgs e)
        {
            if (_mainView.MainPanel.Controls[0].Name == "AddSetViewOuterPanel")
            {
                _addSetPresenter.Dispose();
                _mainView.MainPanel.Controls.Clear();
                SetListboxInit(); //Init new SetListbox

                _mainView.btnBack.Visible = false;
                _mainView.btnAdd.Visible = true;
                _mainView.btnDel.Visible = true;
                _mainView.btnRename.Visible = true;
                
            }

            if (_mainView.MainPanel.Controls[0].Name == "SetViewMainPanel")
            {
                _setViewPresenter.Dispose();
                _mainView.MainPanel.Controls[0].Dispose();
                _mainView.MainPanel.Controls.Clear();
                SetListboxInit();

                _mainView.btnBack.Visible = false;
                _mainView.btnAdd.Visible = true;
                _mainView.btnDel.Visible = true;
                _mainView.btnDel.Click -= _setViewPresenter.BtnDelDeleteTopic_Click;
                _mainView.btnDel.Click += OnBtnDelMainClickEventRaised;
                _mainView.btnRename.Visible = true;
            }

            if (_mainView.MainPanel.Controls[0].Name == "videoPanel")
            {
                _mainView.MainPanel.Controls[0].Dispose();
                _mainView.MainPanel.Controls.Clear();
                _setViewPresenter = StaticFactory.CreateSetViewPresenter(_mainView); //New SetViewPresenter on DCLICK
                _setViewPresenter.ShowSetView();
            }
        }


        /// <summary>
        /// Deletes selected set folder physically and rerenders the set list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnBtnDelMainClickEventRaised(object sender, EventArgs e)
        {
            if (SetModel.SelectedSet != null)
            {
                DeleteSet.Delete(SetModel.SelectedSet);
                _setModels = StaticFactory.CreateAllSets(); //Renew all set list
                SetListboxInit();
            }
        }


        public void OnOnSetDoubleClickedEventRaised(object sender, EventArgs e)
        {
            if (SetModel.SelectedSet != null)
            {
                SetModel.SelectedSet = _setlistboxPresenter._setlistboxView.HomeSetList.SelectedItem.Text;
                _setlistboxPresenter.CloseSetlistbox();

                _setViewPresenter = StaticFactory.CreateSetViewPresenter(_mainView); //New SetViewPresenter on DCLICK
                _setViewPresenter.ShowSetView();
                _mainView.btnRename.Visible = false;
                _mainView.btnAdd.Visible = false;
                _mainView.btnDel.Click -= OnBtnDelMainClickEventRaised;
                _mainView.btnBack.Visible = true;
            }
    }


        /// <summary>
        /// Open set rename dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRenameBtnClickEventRaised(object sender, EventArgs e)
        {
            //TODO: Check why SetListbox doesn't update after renaming set
            if (SetModel.SelectedSet != null)
                {
                //Check for illegal characters
                SetNameUpdater _setNameUpdater = StaticFactory.CreateSetNameUpdater();

                _setNameUpdater.inputNewSetTitle.TextChanged += (o, a) =>
                {
                    string illegalChars = "^[\\w ]+$";
                    Regex regex = new Regex(illegalChars);
                
                    if (_setNameUpdater.inputNewSetTitle.Text == "" || !regex.IsMatch(_setNameUpdater.inputNewSetTitle.Text))
                    {
                        _setNameUpdater.SetNameUpdaterBtnSubmit.Visible = false;
                        _setNameUpdater.WarningLabel.Visible = true;
                    } 
                    else
                    {
                        _setNameUpdater.SetNameUpdaterBtnSubmit.Visible = true;
                        _setNameUpdater.WarningLabel.Visible = false;
                    }
                };
                

                //Create setNameUpdater window & 
                _setNameUpdater.StartPosition = FormStartPosition.Manual;
                _setNameUpdater.Location = new System.Drawing.Point(this._mainView.Location.X + 430, this._mainView.Location.Y + 400);

                DialogResult updateDialog = _setNameUpdater.ShowDialog(_mainView);


                //If submit btn = pressed, rename set folder name
                if (updateDialog == DialogResult.OK) {
                    if (_setlistboxPresenter._setlistboxView.HomeSetList.SelectedItem != null)
                    {
                    //Rename set folder name
                    UpdateSet.Update(_setlistboxPresenter._setlistboxView.HomeSetList.SelectedItem.Text,_setNameUpdater.inputNewSetTitle.Text);

                    //Rebuild setlistbox item list
                    _setlistboxPresenter._setlistboxView.HomeSetList.Items.Clear();
                    _setModels = StaticFactory.CreateAllSets();
                    SetListboxInit(); 
                    _setlistboxPresenter._setlistboxView.HomeSetList.SelectedIndex = 0;
                    }
                }
            }
        }
    }
}
