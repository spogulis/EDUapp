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
        public static string _exeFolder = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        private static string _setFolder = System.IO.Path.Combine(_exeFolder, "Sets");
        private string _SelectedSet;
        ToolTip tooltip = new ToolTip();
        VlcControl vlcControl1 = new VlcControl();

        private void MainView_Load(object sender, EventArgs e)
        {
            //Initialize video control
            vlcControl1.BeginInit();
            vlcControl1.VlcLibDirectory = new DirectoryInfo(_exeFolder + @"\libvlc\win-x86");
            vlcControl1.VlcMediaplayerOptions = new[] { "-vv"};
            vlcControl1.EndInit();
            VideoShowPanelControl.Controls.Add(vlcControl1);
            vlcControl1.Dock = DockStyle.Fill;
            this.vlcControl1.Click += new EventHandler(vlcControl1_Click);
            
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
                TitleBtnDelete.Visible = false;
                TitleBtnAdd.Visible = false;
                HomePanelContainer.Visible = false;
                AddPanelContainer.Visible = false;
                SetPanel.Visible = true;
                OverviewPanel.Visible = true;
                VideoShowPanel.Visible = false;
                TitleBtnBack.Visible = true;
                
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
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

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

        //Clicking ADD btn
        private void HomeBtnAdd_Click(object sender, EventArgs e)
        {
            HomePanelContainer.Visible = false;
            ViewTitle.Text = "Add new set";
            AddPanelContainer.Visible = true;
            TitleBtnBack.Visible = true;
        }

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
        
        //Populate topic list
        private void PopulateTopicList()
        {
            Set set = new Set(_SelectedSet); //Create object
            set.ClearTopics();
            SetLeftTopicList.Items.Clear();

            set.PopulateTopics(_exeFolder); //Populate selected set object "topics" data
            
            if (SetPanel.Visible == true)
            {
                //Populate TopicList with real data
                foreach (var topic in set.Topics)
                {
                    SetLeftTopicList.Items.Add(topic);
                }
            }
        }
        
        //Singleclicking Topic list item
        private void SetLeftTopicList_MouseClick(object sender, EventArgs e)
        {

            try
            {
                var selectedItem = SetLeftTopicList.SelectedItem; //TODO: optimize this code block
                CreateFolderStructure(_SelectedSet, selectedItem.ToString());
                ClearThumbnails(_SelectedSet, selectedItem.ToString());
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
            try
            {
                TopicName.Text = SetLeftTopicList.Items[SetLeftTopicList.SelectedIndex].ToString();
            }
            catch (System.ArgumentOutOfRangeException)
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

        /// <summary>
        /// 
        /// VIDEO METHODS
        /// 
        /// </summary>
        /// 

        private void CreateVideoThumbnails()
        {
            if (SetLeftTopicList.SelectedItem != null)
            {
                Topic topic = new Topic(SetLeftTopicList.SelectedItem.ToString()); // Create obj with set selected topic name
                topic.Title = _SelectedSet; // Assign Set name
                topic.PopulateTopics(_exeFolder); // Populate Set topics list
                var path = Path.Combine(_setFolder, topic.Title);
                path = Path.Combine(path, topic.SelectedTopic);
                path = Path.Combine(path, "Videos");
                if (Directory.GetFiles(path).Length == 0)
                {
                    var stockpic = new Bitmap(FormsApp.Properties.Resources.video_placeholder);
                    VideoPanel.BackgroundImage = stockpic;
                    VideoPanel.BackgroundImageLayout = ImageLayout.Center;
                    //Create tooltip
                    
                    tooltip.SetToolTip(VideoPanel, "Click here to add videos to current topic");
                }
                else
                {
                    VideoPanel.BackgroundImage = null;
                    //Remove tooltip
                    tooltip.SetToolTip(VideoPanel, "");
                    ClearThumbnails(_SelectedSet, topic.SelectedTopic); //CLEAR thumbnails

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
                    foreach (string image in Directory.GetFiles(GetPath(_SelectedSet, topic.SelectedTopic) + @"\Videos" + @"\Thumbnails"))
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
                        VideoPanel.Controls.Add(picture);
                        picture.Name = picIndex.ToString();
                        picture.Click += delegate
                        {
                            ShowVideo(Int32.Parse(picture.Name)); //show video
                        };
                        picIndex++;
                    }
                    
                    //Delete old images
                    foreach (string image in oldImages)
                    {
                        File.Delete(image);
                    }
                }
            }
        }

        private void ShowVideo(int index)
        {
            
            vlcControl1.SetMedia(new FileInfo(Topic.VideoList[index]));
            VideoShowPanel.Visible = true;
            OverviewPanel.Visible = false;
            vlcControl1.Play();
        }

        

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

        //
        // PATH METHODS
        //

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

        private void vlcControl1_Click(object sender, EventArgs e)
        {
            //if (vlcControl1.IsPlaying == true)
            //{
            //    vlcControl1.Pause();
            //} else if (vlcControl1.IsPlaying == true)
            //{
            //    MessageBox.Show(vlcControl1.IsPlaying.ToString());
                
            //    vlcControl1.Play();
            //}
            //vlcControl1.Play();
            
            
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (vlcControl1.IsPlaying == true)
            {
                vlcControl1.Pause();
            } else if (vlcControl1.IsPlaying == false)
            {
                vlcControl1.Play();
            }
        }

        private void TitleBtnDelete_Click(object sender, EventArgs e)
        {
            var path = Path.Combine(_setFolder, HomeSetList.SelectedItem.ToString());
            Directory.Delete(path, true);
            
            //HomeSetList.Items.Clear();
            ReadSetnamesFromDirectories();
        }
    }
}
