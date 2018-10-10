using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileHandlerLibrary.FileHandlers;
using NoteTrackUI.Views;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;

namespace NoteTrackUI.Presenters
{
    public class VideoViewPresenter : Form
    {
        VideoView _videoView;
        MainView _mainView;
        FileInfo _file;
        VlcControl _vlcControl1;
        private int a = 0; 
        private int c = 0;
        public delegate void UpdateControlsDelegate();

        public VideoViewPresenter(MainView mainView, FileInfo file)
        {
            _mainView = mainView;
            _videoView = new VideoView();
            _vlcControl1 = new VlcControl();
            _videoView.FormClosed += OnFormClose;
            //Initialize video control
            _vlcControl1.BeginInit();
            _vlcControl1.VlcLibDirectory = new DirectoryInfo(Base._exeFolder + @"\libvlc\win-x86");
            _vlcControl1.VlcMediaplayerOptions = new[] { "-vv"};
            _vlcControl1.EndInit(); //End of init
            
            
            
            _vlcControl1.Click += vlcControl1_Click;
            _videoView.trackBar1.Scroll += trackBar1_Scroll;
            _vlcControl1.Playing += new EventHandler<VlcMediaPlayerPlayingEventArgs>(SetProgressMax);
            _vlcControl1.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(vlcControl1_PositionChanged);
            _file = file;
        }


        private void OnFormClose(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void ShowVideoView()
        {
            _mainView.MainPanel.Controls[0].Dispose();
            _mainView.MainPanel.Controls.Add(_videoView.videoPanel, 1, 0);
            ShowVideo(_file);
        }


        private void ShowVideo(FileInfo file)
        {
            _vlcControl1.SetMedia(file);
            _videoView.videoPanel.Controls.Add(_vlcControl1, 0, 0); //Add Vlc control to videoPanel
            _vlcControl1.Dock = DockStyle.Fill;

            _vlcControl1.Play();
            _vlcControl1.Video.IsMouseInputEnabled = false;
            _vlcControl1.Video.IsKeyInputEnabled = false;
            _vlcControl1.MouseClick += new MouseEventHandler(vlcControl1_Click);
        }
        
        
        public void CloseVideoView()
        {
            _videoView.Dispose();
        }


        private void vlcControl1_Click(object sender, EventArgs e)
        {
            if (_vlcControl1.IsPlaying == true)
            {
                _vlcControl1.Pause();
            } else if (_vlcControl1.IsPlaying == false)
            {
                _vlcControl1.Play();
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _vlcControl1.VlcMediaPlayer.Time = (int)_videoView.trackBar1.Value * 1000;
            int b = (int)_vlcControl1.VlcMediaPlayer.Time / 1000;
            int d = b / 60;
            b = b - d* 60;
            _videoView.labelSeek.Text = d+":"+b + "/"+ c + ":" + a; //min : sec / 
            //The Time value is milisecond, you have divide 1000 for be second.
        }


        //Invoke update controls on video position change
        private void vlcControl1_PositionChanged(object sender, Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs e)
        {
            InvokeUpdateControls();
        }


        //Update current video time label (delegate)
        public void InvokeUpdateControls()
        {
            if (_vlcControl1.InvokeRequired)
            {
                _vlcControl1.Invoke(new UpdateControlsDelegate(currentTrackTime));
            }
            else
            {
                currentTrackTime();
            }
        }


        //Update current video time label 
        private void currentTrackTime()
        {
            int b = (int)_vlcControl1.VlcMediaPlayer.Time / 1000;
            int d = b / 60;
            b = b - d * 60;
            _videoView.labelSeek.Text = d + ":" + b + "/" + c + ":" + a; //min : sec /
            _videoView.trackBar1.Value = (int)_vlcControl1.VlcMediaPlayer.Time / 1000;
        }


        //Fire event when video starts
        private void SetProgressMax(object sender, VlcMediaPlayerPlayingEventArgs e)
        {
            if (_vlcControl1.InvokeRequired) {
                _vlcControl1.Invoke(new Action(() =>
                {
                    _videoView.trackBar1.Value = _videoView.trackBar1.Minimum;
                    var vlc = (VlcControl)sender;
                    _videoView.trackBar1.Maximum = (int)vlc.Length / 1000;
                    a = (int)vlc.Length / 1000; // Length (s)
                        c = a / 60; // Length (m)
                        a = a % 60; // Length (s)
                        _videoView.labelSeek.Text = 0 + "/" + c + ":" + a;
                }));


            } 
            
        }
    }
}
