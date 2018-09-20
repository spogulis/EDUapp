using System;
using System.IO;
using System.Windows.Forms;

namespace FormsApp
{
    partial class MainView
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
            this.SetNewContentLabel = new System.Windows.Forms.Label();
            this.SetNewTitleLabel = new System.Windows.Forms.Label();
            this.BaseLayoutControl = new System.Windows.Forms.TableLayoutPanel();
            this.HomePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContentContainer = new System.Windows.Forms.Panel();
            this.SetPanel = new System.Windows.Forms.Panel();
            this.VideoShowPanel = new System.Windows.Forms.Panel();
            this.OverviewPanel = new System.Windows.Forms.Panel();
            this.SetLayoutControl = new System.Windows.Forms.TableLayoutPanel();
            this.SetLeftLayoutControl = new System.Windows.Forms.TableLayoutPanel();
            this.SetLeftPaneTitle = new System.Windows.Forms.Label();
            this.SetLeftTopicList = new System.Windows.Forms.ListBox();
            this.SetRightLayoutControl = new System.Windows.Forms.TableLayoutPanel();
            this.VideoPanelContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnBold = new System.Windows.Forms.PictureBox();
            this.BtnUnderline = new System.Windows.Forms.PictureBox();
            this.BtnItalic = new System.Windows.Forms.PictureBox();
            this.SetRightContentTitle = new System.Windows.Forms.Label();
            this.VideoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SetRightVideosTitle = new System.Windows.Forms.Label();
            this.SetRightNoteTools = new System.Windows.Forms.FlowLayoutPanel();
            this.TopicNameLabel = new System.Windows.Forms.Label();
            this.TopicName = new System.Windows.Forms.RichTextBox();
            this.NoteNameSave = new System.Windows.Forms.Button();
            this.SetRightMainContent = new System.Windows.Forms.RichTextBox();
            this.AddPanelContainer = new System.Windows.Forms.Panel();
            this.AddPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SetNewTitleInput = new System.Windows.Forms.RichTextBox();
            this.AddPanelBtnContainer = new System.Windows.Forms.TableLayoutPanel();
            this.SetNewBtnSubmit = new System.Windows.Forms.Button();
            this.SetNewContentInput = new System.Windows.Forms.RichTextBox();
            this.SetNewTopicLabel = new System.Windows.Forms.Label();
            this.SetNewTopicInput = new System.Windows.Forms.RichTextBox();
            this.HomePanelContainer = new System.Windows.Forms.Panel();
            this.HomeSetList = new System.Windows.Forms.ListBox();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.HeaderLayoutControl = new System.Windows.Forms.TableLayoutPanel();
            this.TitleBtnAdd = new System.Windows.Forms.Button();
            this.TitleBtnDelete = new System.Windows.Forms.Button();
            this.ViewTitle = new System.Windows.Forms.Label();
            this.TitleBtnBack = new System.Windows.Forms.Button();
            this.VideoShowPanelControl = new System.Windows.Forms.TableLayoutPanel();
            this.VideoShowControls = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.BaseLayoutControl.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.ContentContainer.SuspendLayout();
            this.SetPanel.SuspendLayout();
            this.VideoShowPanel.SuspendLayout();
            this.OverviewPanel.SuspendLayout();
            this.SetLayoutControl.SuspendLayout();
            this.SetLeftLayoutControl.SuspendLayout();
            this.SetRightLayoutControl.SuspendLayout();
            this.VideoPanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUnderline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnItalic)).BeginInit();
            this.SetRightNoteTools.SuspendLayout();
            this.AddPanelContainer.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.AddPanelBtnContainer.SuspendLayout();
            this.HomePanelContainer.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.HeaderLayoutControl.SuspendLayout();
            this.VideoShowPanelControl.SuspendLayout();
            this.VideoShowControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetNewContentLabel
            // 
            this.SetNewContentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SetNewContentLabel.AutoSize = true;
            this.SetNewContentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(108)))));
            this.SetNewContentLabel.Location = new System.Drawing.Point(41, 300);
            this.SetNewContentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SetNewContentLabel.Name = "SetNewContentLabel";
            this.SetNewContentLabel.Size = new System.Drawing.Size(67, 20);
            this.SetNewContentLabel.TabIndex = 12;
            this.SetNewContentLabel.Text = "Content";
            // 
            // SetNewTitleLabel
            // 
            this.SetNewTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SetNewTitleLabel.AutoSize = true;
            this.SetNewTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(108)))));
            this.SetNewTitleLabel.Location = new System.Drawing.Point(35, 45);
            this.SetNewTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SetNewTitleLabel.Name = "SetNewTitleLabel";
            this.SetNewTitleLabel.Size = new System.Drawing.Size(73, 20);
            this.SetNewTitleLabel.TabIndex = 11;
            this.SetNewTitleLabel.Text = "SET title";
            // 
            // BaseLayoutControl
            // 
            this.BaseLayoutControl.ColumnCount = 1;
            this.BaseLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1320F));
            this.BaseLayoutControl.Controls.Add(this.HomePanel, 0, 1);
            this.BaseLayoutControl.Controls.Add(this.TitlePanel, 0, 0);
            this.BaseLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseLayoutControl.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.BaseLayoutControl.Location = new System.Drawing.Point(15, 15);
            this.BaseLayoutControl.Name = "BaseLayoutControl";
            this.BaseLayoutControl.RowCount = 2;
            this.BaseLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.BaseLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseLayoutControl.Size = new System.Drawing.Size(1320, 699);
            this.BaseLayoutControl.TabIndex = 15;
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(108)))));
            this.HomePanel.ColumnCount = 3;
            this.HomePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.098373F));
            this.HomePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.90163F));
            this.HomePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.HomePanel.Controls.Add(this.ContentContainer, 1, 1);
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(3, 53);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.RowCount = 2;
            this.HomePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.19685F));
            this.HomePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.80315F));
            this.HomePanel.Size = new System.Drawing.Size(1314, 643);
            this.HomePanel.TabIndex = 16;
            // 
            // ContentContainer
            // 
            this.ContentContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.ContentContainer.Controls.Add(this.SetPanel);
            this.ContentContainer.Controls.Add(this.AddPanelContainer);
            this.ContentContainer.Controls.Add(this.HomePanelContainer);
            this.ContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentContainer.Location = new System.Drawing.Point(41, 36);
            this.ContentContainer.Name = "ContentContainer";
            this.ContentContainer.Size = new System.Drawing.Size(1203, 604);
            this.ContentContainer.TabIndex = 15;
            // 
            // SetPanel
            // 
            this.SetPanel.Controls.Add(this.VideoShowPanel);
            this.SetPanel.Controls.Add(this.OverviewPanel);
            this.SetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetPanel.Location = new System.Drawing.Point(0, 0);
            this.SetPanel.Name = "SetPanel";
            this.SetPanel.Size = new System.Drawing.Size(1203, 604);
            this.SetPanel.TabIndex = 17;
            this.SetPanel.Visible = false;
            // 
            // VideoShowPanel
            // 
            this.VideoShowPanel.Controls.Add(this.VideoShowPanelControl);
            this.VideoShowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoShowPanel.Location = new System.Drawing.Point(0, 0);
            this.VideoShowPanel.Name = "VideoShowPanel";
            this.VideoShowPanel.Size = new System.Drawing.Size(1203, 604);
            this.VideoShowPanel.TabIndex = 0;
            this.VideoShowPanel.Visible = false;
            // 
            // OverviewPanel
            // 
            this.OverviewPanel.Controls.Add(this.SetLayoutControl);
            this.OverviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OverviewPanel.Location = new System.Drawing.Point(0, 0);
            this.OverviewPanel.Name = "OverviewPanel";
            this.OverviewPanel.Size = new System.Drawing.Size(1203, 604);
            this.OverviewPanel.TabIndex = 0;
            this.OverviewPanel.Visible = false;
            // 
            // SetLayoutControl
            // 
            this.SetLayoutControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.SetLayoutControl.ColumnCount = 3;
            this.SetLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.69213F));
            this.SetLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.8149959F));
            this.SetLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.49307F));
            this.SetLayoutControl.Controls.Add(this.SetLeftLayoutControl, 0, 0);
            this.SetLayoutControl.Controls.Add(this.SetRightLayoutControl, 2, 0);
            this.SetLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.SetLayoutControl.Name = "SetLayoutControl";
            this.SetLayoutControl.RowCount = 1;
            this.SetLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SetLayoutControl.Size = new System.Drawing.Size(1203, 604);
            this.SetLayoutControl.TabIndex = 16;
            // 
            // SetLeftLayoutControl
            // 
            this.SetLeftLayoutControl.ColumnCount = 1;
            this.SetLeftLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SetLeftLayoutControl.Controls.Add(this.SetLeftPaneTitle, 0, 0);
            this.SetLeftLayoutControl.Controls.Add(this.SetLeftTopicList, 0, 1);
            this.SetLeftLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetLeftLayoutControl.Location = new System.Drawing.Point(3, 3);
            this.SetLeftLayoutControl.Name = "SetLeftLayoutControl";
            this.SetLeftLayoutControl.RowCount = 2;
            this.SetLeftLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.737733F));
            this.SetLeftLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.26227F));
            this.SetLeftLayoutControl.Size = new System.Drawing.Size(158, 598);
            this.SetLeftLayoutControl.TabIndex = 2;
            // 
            // SetLeftPaneTitle
            // 
            this.SetLeftPaneTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetLeftPaneTitle.AutoSize = true;
            this.SetLeftPaneTitle.Location = new System.Drawing.Point(44, 4);
            this.SetLeftPaneTitle.Name = "SetLeftPaneTitle";
            this.SetLeftPaneTitle.Size = new System.Drawing.Size(70, 20);
            this.SetLeftPaneTitle.TabIndex = 1;
            this.SetLeftPaneTitle.Text = "TOPICS";
            // 
            // SetLeftTopicList
            // 
            this.SetLeftTopicList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.SetLeftTopicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetLeftTopicList.FormattingEnabled = true;
            this.SetLeftTopicList.ItemHeight = 20;
            this.SetLeftTopicList.Location = new System.Drawing.Point(3, 31);
            this.SetLeftTopicList.Name = "SetLeftTopicList";
            this.SetLeftTopicList.Size = new System.Drawing.Size(152, 564);
            this.SetLeftTopicList.TabIndex = 2;
            // 
            // SetRightLayoutControl
            // 
            this.SetRightLayoutControl.AutoSize = true;
            this.SetRightLayoutControl.ColumnCount = 1;
            this.SetRightLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SetRightLayoutControl.Controls.Add(this.VideoPanelContainer, 0, 1);
            this.SetRightLayoutControl.Controls.Add(this.SetRightContentTitle, 0, 0);
            this.SetRightLayoutControl.Controls.Add(this.VideoPanel, 0, 5);
            this.SetRightLayoutControl.Controls.Add(this.SetRightVideosTitle, 0, 4);
            this.SetRightLayoutControl.Controls.Add(this.SetRightNoteTools, 0, 3);
            this.SetRightLayoutControl.Controls.Add(this.SetRightMainContent, 0, 2);
            this.SetRightLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetRightLayoutControl.Location = new System.Drawing.Point(176, 3);
            this.SetRightLayoutControl.Name = "SetRightLayoutControl";
            this.SetRightLayoutControl.RowCount = 6;
            this.SetRightLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.SetRightLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.SetRightLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SetRightLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.SetRightLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.SetRightLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SetRightLayoutControl.Size = new System.Drawing.Size(1024, 598);
            this.SetRightLayoutControl.TabIndex = 1;
            // 
            // VideoPanelContainer
            // 
            this.VideoPanelContainer.Controls.Add(this.BtnBold);
            this.VideoPanelContainer.Controls.Add(this.BtnUnderline);
            this.VideoPanelContainer.Controls.Add(this.BtnItalic);
            this.VideoPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoPanelContainer.Location = new System.Drawing.Point(0, 26);
            this.VideoPanelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.VideoPanelContainer.Name = "VideoPanelContainer";
            this.VideoPanelContainer.Size = new System.Drawing.Size(1024, 27);
            this.VideoPanelContainer.TabIndex = 5;
            // 
            // BtnBold
            // 
            this.BtnBold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnBold.Image = global::FormsApp.Properties.Resources.text_bold_16;
            this.BtnBold.Location = new System.Drawing.Point(3, 3);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(22, 18);
            this.BtnBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnBold.TabIndex = 0;
            this.BtnBold.TabStop = false;
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // BtnUnderline
            // 
            this.BtnUnderline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnUnderline.Image = global::FormsApp.Properties.Resources.underline;
            this.BtnUnderline.Location = new System.Drawing.Point(31, 4);
            this.BtnUnderline.Name = "BtnUnderline";
            this.BtnUnderline.Size = new System.Drawing.Size(16, 16);
            this.BtnUnderline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnUnderline.TabIndex = 1;
            this.BtnUnderline.TabStop = false;
            this.BtnUnderline.Click += new System.EventHandler(this.BtnUnderline_Click);
            // 
            // BtnItalic
            // 
            this.BtnItalic.Image = global::FormsApp.Properties.Resources.italic;
            this.BtnItalic.Location = new System.Drawing.Point(53, 3);
            this.BtnItalic.Name = "BtnItalic";
            this.BtnItalic.Size = new System.Drawing.Size(16, 16);
            this.BtnItalic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnItalic.TabIndex = 2;
            this.BtnItalic.TabStop = false;
            this.BtnItalic.Click += new System.EventHandler(this.BtnItalic_Click);
            // 
            // SetRightContentTitle
            // 
            this.SetRightContentTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetRightContentTitle.AutoSize = true;
            this.SetRightContentTitle.Location = new System.Drawing.Point(479, 3);
            this.SetRightContentTitle.Name = "SetRightContentTitle";
            this.SetRightContentTitle.Size = new System.Drawing.Size(66, 20);
            this.SetRightContentTitle.TabIndex = 2;
            this.SetRightContentTitle.Text = "NOTES";
            // 
            // VideoPanel
            // 
            this.VideoPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.VideoPanel.AutoScroll = true;
            this.VideoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.VideoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoPanel.Location = new System.Drawing.Point(3, 425);
            this.VideoPanel.MaximumSize = new System.Drawing.Size(0, 170);
            this.VideoPanel.Name = "VideoPanel";
            this.VideoPanel.Padding = new System.Windows.Forms.Padding(10);
            this.VideoPanel.Size = new System.Drawing.Size(1018, 170);
            this.VideoPanel.TabIndex = 3;
            this.VideoPanel.WrapContents = false;
            // 
            // SetRightVideosTitle
            // 
            this.SetRightVideosTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetRightVideosTitle.AutoSize = true;
            this.SetRightVideosTitle.Location = new System.Drawing.Point(476, 397);
            this.SetRightVideosTitle.Name = "SetRightVideosTitle";
            this.SetRightVideosTitle.Size = new System.Drawing.Size(72, 20);
            this.SetRightVideosTitle.TabIndex = 1;
            this.SetRightVideosTitle.Text = "VIDEOS";
            // 
            // SetRightNoteTools
            // 
            this.SetRightNoteTools.Controls.Add(this.TopicNameLabel);
            this.SetRightNoteTools.Controls.Add(this.TopicName);
            this.SetRightNoteTools.Controls.Add(this.NoteNameSave);
            this.SetRightNoteTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetRightNoteTools.Location = new System.Drawing.Point(3, 351);
            this.SetRightNoteTools.Name = "SetRightNoteTools";
            this.SetRightNoteTools.Size = new System.Drawing.Size(1018, 39);
            this.SetRightNoteTools.TabIndex = 4;
            this.SetRightNoteTools.WrapContents = false;
            // 
            // TopicNameLabel
            // 
            this.TopicNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TopicNameLabel.AutoSize = true;
            this.TopicNameLabel.Location = new System.Drawing.Point(3, 8);
            this.TopicNameLabel.Name = "TopicNameLabel";
            this.TopicNameLabel.Size = new System.Drawing.Size(101, 20);
            this.TopicNameLabel.TabIndex = 1;
            this.TopicNameLabel.Text = "Topic name:";
            // 
            // TopicName
            // 
            this.TopicName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TopicName.Location = new System.Drawing.Point(110, 3);
            this.TopicName.Name = "TopicName";
            this.TopicName.Size = new System.Drawing.Size(192, 31);
            this.TopicName.TabIndex = 0;
            this.TopicName.Text = "";
            // 
            // NoteNameSave
            // 
            this.NoteNameSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteNameSave.AutoSize = true;
            this.NoteNameSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.NoteNameSave.Location = new System.Drawing.Point(308, 3);
            this.NoteNameSave.Name = "NoteNameSave";
            this.NoteNameSave.Size = new System.Drawing.Size(75, 30);
            this.NoteNameSave.TabIndex = 2;
            this.NoteNameSave.Text = "Save";
            this.NoteNameSave.UseVisualStyleBackColor = false;
            this.NoteNameSave.Click += new System.EventHandler(this.NoteNameSave_Click);
            // 
            // SetRightMainContent
            // 
            this.SetRightMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.SetRightMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetRightMainContent.Location = new System.Drawing.Point(3, 56);
            this.SetRightMainContent.Name = "SetRightMainContent";
            this.SetRightMainContent.Size = new System.Drawing.Size(1018, 289);
            this.SetRightMainContent.TabIndex = 0;
            this.SetRightMainContent.Text = "";
            // 
            // AddPanelContainer
            // 
            this.AddPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(108)))));
            this.AddPanelContainer.Controls.Add(this.AddPanel);
            this.AddPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.AddPanelContainer.Name = "AddPanelContainer";
            this.AddPanelContainer.Size = new System.Drawing.Size(1203, 604);
            this.AddPanelContainer.TabIndex = 17;
            this.AddPanelContainer.Visible = false;
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(108)))));
            this.AddPanel.ColumnCount = 4;
            this.AddPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.AddPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.AddPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 988F));
            this.AddPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.AddPanel.Controls.Add(this.SetNewTitleLabel, 0, 1);
            this.AddPanel.Controls.Add(this.SetNewTitleInput, 2, 1);
            this.AddPanel.Controls.Add(this.AddPanelBtnContainer, 2, 4);
            this.AddPanel.Controls.Add(this.SetNewContentLabel, 0, 3);
            this.AddPanel.Controls.Add(this.SetNewContentInput, 2, 3);
            this.AddPanel.Controls.Add(this.SetNewTopicLabel, 0, 2);
            this.AddPanel.Controls.Add(this.SetNewTopicInput, 2, 2);
            this.AddPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPanel.Location = new System.Drawing.Point(0, 0);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.RowCount = 7;
            this.AddPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.AddPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.AddPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.AddPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.AddPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.AddPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.AddPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AddPanel.Size = new System.Drawing.Size(1203, 604);
            this.AddPanel.TabIndex = 1;
            // 
            // SetNewTitleInput
            // 
            this.SetNewTitleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.SetNewTitleInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetNewTitleInput.Location = new System.Drawing.Point(134, 34);
            this.SetNewTitleInput.Margin = new System.Windows.Forms.Padding(4);
            this.SetNewTitleInput.Name = "SetNewTitleInput";
            this.SetNewTitleInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SetNewTitleInput.Size = new System.Drawing.Size(980, 42);
            this.SetNewTitleInput.TabIndex = 0;
            this.SetNewTitleInput.Text = "";
            // 
            // AddPanelBtnContainer
            // 
            this.AddPanelBtnContainer.ColumnCount = 3;
            this.AddPanelBtnContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.AddPanelBtnContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.AddPanelBtnContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.AddPanelBtnContainer.Controls.Add(this.SetNewBtnSubmit, 1, 0);
            this.AddPanelBtnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPanelBtnContainer.Location = new System.Drawing.Point(133, 494);
            this.AddPanelBtnContainer.Name = "AddPanelBtnContainer";
            this.AddPanelBtnContainer.RowCount = 1;
            this.AddPanelBtnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddPanelBtnContainer.Size = new System.Drawing.Size(982, 46);
            this.AddPanelBtnContainer.TabIndex = 14;
            // 
            // SetNewBtnSubmit
            // 
            this.SetNewBtnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SetNewBtnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.SetNewBtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SetNewBtnSubmit.Location = new System.Drawing.Point(413, 8);
            this.SetNewBtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.SetNewBtnSubmit.Name = "SetNewBtnSubmit";
            this.SetNewBtnSubmit.Size = new System.Drawing.Size(94, 29);
            this.SetNewBtnSubmit.TabIndex = 0;
            this.SetNewBtnSubmit.Text = "Submit";
            this.SetNewBtnSubmit.UseVisualStyleBackColor = false;
            this.SetNewBtnSubmit.Click += new System.EventHandler(this.SetNewBtnSubmit_Click);
            // 
            // SetNewContentInput
            // 
            this.SetNewContentInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.SetNewContentInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetNewContentInput.Location = new System.Drawing.Point(134, 134);
            this.SetNewContentInput.Margin = new System.Windows.Forms.Padding(4);
            this.SetNewContentInput.Name = "SetNewContentInput";
            this.SetNewContentInput.Size = new System.Drawing.Size(980, 353);
            this.SetNewContentInput.TabIndex = 2;
            this.SetNewContentInput.Text = "";
            // 
            // SetNewTopicLabel
            // 
            this.SetNewTopicLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SetNewTopicLabel.AutoSize = true;
            this.SetNewTopicLabel.Location = new System.Drawing.Point(13, 95);
            this.SetNewTopicLabel.Name = "SetNewTopicLabel";
            this.SetNewTopicLabel.Size = new System.Drawing.Size(96, 20);
            this.SetNewTopicLabel.TabIndex = 15;
            this.SetNewTopicLabel.Text = "Topic name";
            // 
            // SetNewTopicInput
            // 
            this.SetNewTopicInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.SetNewTopicInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetNewTopicInput.Location = new System.Drawing.Point(133, 83);
            this.SetNewTopicInput.Name = "SetNewTopicInput";
            this.SetNewTopicInput.Size = new System.Drawing.Size(982, 44);
            this.SetNewTopicInput.TabIndex = 1;
            this.SetNewTopicInput.Text = "";
            // 
            // HomePanelContainer
            // 
            this.HomePanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.HomePanelContainer.Controls.Add(this.HomeSetList);
            this.HomePanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanelContainer.Location = new System.Drawing.Point(0, 0);
            this.HomePanelContainer.Name = "HomePanelContainer";
            this.HomePanelContainer.Size = new System.Drawing.Size(1203, 604);
            this.HomePanelContainer.TabIndex = 16;
            // 
            // HomeSetList
            // 
            this.HomeSetList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.HomeSetList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HomeSetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeSetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.HomeSetList.ForeColor = System.Drawing.Color.Black;
            this.HomeSetList.FormattingEnabled = true;
            this.HomeSetList.ItemHeight = 48;
            this.HomeSetList.Location = new System.Drawing.Point(0, 0);
            this.HomeSetList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.HomeSetList.Name = "HomeSetList";
            this.HomeSetList.Size = new System.Drawing.Size(1203, 604);
            this.HomeSetList.TabIndex = 0;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.TitlePanel.Controls.Add(this.HeaderLayoutControl);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitlePanel.Location = new System.Drawing.Point(3, 3);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1314, 44);
            this.TitlePanel.TabIndex = 2;
            // 
            // HeaderLayoutControl
            // 
            this.HeaderLayoutControl.ColumnCount = 6;
            this.HeaderLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.HeaderLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.HeaderLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.HeaderLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.HeaderLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.HeaderLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 593F));
            this.HeaderLayoutControl.Controls.Add(this.TitleBtnAdd, 1, 1);
            this.HeaderLayoutControl.Controls.Add(this.TitleBtnDelete, 2, 1);
            this.HeaderLayoutControl.Controls.Add(this.ViewTitle, 5, 1);
            this.HeaderLayoutControl.Controls.Add(this.TitleBtnBack, 4, 1);
            this.HeaderLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.HeaderLayoutControl.Name = "HeaderLayoutControl";
            this.HeaderLayoutControl.RowCount = 3;
            this.HeaderLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.HeaderLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.HeaderLayoutControl.Size = new System.Drawing.Size(1314, 44);
            this.HeaderLayoutControl.TabIndex = 0;
            // 
            // TitleBtnAdd
            // 
            this.TitleBtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleBtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.TitleBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TitleBtnAdd.Location = new System.Drawing.Point(259, 6);
            this.TitleBtnAdd.Name = "TitleBtnAdd";
            this.TitleBtnAdd.Size = new System.Drawing.Size(97, 32);
            this.TitleBtnAdd.TabIndex = 3;
            this.TitleBtnAdd.Text = "Add new set";
            this.TitleBtnAdd.UseVisualStyleBackColor = false;
            this.TitleBtnAdd.Click += new System.EventHandler(this.HomeBtnAdd_Click);
            // 
            // TitleBtnDelete
            // 
            this.TitleBtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleBtnDelete.AutoSize = true;
            this.TitleBtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.TitleBtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TitleBtnDelete.Location = new System.Drawing.Point(366, 6);
            this.TitleBtnDelete.Name = "TitleBtnDelete";
            this.TitleBtnDelete.Size = new System.Drawing.Size(116, 32);
            this.TitleBtnDelete.TabIndex = 4;
            this.TitleBtnDelete.Text = "Delete selected";
            this.TitleBtnDelete.UseVisualStyleBackColor = false;
            // 
            // ViewTitle
            // 
            this.ViewTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewTitle.AutoSize = true;
            this.ViewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ViewTitle.Location = new System.Drawing.Point(928, 2);
            this.ViewTitle.Name = "ViewTitle";
            this.ViewTitle.Size = new System.Drawing.Size(178, 39);
            this.ViewTitle.TabIndex = 1;
            this.ViewTitle.Text = "List of sets";
            // 
            // TitleBtnBack
            // 
            this.TitleBtnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleBtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.TitleBtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TitleBtnBack.Location = new System.Drawing.Point(627, 6);
            this.TitleBtnBack.Name = "TitleBtnBack";
            this.TitleBtnBack.Size = new System.Drawing.Size(63, 31);
            this.TitleBtnBack.TabIndex = 5;
            this.TitleBtnBack.Text = "Back";
            this.TitleBtnBack.UseVisualStyleBackColor = false;
            this.TitleBtnBack.Visible = false;
            this.TitleBtnBack.Click += new System.EventHandler(this.TitleBtnBack_Click);
            // 
            // VideoShowPanelControl
            // 
            this.VideoShowPanelControl.ColumnCount = 1;
            this.VideoShowPanelControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VideoShowPanelControl.Controls.Add(this.VideoShowControls, 0, 1);
            this.VideoShowPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoShowPanelControl.Location = new System.Drawing.Point(0, 0);
            this.VideoShowPanelControl.Name = "VideoShowPanelControl";
            this.VideoShowPanelControl.RowCount = 2;
            this.VideoShowPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.04636F));
            this.VideoShowPanelControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.953642F));
            this.VideoShowPanelControl.Size = new System.Drawing.Size(1203, 604);
            this.VideoShowPanelControl.TabIndex = 0;
            // 
            // VideoShowControls
            // 
            this.VideoShowControls.ColumnCount = 3;
            this.VideoShowControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.62925F));
            this.VideoShowControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.37075F));
            this.VideoShowControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VideoShowControls.Controls.Add(this.button1, 0, 0);
            this.VideoShowControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoShowControls.Location = new System.Drawing.Point(3, 564);
            this.VideoShowControls.Name = "VideoShowControls";
            this.VideoShowControls.RowCount = 1;
            this.VideoShowControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VideoShowControls.Size = new System.Drawing.Size(1197, 37);
            this.VideoShowControls.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.BaseLayoutControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainView";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.BaseLayoutControl.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.ContentContainer.ResumeLayout(false);
            this.SetPanel.ResumeLayout(false);
            this.VideoShowPanel.ResumeLayout(false);
            this.OverviewPanel.ResumeLayout(false);
            this.SetLayoutControl.ResumeLayout(false);
            this.SetLayoutControl.PerformLayout();
            this.SetLeftLayoutControl.ResumeLayout(false);
            this.SetLeftLayoutControl.PerformLayout();
            this.SetRightLayoutControl.ResumeLayout(false);
            this.SetRightLayoutControl.PerformLayout();
            this.VideoPanelContainer.ResumeLayout(false);
            this.VideoPanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUnderline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnItalic)).EndInit();
            this.SetRightNoteTools.ResumeLayout(false);
            this.SetRightNoteTools.PerformLayout();
            this.AddPanelContainer.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.AddPanel.PerformLayout();
            this.AddPanelBtnContainer.ResumeLayout(false);
            this.HomePanelContainer.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.HeaderLayoutControl.ResumeLayout(false);
            this.HeaderLayoutControl.PerformLayout();
            this.VideoShowPanelControl.ResumeLayout(false);
            this.VideoShowControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        
        #endregion
        
        private System.Windows.Forms.Label SetNewContentLabel;
        private System.Windows.Forms.Label SetNewTitleLabel;
        private System.Windows.Forms.TableLayoutPanel BaseLayoutControl;
        public System.Windows.Forms.ListBox HomeSetList;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.TableLayoutPanel HeaderLayoutControl;
        private System.Windows.Forms.Button TitleBtnAdd;
        private System.Windows.Forms.Label ViewTitle;
        private System.Windows.Forms.TableLayoutPanel HomePanel;
        private System.Windows.Forms.TableLayoutPanel AddPanel;
        private System.Windows.Forms.Panel ContentContainer;
        private System.Windows.Forms.Panel AddPanelContainer;
        private System.Windows.Forms.RichTextBox SetNewTitleInput;
        private System.Windows.Forms.RichTextBox SetNewContentInput;
        private System.Windows.Forms.TableLayoutPanel AddPanelBtnContainer;
        private System.Windows.Forms.Button SetNewBtnSubmit;
        private System.Windows.Forms.Panel HomePanelContainer;
        private System.Windows.Forms.Panel SetPanel;
        private System.Windows.Forms.TableLayoutPanel SetLayoutControl;
        private System.Windows.Forms.TableLayoutPanel SetRightLayoutControl;
        private System.Windows.Forms.RichTextBox SetRightMainContent;
        private System.Windows.Forms.Label SetRightVideosTitle;
        private System.Windows.Forms.Button TitleBtnDelete;
        private System.Windows.Forms.Button TitleBtnBack;
        private System.Windows.Forms.Label SetRightContentTitle;
        private System.Windows.Forms.FlowLayoutPanel VideoPanel;
        private System.Windows.Forms.TableLayoutPanel SetLeftLayoutControl;
        private System.Windows.Forms.Label SetLeftPaneTitle;
        private System.Windows.Forms.FlowLayoutPanel SetRightNoteTools;
        private System.Windows.Forms.RichTextBox TopicName;
        private System.Windows.Forms.Label TopicNameLabel;
        private System.Windows.Forms.Button NoteNameSave;
        private System.Windows.Forms.Label SetNewTopicLabel;
        private System.Windows.Forms.RichTextBox SetNewTopicInput;
        private System.Windows.Forms.ListBox SetLeftTopicList;
        private System.Windows.Forms.FlowLayoutPanel VideoPanelContainer;
        private System.Windows.Forms.PictureBox BtnBold;
        private System.Windows.Forms.PictureBox BtnUnderline;
        private System.Windows.Forms.PictureBox BtnItalic;
        private System.Windows.Forms.Panel VideoShowPanel;
        private System.Windows.Forms.Panel OverviewPanel;
        private TableLayoutPanel VideoShowPanelControl;
        private TableLayoutPanel VideoShowControls;
        private Button button1;
    }
}