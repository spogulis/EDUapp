namespace NoteTrackUI.Views
{
    partial class VideoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar1 = new Telerik.WinControls.UI.RadTrackBar();
            this.labelSeek = new Telerik.WinControls.UI.RadLabel();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.videoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSeek)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPanel
            // 
            this.videoPanel.BackColor = System.Drawing.Color.Black;
            this.videoPanel.ColumnCount = 1;
            this.videoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.videoPanel.Controls.Add(this.trackBar1, 0, 2);
            this.videoPanel.Controls.Add(this.labelSeek, 0, 1);
            this.videoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPanel.Location = new System.Drawing.Point(0, 0);
            this.videoPanel.Margin = new System.Windows.Forms.Padding(0);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.RowCount = 3;
            this.videoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.videoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.videoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.videoPanel.Size = new System.Drawing.Size(800, 450);
            this.videoPanel.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(3, 428);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(794, 19);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.ThemeName = "VisualStudio2012Dark";
            // 
            // labelSeek
            // 
            this.labelSeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSeek.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelSeek.Location = new System.Drawing.Point(372, 403);
            this.labelSeek.Name = "labelSeek";
            this.labelSeek.Size = new System.Drawing.Size(55, 18);
            this.labelSeek.TabIndex = 2;
            this.labelSeek.Text = "0:00";
            // 
            // VideoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoPanel);
            this.Name = "VideoView";
            this.Text = "VideoView";
            this.videoPanel.ResumeLayout(false);
            this.videoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelSeek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        public Telerik.WinControls.UI.RadTrackBar trackBar1;
        public Telerik.WinControls.UI.RadLabel labelSeek;
        public System.Windows.Forms.TableLayoutPanel videoPanel;
    }
}