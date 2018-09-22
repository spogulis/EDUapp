using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SetLibrary;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using Vlc.DotNet.Forms;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Vlc.DotNet.Core;

namespace FormsApp
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            ToolTip tooltip = new ToolTip();
            VlcControl vlcControl1 = new VlcControl();
            }

        public static string _exeFolder = Path.GetDirectoryName(Application.ExecutablePath);
        private static string _setFolder = Path.Combine(_exeFolder, "Sets");
        private string _SelectedSet;
        ToolTip tooltip = new ToolTip();
        VlcControl vlcControl1 = new VlcControl();
        public int a = 0; 
        public int c = 0;
        public delegate void UpdateControlsDelegate();
        //On form load
        private void MainView_Load(object sender, EventArgs e)
        {
            //Initialize video control
            vlcControl1.BeginInit();
            vlcControl1.VlcLibDirectory = new DirectoryInfo(_exeFolder + @"\libvlc\win-x86");
            vlcControl1.VlcMediaplayerOptions = new[] { "-vv"};
            vlcControl1.EndInit();
            VideoShowPanelControl.Controls.Add(vlcControl1);
            vlcControl1.Dock = DockStyle.Fill;
            vlcControl1.Video.IsMouseInputEnabled = false;
            vlcControl1.Video.IsKeyInputEnabled = false;
            
            this.trackBar1.Scroll += new EventHandler(trackBar1_Scroll);
            vlcControl1.Playing += new System.EventHandler<VlcMediaPlayerPlayingEventArgs>(SetProgresMax);
            this.vlcControl1.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.vlcControl1_PositionChanged);
            
            //Create Set folder
            CreateFolderStructure();

            //Read file at startup
            ReadSetnamesFromDirectories();

            this.HomeSetList.DoubleClick += new System.EventHandler(this.HomeSetList_MouseDoubleClick);
            this.SetLeftTopicList.Click += new System.EventHandler(this.SetLeftTopicList_MouseClick);
            this.SetRightMainContent.KeyDown += new KeyEventHandler(this.SetRightMainContent_KeyDown);
            
            //Color cell borders TODO: Check why can't paint all borders for nested containers
            //SetLeftLayoutControl.CellPaint += SetLeftLayoutControl_CellPaint;
        }
        
        /// <summary>
        /// 
        /// GENERAL
        /// 
        /// </summary>
        
        //Get safe filename
        public string GetSafeFilename(string filename)
        {

            return string.Join("", filename.Split(Path.GetInvalidFileNameChars()));

        }

        //Folder structure - "Sets" folder
        public void CreateFolderStructure()
        {
            //Get directory path, create folder "Sets" and create Set path
            string path = System.IO.Path.Combine(_exeFolder, "Sets");
            System.IO.Directory.CreateDirectory(path);
        }

        //Folder structure for a new set (+first topic file)
        public void CreateFolderStructure(string setname, string topicname)
        {
            //Get directory path, create folder "Sets" and create Set path
            string path = System.IO.Path.Combine(_setFolder, GetSafeFilename(setname));
            
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
        
        /// <summary>
        /// 
        /// TITLE METHODS
        /// 
        /// </summary>

        //Clicking BACK btn
        private void TitleBtnBack_Click(object sender, EventArgs e)
        {
            if (SetPanel.Visible == true && VideoShowPanel.Visible == true)
            {
                VideoShowPanel.Visible = false;
                OverviewPanel.Visible = true;
                vlcControl1.Stop();
            }
            
            else if (SetPanel.Visible == true)
            {
                SetPanel.Visible = false;
                TitleBtnBack.Visible = false;
                HomePanelContainer.Visible = true;
                TitleBtnAdd.Visible = true;
                TitleBtnDelete.Visible = true;
                ViewTitle.Text = "List of sets";
                SetList.SetNames.Clear();
                SetLeftTopicList.Items.Clear();
                VideoPanel.Controls.Clear();
            } 
            else if (AddPanelContainer.Visible == true)
            {
                AddPanelContainer.Visible = false;
                HomePanelContainer.Visible = true;
                ViewTitle.Text = "List of sets";
            }
            else if (HomePanelContainer.Visible == true)
            {
                TitleBtnBack.Visible = false;
            }
        }

        /// <summary>
        /// 
        /// HOME VIEW
        /// 
        /// </summary>
        
        //Populate Set names list
        private void ReadSetnamesFromDirectories()
        {
            //Null existing item list
            HomeSetList.Items.Clear();
            SetList.SetNames.Clear();
            

            //Remove full path from SET dir names and add sets to list
            foreach (var name in Directory.GetDirectories(_setFolder))
            {
                SetList.AddSetNames(name.Remove(0, name.LastIndexOf('\\') + 1));
            }
                                    
            //Populate SetList with real data
            foreach (var set in SetList.SetNames)
            {
                HomeSetList.Items.Add(set);
            }
        }
        
        //Doubleclicking HOME SET LIST ITEM
        private void HomeSetList_MouseDoubleClick(object sender, EventArgs e)
        {
            try
            {
                _SelectedSet = HomeSetList.SelectedItem.ToString(); //Set selected set
                ViewTitle.Text = _SelectedSet; //Change page title
                
                //Show/hide controls
                TitleBtnDelete.Visible = false;
                TitleBtnAdd.Visible = false;
                TitleBtnBack.Visible = true;
                AddPanelContainer.Visible = false;
                SetPanel.Visible = true;
                OverviewPanel.Visible = true;
                VideoShowPanel.Visible = false;

                //Create set object
                Set set = new Set(_SelectedSet);
                set.PopulateTopics(_exeFolder);
                
                //Redraw topic list
                PopulateTopicList();
                
                //Set selected topic to 0
                SetLeftTopicList.SelectedItem = SetLeftTopicList.Items[0];

                //Change topicname field contents
                TopicName.Text = SetLeftTopicList.Items[0].ToString(); //Fill topic name field
                var path = Path.Combine(_setFolder, set.Title);
                path = Path.Combine(path, set.Topics[0]);
                var filename = path + @"\" + set.Topics[0] + ".rtf";

                //Read topic file contents
                using (StreamReader sr = new StreamReader(filename))
                {
                    SetRightMainContent.Rtf = sr.ReadToEnd();
                }

                
                //Generate thumbnails
                CreateVideoThumbnails();

                

                HomePanelContainer.Visible = false;
                
                
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }
        
       
        //Clicking ADD btn
        private void HomeBtnAdd_Click(object sender, EventArgs e)
        {
            HomePanelContainer.Visible = false;
            ViewTitle.Text = "Add new set";
            AddPanelContainer.Visible = true;
            TitleBtnBack.Visible = true;
        }

        /// <summary>
        /// 
        /// ADD NEW MENU METHODS
        /// 
        /// </summary>
        
        //Create set file
        private void CreateSet(string setname, string topicname)
        {
            //File path
            string path = Path.Combine(_setFolder, setname);
            path = Path.Combine(path, topicname);
            path = Path.Combine(path, topicname);
            path += ".rtf";

            //Create and write to file
            
            if (System.IO.File.Exists(path))
            {
                MessageBox.Show("Such a set already exists, please choose a different name");
            }
            else
            {
#pragma warning disable CS0642 // Possible mistaken empty statement
                using (System.IO.File.Create(path));
#pragma warning restore CS0642 // Possible mistaken empty statement
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(SetNewContentInput.Rtf);
                }
            }
        }
        
        //Clicking Submit on Add page
        private void SetNewBtnSubmit_Click(object sender, EventArgs e)
        {
            if (SetNewTitleInput.Text.Contains(":"))
            {
                MessageBox.Show("Illegal character in Set title");
            } else if (SetNewTopicInput.Text.Contains(":"))
            {
                MessageBox.Show("Illegal character in topic name");
            }
            else if (SetNewTitleInput.Text != "" && SetNewTopicInput.Text != "")
            {
                string setname = SetNewTitleInput.Text;
                string topicname = SetNewTopicInput.Text;
                SetList.SetNames.Add(setname);

                //Create set folder structure
                CreateFolderStructure(setname, topicname);

                //Generate file
                CreateSet(setname, topicname);

                //Clear setlist
                SetList.SetNames.Clear();

                //Reload set list
                ReadSetnamesFromDirectories();

                //Clear fields
                SetNewTitleInput.Clear();
                SetNewContentInput.Clear();
            
                ViewTitle.Text = "List of sets";
                AddPanelContainer.Visible = false;
                HomePanelContainer.Visible = true;
            }
            else
            {
                MessageBox.Show("Please fill at least SET name and topic name");
            }
        }
        
        /// <summary>
        /// 
        /// SET METHODS
        /// 
        /// </summary>
        
        //Populate topic list
        private void PopulateTopicList()
        {
            Set set = new Set(_SelectedSet); //Create object
            set.ClearTopics();
            SetLeftTopicList.Items.Clear();

            set.PopulateTopics(_exeFolder); //Populate selected set object "topics" data
            
            
            //Populate TopicList with real data
            foreach (var topic in set.Topics)
            {
                SetLeftTopicList.Items.Add(topic);
            }
            
        }
        
        //Singleclicking Topic list item
        private void SetLeftTopicList_MouseClick(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = SetLeftTopicList.SelectedItem.ToString(); //TODO: optimize this code block
                TopicName.Text = selectedItem;
                CreateFolderStructure(_SelectedSet, selectedItem);
                ClearThumbnails(_SelectedSet, selectedItem);
                Topic.ClearVideoList();
                CreateVideoThumbnails(); //Create video thumbnails
                //Topic folder
                string exeFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                exeFolder += @"\Sets\";
                exeFolder += (ViewTitle.Text);
                exeFolder += @"\" + selectedItem + @"\" + selectedItem + ".Rtf";
                using (StreamReader sr = new StreamReader(exeFolder))
                {
                    SetRightMainContent.Rtf = sr.ReadToEnd();
                }
            }

            catch (System.ArgumentOutOfRangeException)
            {

            }
            catch (System.NullReferenceException)
            {

            }
        }
        
        //Clicking "Save note"
        private void NoteNameSave_Click(object sender, EventArgs e)
        {
            WriteTopicToFile();
            PopulateTopicList();
        }
        
        //Write topic to file
        private void WriteTopicToFile()
        {
            //Create folders Set name, Topic name, Videos, Thumbnails
            //var pathString = _exeFolder + (@"\Sets\" + ViewTitle.Text + @"\" + GetSafeFilename(TopicName.Text) + @"\");
            ////Create dir
            //Directory.CreateDirectory(pathString);
            //Set file name
           if (TopicName.Text == "")
            {
                MessageBox.Show("Topic name cannot be empty");
            }
            else
            {
                CreateFolderStructure(_SelectedSet, TopicName.Text);
                //var path = GetPath(_SelectedSet, TopicName.Text);
                var file = _setFolder + @"\" + _SelectedSet + @"\" + TopicName.Text + @"\" + TopicName.Text + ".rtf";
                //var file = GetPath(_SelectedSet, TopicName.Text) + @"\" + TopicName.Text + ".rtf";
                //ClearThumbnails(_SelectedSet, TopicName.Text);
                //Create and write to file
                if (System.IO.File.Exists(file))
                {
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        sw.Write(SetRightMainContent.Rtf);
                    }
                }
                else
                {
#pragma warning disable CS0642 // Possible mistaken empty statement
                    using(System.IO.File.Create(file));
#pragma warning restore CS0642 // Possible mistaken empty statement
                    using (StreamWriter sw = new StreamWriter(file))
                    {
                        sw.Write(SetRightMainContent.Rtf);
                    }
                }
            }
        }
                       
        /// <summary>
        /// 
        /// EDITOR METHODS
        /// 
        /// </summary>
       
        //Bold icon click
        private void BtnBold_Click(object sender, EventArgs e)
        {
            if (SetRightMainContent.SelectionFont.Style.ToString().Contains("Bold"))
            {
                SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style | FontStyle.Bold);
            }            
        }
        
        //Underline icon click
        private void BtnUnderline_Click(object sender, EventArgs e)
        {
            if (SetRightMainContent.SelectionFont.Style.ToString().Contains("Underline"))
            {
                SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {
                SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style | FontStyle.Underline);
            }   
        }
        
        //Italic icon click
        private void BtnItalic_Click(object sender, EventArgs e)
        {
            if (SetRightMainContent.SelectionFont.Style.ToString().Contains("Italic"))
            {
                SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {
                SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style | FontStyle.Italic);
            }   
        }
        
        //Shortcuts
        private void SetRightMainContent_KeyDown(object sender, KeyEventArgs e)
        {
            //Bold toggle
            if (e.Control == true && e.KeyCode == Keys.B)
            {
                if (SetRightMainContent.SelectionFont.Style.ToString().Contains("Bold"))
                {
                    SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style & ~FontStyle.Bold);
                }
                else
                {
                    SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style | FontStyle.Bold);
                }    
            }
            //Underline toggle
            if (e.Control == true && e.KeyCode == Keys.U)
            {
                if (SetRightMainContent.SelectionFont.Style.ToString().Contains("Underline"))
                {
                    SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style & ~FontStyle.Underline);
                }
                else
                {
                    SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style | FontStyle.Underline);
                } 
            }
            //Italic toggle & suppress
            if (e.Control == true && e.KeyCode == Keys.I)
            {
                if (SetRightMainContent.SelectionFont.Style.ToString().Contains("Italic"))
                {
                    SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style & ~FontStyle.Italic);
                }
                else
                {
                    SetRightMainContent.SelectionFont = new Font(SetRightMainContent.SelectionFont, SetRightMainContent.SelectionFont.Style | FontStyle.Italic);
                }

                e.SuppressKeyPress = true;
            }

            if (e.Control == true && e.KeyCode == Keys.S)
            {
                WriteTopicToFile();
                PopulateTopicList();
            }
        }

        //Code btn click
        private void BtnCS_Click(object sender, EventArgs e)
        {
            
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

        //C# tag
        private void CTag(string word, Color color, int startIndex)
        {
            if (SetRightMainContent.Text.Contains(word))
            {

                int index = -1;
                int selectStart = SetRightMainContent.SelectionStart;
                while ((index = SetRightMainContent.Text.IndexOf(word, (index + 1))) != -1)
                {
                SetRightMainContent.Select((index + startIndex), word.Length);
                if (SetRightMainContent.SelectionColor == color)
                    {
                        SetRightMainContent.SelectionColor = Color.Black;
                    } else
                    {
                        SetRightMainContent.SelectionColor = color;
                    }
                }
            }
        }

        //Reset topic content
        private void BtnReset_Click(object sender, EventArgs e)
        {
            SetRightMainContent.SelectAll();
            SetRightMainContent.SelectionColor = Color.Black;
        }

        //Delete topic
        private void BtnDelTopic_Click(object sender, EventArgs e)
        {
            var path = GetPath(_SelectedSet, TopicName.Text);
            Directory.Delete(path, true);
            PopulateTopicList();
            ResetTopic();
        }

         //Set selected topic to first
        private void ResetTopic()
        {
            //Create set object
            Set set = new Set(_SelectedSet);
            set.PopulateTopics(_exeFolder);
                
            //Redraw topic list
            PopulateTopicList();
                
            //Change topicname field contents
            TopicName.Text = SetLeftTopicList.Items[0].ToString(); //Fill topic name field
            var path = Path.Combine(_setFolder, set.Title);
            path = Path.Combine(path, set.Topics[0]);
            var filename = path + @"\" + set.Topics[0] + ".rtf";

            //Read topic file contents
            using (StreamReader sr = new StreamReader(filename))
            {
                SetRightMainContent.Rtf = sr.ReadToEnd();
            }
        }

        /// <summary>
        /// 
        /// VIDEO METHODS
        /// 
        /// </summary>
        /// 
        //Create video thumbnails
        private void CreateVideoThumbnails()
        {
            if (SetLeftTopicList.SelectedItem != null)
            {
                Topic topic = new Topic(SetLeftTopicList.SelectedItem.ToString()); // Create obj with set selected topic name
                topic.Title = _SelectedSet; // Assign Set name
                topic.PopulateTopics(_exeFolder); // Populate Set topics list
                var path = Path.Combine(_setFolder, topic.Title);
                path = Path.Combine(path, Topic.SelectedTopic);
                path = Path.Combine(path, "Videos");
                if (Directory.GetFiles(path).Length == 0)
                {
                    var stockpic = new Bitmap(FormsApp.Properties.Resources.video_placeholder);
                    VideoPanel.BackgroundImage = stockpic;
                    VideoPanel.BackgroundImageLayout = ImageLayout.Center;
                    //Create tooltip
                    tooltip.SetToolTip(VideoPanel, "Click here to add videos to current topic");
                    
                    //Add videos on click
                    VideoPanel.Click += delegate
                    {
                        AddNewVideos();
                    };

                    BtnAddVideo.Visible = false;
                }
                else
                {
                    VideoPanel.BackgroundImage = null;
                    //Remove tooltip
                    tooltip.SetToolTip(VideoPanel, "");
                    ClearThumbnails(_SelectedSet, Topic.SelectedTopic); //CLEAR thumbnails

                    var videos = Directory.GetFiles(path); //Get video folder contents
                    foreach (var video in videos)
                    {
                        topic.PopulateVideoList(video);
                    }
                    
                    var ffMpeg = new NReco.VideoConverter.FFMpegConverter(); //Create ffmpeg object
                    var i = 0;

                    //Save location
                    path = Path.Combine(path, "Thumbnails");

                    //Generate original size thumbnails
                    foreach (var video in videos)
                    {
                        ffMpeg.GetVideoThumbnail(video, path + @"\" + Topic.VideoList[i].Remove(0, Topic.VideoList[i].LastIndexOf('\\') + 1) + ".jpg", 5);
                        i++;
                    }

                    //Generate small thumbnails
                    List<string> oldImages = new List<string>();
                    var picIndex = 0;
                    foreach (string image in Directory.GetFiles(GetPath(_SelectedSet, Topic.SelectedTopic) + @"\Videos" + @"\Thumbnails"))
                    {
                        oldImages.Add(image);
                        Bitmap newImage = new Bitmap(260, 130);
                        using (Graphics gr = Graphics.FromImage(newImage))
                        {
                            gr.SmoothingMode = SmoothingMode.HighQuality;
                            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                            using (Image img = Image.FromFile(image))
                            {
                                gr.DrawImage(img, new Rectangle(0, 0, 260, 130));
                            }
                        }
                        var newfilename = image.Substring(0, image.Length - 8); //Generate filename without .mp4
                        newImage.Save(@newfilename + ".jpg", ImageFormat.Jpeg); //Save small thumbnail

                        //Add controls to VideoPanel
                        PictureBox picture = new PictureBox();
                        picture.Height = 146;
                        picture.Width = 300;
                        picture.SizeMode = PictureBoxSizeMode.Normal;
                        picture.Image = new Bitmap(newImage);
                        VideoPanel.Controls.Add(picture); //Add new pic to list of thumbs
                        picture.Name = picIndex.ToString();
                        picture.Click += delegate
                        {
                            ShowVideo(Int32.Parse(picture.Name)); //show video
                        };
                        picture.MouseHover += new EventHandler((s, e) => thumbGotFocus(s, e, picture, newfilename)); //Pass object as parameter
                        picIndex++;
                    }
                    
                    //Delete old images
                    foreach (string image in oldImages)
                    {
                        File.Delete(image);
                    }

                    //Show add button
                    BtnAddVideo.Visible = true;
                }
            }
        }

        private void thumbGotFocus(object sender, EventArgs e, Control picture, string newFilename)
        {
            ToolTip picTooltip = new ToolTip();
            picTooltip.SetToolTip(picture, newFilename.Remove(0, newFilename.LastIndexOf("\\") + 1));
        }

        private void ShowVideo(int index)
        {
            
            vlcControl1.SetMedia(new FileInfo(Topic.VideoList[index]));
            VideoShowPanel.Visible = true;
            OverviewPanel.Visible = false;
            vlcControl1.Play();
            vlcControl1.MouseClick += new MouseEventHandler(vlcControl1_Click);
            

            }

        //Fire event when video starts
        private void SetProgresMax(object sender, VlcMediaPlayerPlayingEventArgs e)
        {
            Invoke(new Action(() =>
            {
                trackBar1.Value = trackBar1.Minimum;
                var vlc = (VlcControl)sender;
                trackBar1.Maximum = (int)vlc.Length / 1000;
                a = (int)vlc.Length / 1000; // Length (s)
                c = a / 60; // Length (m)
                a = a % 60; // Length (s)
                label1.Text = 0 + "/" + c+":"+a; 
            }));
        } 
        
        //Clear thumbnails from thumb panel
        private void ClearThumbnails(string setname, string topicname)
        {
            //Reset videopanel controls
            VideoPanel.Controls.Clear();
            //Get Thumbnail path
            var path = GetPath(setname, topicname);
            path = Path.Combine(path, "Videos");
            path = Path.Combine(path, "Thumbnails");
            
            path = Path.GetDirectoryName(path);
            path = Path.Combine(path, "Thumbnails");
            
            //Delete files
            foreach (var file in Directory.GetFiles(path))
            {
                File.Delete(file);
            }
        }

        //Video click event
        private void vlcControl1_Click(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying == true)
            {
                vlcControl1.Pause();
            } else if (vlcControl1.IsPlaying == false)
            {
                vlcControl1.Play();
            }
        }
        
        //Trackbar scroll behavior
        private void trackBar1_Scroll(object sender, EventArgs e)
        {                        
            vlcControl1.VlcMediaPlayer.Time = trackBar1.Value * 1000;
            int b = (int)vlcControl1.VlcMediaPlayer.Time / 1000;
            int d = b / 60;
            b = b - d * 60;
            label1.Text = d+":"+b + "/"+ c + ":" + a; //min : sec / 
            //The Time value is milisecond, you have divide 1000 for be second.
        }

        //Update current video time label (delegate)
        public void InvokeUpdateControls()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateControlsDelegate(currentTrackTime));
            }
            else
            {
                currentTrackTime();
            }
        }

        //Update current video time label 
        private void currentTrackTime()
        {                        
            int b = (int)vlcControl1.VlcMediaPlayer.Time / 1000;
            int d = b / 60;
            b = b - d * 60;
            label1.Text = d+":"+b + "/"+ c + ":" + a; //min : sec /
            trackBar1.Value = b;
        }
                
        //Invoke update controls on video position change
        private void vlcControl1_PositionChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs e)
        {
            InvokeUpdateControls();
        }
        
        //Add videos dialog
        private void AddNewVideos()
        {
            string location = GetPath(_SelectedSet, TopicName.Text);
            location += @"\Videos";
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
                    string newfile = Path.Combine(location, f.Remove(0, f.LastIndexOf(@"\") + 1));
                    if (!File.Exists(newfile))
                    {
                        File.Copy(f, newfile);
                    }
                }
            }
        }

        //Add video btn click
        private void BtnAddVideo_Click(object sender, EventArgs e)
        {
            AddNewVideos();
        }
        /// <summary>
        /// 
        /// PATH METHODS
        /// 
        /// </summary>
        /// 

        private string GetPath(string setname)
        {
            return Path.Combine(_setFolder, setname);
        }

        private string GetPath(string setname, string topicname)
        {
            var path = Path.Combine(_setFolder, setname);
            path = Path.Combine(path, topicname);
            return path;
        }

        
        //Home del btn click
        private void TitleBtnDelete_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(_setFolder, HomeSetList.SelectedItem.ToString());
            Directory.Delete(path, true);
            ReadSetnamesFromDirectories();
        }

        //Draw topiclist item
        private void SetLeftTopicList_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush brush = Brushes.Red;
            e.Graphics.DrawString(SetLeftTopicList.Items[e.Index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
        }
    }
}
