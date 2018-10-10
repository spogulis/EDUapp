using NoteTrackUI.Factory;
using NoteTrackUI.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using ModelLibrary.Models.Set;
using System.Windows.Forms;
using FileHandlerLibrary.FileHandlers;
using ModelLibrary.Models.Topic;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace NoteTrackUI.Presenters
{
    public class SetViewPresenter : Form
    {
        MainView _mainView;
        SetView _setView;
        SetModel _setModel;

        //Images
        Image boldInverted = Properties.Resources.text_bold_inverted;
        Image bold = Properties.Resources.text_bold;
        Image underline = Properties.Resources.underline;
        Image underlineInverted = Properties.Resources.underline_inverted;
        Image italic = Properties.Resources.italic;
        Image italicInverted = Properties.Resources.italic_inverted;

        public SetViewPresenter(MainView mainView, SetView setView)
        {
            _setView = setView;
            _mainView = mainView;
            _mainView.btnDel.Click += BtnDelDeleteTopic_Click;
            _setView.btnCode.Click += BtnCode_Click;
            _setView.btnBold.Click += BtnBold_Click;
            _setView.btnUnderline.Click += BtnUnderline_Click;
            _setView.btnItalic.Click += BtnItalic_Click;
            _setView.MainContent.SelectionChanged += MainContent_SelectionChanged;
            _setView.MainContent.KeyDown += MainContent_KeyDown;
            _setView.btnClear.Click += BtnClear_Click;
            _setView.InputNewTopicName.TextChanged += InputNewTopicName_TextChanged;
            _setView.btnNewOldTopicSave.Click += OnBtnNewOldTopicSave_Click;
            _setModel = StaticFactory.GetSelectedSetModel(SetModel.SelectedSet);
            _setView.TopicListbox.MouseClick += TopicListbox_MouseClicked;
            _setView.btnAddVideos.MouseClick += BtnAddVideos_MouseClick;
            _setView.TopicListbox.SelectedIndex = 0;
            PopulateTopicListbox();
            LoadDefaultSet();
        }
        

        /// <summary>
        /// Load set data
        /// </summary>
        private void LoadDefaultSet()
        {
            SetModel.SelectedTopic = _setModel.SetTopics[0].TopicName;
            //_setView.MainContent.LoadFile(Encoding.ASCII.GetString(_setModel.SetTopics[0].TopicFile), RichTextBoxStreamType.RichText);
            _setView.MainContent.LoadFile(Encoding.ASCII.GetString(_setModel.SetTopics[_setView.TopicListbox.SelectedIndex].TopicFile));
            _setView.InputNewTopicName.Text = SetModel.SelectedTopic;
            AddThumbsToPanel();
        }
        

        public void ShowSetView()
        {
            _mainView.MainPanel.Controls.Add(_setView.SetViewMainPanel, 1, 0);
        }


        /// <summary>
        /// Main content helper buttons
        /// </summary>
        
        //Toggle underline
        private void BtnUnderline_Click(object sender, EventArgs e)
        {
            if (_setView.MainContent.SelectionFont.Style.ToString().Contains("Underline"))
            {
                _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style & ~FontStyle.Underline);
                _setView.btnUnderline.Image = underline;
            }
            else
            {
                _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style | FontStyle.Underline);
                _setView.btnUnderline.Image = underlineInverted;
            }   
        }


        //Toggle italic
        private void BtnItalic_Click(object sender, EventArgs e)
        {
            if (_setView.MainContent.SelectionFont.Style.ToString().Contains("Italic"))
            {
                _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style & ~FontStyle.Italic);
                _setView.btnItalic.Image = italic;
            }
            else
            {
                _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style | FontStyle.Italic);
                _setView.btnItalic.Image = italicInverted;
            }  
        }
        

        //Toggle bold
        private void BtnBold_Click(object sender, EventArgs e)
        {
            if (_setView.MainContent.SelectionFont.Style.ToString().Contains("Bold"))
            {
                _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style & ~FontStyle.Bold);
                _setView.btnBold.Image = bold;
            }
            else
            {
                _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style | FontStyle.Bold);
                _setView.btnBold.Image = boldInverted;
            }     
        }


        //Toggle code tag
        private void BtnCode_Click(object sender, EventArgs e)
        {
            if (_setView.btnCode.ForeColor == Color.FromArgb(51, 153, 255)) {
                _setView.btnCode.ForeColor = Color.Black;
                _setView.btnCode.BackColor = Color.White;
            }
            else
            {
                _setView.btnCode.ForeColor = Color.FromArgb(51, 153, 255);
                _setView.btnCode.BackColor = Color.Black;
            }

            CTag("private ", Color.Red, 0);
            CTag("public ", Color.Red, 0);
            CTag("static ", Color.Red, 0);
            CTag("abstract ", Color.Red, 0);
            CTag("virtual ", Color.Red, 0);
            CTag("override ", Color.Red, 0);
            CTag("class ", Color.Blue, 0);
            CTag("void ", Color.Blue, 0);
            CTag("new ", Color.Red, 0);
            CTag("if", Color.Blue, 0);
            CTag("else", Color.Blue, 0);
            CTag("try", Color.Blue, 0);
            CTag("catch", Color.Blue, 0);
            CTag("except", Color.Blue, 0);
            CTag("this", Color.Blue, 0);
            CTag("=", Color.Blue, 0);
            CTag("+", Color.Blue, 0);
            CTag("-", Color.Blue, 0);
            CTag("*", Color.Blue, 0);
            CTag("/", Color.Blue, 0);
            CTag("%", Color.Blue, 0);
            CTag("{", Color.Blue, 0);
            CTag("}", Color.Blue, 0);
            CTag("(", Color.Blue, 0);
            CTag(")", Color.Blue, 0);
            CTag("[", Color.Blue, 0);
            CTag("]", Color.Blue, 0);
            CTag(">", Color.Blue, 0);
            CTag("<", Color.Blue, 0);
            CTag(@"//", Color.Red, 0);
            CTag(";", Color.Red, 0);
            CTag(":", Color.Red, 0);            
            CTag("float ", Color.Blue, 0);
            CTag("int ", Color.Blue, 0);
            CTag("string ", Color.Blue, 0);
            CTag("double ", Color.Blue, 0);
            CTag("return ", Color.Blue, 0);
            CTag("EventArgs", Color.Red, 0);
            CTag("EventHandler", Color.Red, 0);
        }
        

        //Code tag helper
        private void CTag(string word, Color color, int startIndex)
        {
            if (_setView.MainContent.Text.Contains(word))
            {
                int index = -1;
                int selectStart = _setView.MainContent.SelectionStart;
                while ((index = _setView.MainContent.Text.IndexOf(word, (index + 1))) != -1)
                {
                _setView.MainContent.Select((index + startIndex), word.Length);
                if (_setView.MainContent.SelectionColor == color)
                    {
                        _setView.MainContent.SelectionColor = Color.Black;
                    } else
                    {
                        _setView.MainContent.SelectionColor = color;
                    }
                }
            }
        }


        /// <summary>
        /// Automatically set correct helper btn (ctrl + b, u, i) based on MainContent_SelectionChanged
        /// </summary>
        private void MainContent_SelectionChanged(object sender, EventArgs e)
        {
            //Toggle bold if selected text == bold
            if (_setView.MainContent.SelectionFont.Style.ToString().Contains("Bold"))
            {
                _setView.btnBold.Image = boldInverted;
            }
            else
            {
                _setView.btnBold.Image = bold;
            }

            //Toggle underline if selected text == underline
            if (_setView.MainContent.SelectionFont.Style.ToString().Contains("Underline"))
            {
                _setView.btnUnderline.Image = underlineInverted;
            }
            else
            {
                _setView.btnUnderline.Image = underline;
            }

            //Toggle italic if selected text == italic
            if (_setView.MainContent.SelectionFont.Style.ToString().Contains("Italic"))
            {
                _setView.btnItalic.Image = italicInverted;
            }
            else
            {
                _setView.btnItalic.Image = italic;
            }
        }


        /// <summary>
        /// Keyboard shortcut handler (ctrl + b/u/i)
        /// </summary>
        private void MainContent_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //Bold toggle
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                if (_setView.MainContent.SelectionFont.Style.ToString().Contains("Bold"))
                {
                    _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style & ~FontStyle.Bold);
                    _setView.btnBold.Image = bold;
                }
                else
                {
                    _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style | FontStyle.Bold);
                    _setView.btnBold.Image = boldInverted;
                }    
            }


            //Underline toggle
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                if (_setView.MainContent.SelectionFont.Style.ToString().Contains("Underline"))
                {
                    _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style & ~FontStyle.Underline);
                    _setView.btnUnderline.Image = underline;
                }
                else
                {
                    _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style | FontStyle.Underline);
                    _setView.btnUnderline.Image = underlineInverted;
                } 
            }


            //Italic toggle & suppress
            if (e.Control == true && e.KeyCode == Keys.I)
            {
                if (_setView.MainContent.SelectionFont.Style.ToString().Contains("Italic"))
                {
                    _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style & ~FontStyle.Italic);
                    _setView.btnItalic.Image = italic;
                }
                else
                {
                    _setView.MainContent.SelectionFont = new Font(_setView.MainContent.SelectionFont, _setView.MainContent.SelectionFont.Style | FontStyle.Italic);
                    _setView.btnItalic.Image = italicInverted;
                }

                e.SuppressKeyPress = true;
            }


            //TODO: Bind CTRL + S to "Save new topic to file"
            //if (e.Control == true && e.KeyCode == Keys.S)
            //{
            //    WriteTopicToFile();
            //    PopulateTopicList();
            //}
        }


        private void BtnClear_Click(object sender, EventArgs e)
        {
            _setView.MainContent.SelectAll();
            _setView.MainContent.SelectionColor = Color.Black;
        }


        //
        //
        // Old/New topic management
        //
        //

        /// <summary>
        /// Changes LabelNewTopicName.Text based on InputNewTopicName text change
        /// </summary>

        private void InputNewTopicName_TextChanged(object sender, EventArgs e)
        {
            if (_setView.InputNewTopicName.Text == SetModel.SelectedTopic)
            {
                _setView.LabelNewTopicName.Text = "Save existing topic";
            }
            else
            {
                _setView.LabelNewTopicName.Text = "Save as a new topic";
            }
        }


        private void OnBtnNewOldTopicSave_Click(object sender, EventArgs e)
        {
            //MB if empty or save topic file
            if (_setView.InputNewTopicName.Text == "")
            {
                MessageBox.Show("Topic name cannot be empty");
            }
            else
            {
                
                CreateTopic();
                PopulateTopicListbox();
                _setView.LabelNewTopicName.Text = "Save existing topic";

            }
        }


        private void CreateTopicFolderStructure(string setname, string topicname)
        {
            //Get directory path, create folder "Sets" and create Set path
            string path = System.IO.Path.Combine(Base._setsFolder, setname);
            
            //Create directory for Set
            Directory.CreateDirectory(path); 
            
            //Create directory for Topic
            path = System.IO.Path.Combine(path, topicname);
            System.IO.Directory.CreateDirectory(path); //Create topicname dir

            var videopath = Path.Combine(path, "Videos");
            Directory.CreateDirectory(videopath); //Create videos dir

            var thumbpath = Path.Combine(videopath, "Thumbnails");
            Directory.CreateDirectory(thumbpath); //Create thumbnail dir
        }


        private void PopulateTopicListbox()
        {
            foreach (TopicModel topic in _setModel.SetTopics)
            {
                _setView.TopicListbox.Items.Add(topic.TopicName);
            }
        }

        /// <summary>
        /// Creates new topic folder, it's subdir's and <SetModel.SelectedTopic>.rtf
        /// </summary>
        private void CreateTopic()
        {
            string newTopicName = _setView.InputNewTopicName.Text;
            SetModel.SelectedTopic = newTopicName; //Update selectedTopic to newly created

            //Prep folders for the new topic
            CreateTopicFolderStructure(SetModel.SelectedSet, newTopicName);

            string path = SaveTopic.Save(SetModel.SelectedSet, _setView.InputNewTopicName.Text); //Save file
                
            //TODO: Implement "Update videoListView.Items ON _setView.BtnNewOldTopicSave.Click
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(_setView.MainContent.Rtf);
            }
            _setView.TopicListbox.Items.Clear();
            _setModel = StaticFactory.GetSelectedSetModel(SetModel.SelectedSet);
        }


        private void DeleteTopic(string topicName)
        {
            if (_setView.TopicListbox.SelectedIndex != -1)
            {
                string deleteTopicName = _setView.TopicListbox.SelectedItem.Text;
                string pathToDeletable = Path.Combine(Base._setsFolder, SetModel.SelectedSet);
                pathToDeletable = Path.Combine(pathToDeletable, topicName);
                Directory.Delete(pathToDeletable, true);
            }

        }


        private void TopicListbox_MouseClicked(object sender, MouseEventArgs e)
        {
            if (_setView.TopicListbox.SelectedIndex != -1)
            {
                SimpleListViewVisualItem item = _setView.TopicListbox.ElementTree.GetElementAtPoint(e.Location) as SimpleListViewVisualItem; 
                if (item != null)
                {
                    var visualItem = _setView.TopicListbox.ElementTree.GetElementAtPoint(e.Location) as BaseListViewVisualItem;
                    var dataItem = visualItem?.Data;
                    var index = _setView.TopicListbox?.Items?.IndexOf(dataItem);
                    _setView.TopicListbox.SelectedIndex = (int) index;
                    string SelectedItemText = item.Text;
                    SetModel.SelectedTopic = SelectedItemText;
                    _setView.InputNewTopicName.Text = SelectedItemText;
                    _setView.MainContent.LoadFile(Encoding.ASCII.GetString(_setModel.SetTopics[_setView.TopicListbox.SelectedIndex].TopicFile));
                    AddThumbsToPanel(); //Add thumbnails for the selected set
                }
            }
        }


        public void BtnDelDeleteTopic_Click(object sender, EventArgs e)
        {
            if (_setView.TopicListbox.SelectedItem != null)
            {
            DeleteTopic(_setView.TopicListbox.SelectedItem.Text);
            _setView.TopicListbox.Items.Clear();
            _setModel = GetBySetName.GetByName(SetModel.SelectedSet);
            PopulateTopicListbox();
            }
        }


        public void AddThumbsToPanel()
        {
            _setView.VideoThumbPanel.Controls.Clear();
            string[] thumbs = GenerateThumbnails.ReturnThumbnailList(Base._setsFolder, SetModel.SelectedSet, SetModel.SelectedTopic); //Get list of thumbnails that are in the folder.
            
            
            Point loc = new Point(0, 5);
            int i = 0;
            foreach (string thumb in thumbs)
            {
                PictureBox picture = new PictureBox();
                picture.Height = 146;
                picture.Width = 300;
                picture.SizeMode = PictureBoxSizeMode.Normal;
                picture.Image = new Bitmap(thumb);
                picture.Location = loc;
                _setView.VideoThumbPanel.Controls.Add(picture);
                loc.X += 310;
                picture.Name = i.ToString();
                picture.Click += delegate
                {
                    PlayVideo(Int32.Parse(picture.Name));
                };
                
                i++;
            }
        }

        private void BtnAddVideos_MouseClick(object sender, MouseEventArgs e)
        {
            string path = Path.Combine(Base._setsFolder, SetModel.SelectedSet, SetModel.SelectedTopic, "Videos");
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
        " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm";
            dialog.Multiselect = true;
            dialog.Title = "Add videos to selected topic";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                foreach(string f in dialog.FileNames)
                {
                    string newfile = Path.Combine(path, (Path.GetFileNameWithoutExtension(f) + f.Substring(f.Length - 4)));
                    if (!File.Exists(newfile))
                    {
                        File.Copy(f, newfile);
                    }

                    //Create thumbnail if it doesn't exist already
                    GenerateThumbnails.CreateSingleThumbnail(Base._setsFolder, SetModel.SelectedSet, SetModel.SelectedTopic, newfile);

                    //Add thumbs to panel
                    AddThumbsToPanel();
                }
            }
        }

        private void PlayVideo(int index)
        {
            string videoPath = Path.Combine(Base._setsFolder, SetModel.SelectedSet, SetModel.SelectedTopic, "Videos");
            string[] videos = Directory.GetFiles(videoPath);

            //Open on click
            FileInfo file = new FileInfo(videos[index]);
            VideoViewPresenter _vwp = StaticFactory.CreateVideoViewPresenter(_mainView, file);
            _vwp.ShowVideoView();
        }
    }
}
