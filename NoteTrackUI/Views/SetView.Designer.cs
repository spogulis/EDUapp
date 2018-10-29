namespace NoteTrackUI.Views
{
    partial class SetView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetView));
            this.SetViewMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanelTable = new System.Windows.Forms.TableLayoutPanel();
            this.LabelNotesTitle = new System.Windows.Forms.Label();
            this.NoteUtilities = new System.Windows.Forms.TableLayoutPanel();
            this.btnBold = new System.Windows.Forms.PictureBox();
            this.btnUnderline = new System.Windows.Forms.PictureBox();
            this.btnItalic = new System.Windows.Forms.PictureBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.MainContent = new System.Windows.Forms.RichTextBox();
            this.TopicManagementUtilities = new System.Windows.Forms.Panel();
            this.btnNewOldTopicSave = new System.Windows.Forms.Button();
            this.LabelNewTopicName = new System.Windows.Forms.Label();
            this.InputNewTopicName = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelVideos = new System.Windows.Forms.Label();
            this.btnAddVideos = new System.Windows.Forms.Button();
            this.VideoThumbPanel = new Telerik.WinControls.UI.RadScrollablePanel();
            this.ListboxPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTopicListbox = new System.Windows.Forms.Label();
            this.TopicListbox = new Telerik.WinControls.UI.RadListView();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.visualStudio2012DarkTheme2 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.SetViewMainPanel.SuspendLayout();
            this.MainPanelTable.SuspendLayout();
            this.NoteUtilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnderline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItalic)).BeginInit();
            this.TopicManagementUtilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideoThumbPanel)).BeginInit();
            this.VideoThumbPanel.SuspendLayout();
            this.ListboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopicListbox)).BeginInit();
            this.SuspendLayout();
            // 
            // SetViewMainPanel
            // 
            this.SetViewMainPanel.BackColor = System.Drawing.Color.Black;
            this.SetViewMainPanel.ColumnCount = 3;
            this.SetViewMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SetViewMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SetViewMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 990F));
            this.SetViewMainPanel.Controls.Add(this.MainPanelTable, 2, 0);
            this.SetViewMainPanel.Controls.Add(this.ListboxPanel, 0, 0);
            this.SetViewMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetViewMainPanel.Location = new System.Drawing.Point(0, 0);
            this.SetViewMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SetViewMainPanel.Name = "SetViewMainPanel";
            this.SetViewMainPanel.RowCount = 1;
            this.SetViewMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SetViewMainPanel.Size = new System.Drawing.Size(1357, 741);
            this.SetViewMainPanel.TabIndex = 1;
            this.SetViewMainPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.OnSetViewMainPanelCellPaint);
            // 
            // MainPanelTable
            // 
            this.MainPanelTable.BackColor = System.Drawing.Color.Black;
            this.MainPanelTable.ColumnCount = 1;
            this.MainPanelTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanelTable.Controls.Add(this.LabelNotesTitle, 0, 0);
            this.MainPanelTable.Controls.Add(this.NoteUtilities, 0, 1);
            this.MainPanelTable.Controls.Add(this.MainContent, 0, 2);
            this.MainPanelTable.Controls.Add(this.TopicManagementUtilities, 0, 3);
            this.MainPanelTable.Controls.Add(this.splitContainer1, 0, 4);
            this.MainPanelTable.Controls.Add(this.VideoThumbPanel, 0, 5);
            this.MainPanelTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanelTable.Location = new System.Drawing.Point(367, 0);
            this.MainPanelTable.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanelTable.Name = "MainPanelTable";
            this.MainPanelTable.RowCount = 6;
            this.MainPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.MainPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.MainPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.MainPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.MainPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.MainPanelTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanelTable.Size = new System.Drawing.Size(990, 741);
            this.MainPanelTable.TabIndex = 0;
            this.MainPanelTable.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.MainPanelTable_CellPaint);
            // 
            // LabelNotesTitle
            // 
            this.LabelNotesTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNotesTitle.AutoSize = true;
            this.LabelNotesTitle.BackColor = System.Drawing.Color.Black;
            this.LabelNotesTitle.ForeColor = System.Drawing.Color.OliveDrab;
            this.LabelNotesTitle.Location = new System.Drawing.Point(450, 0);
            this.LabelNotesTitle.Name = "LabelNotesTitle";
            this.LabelNotesTitle.Size = new System.Drawing.Size(90, 38);
            this.LabelNotesTitle.TabIndex = 0;
            this.LabelNotesTitle.Text = "Notes";
            // 
            // NoteUtilities
            // 
            this.NoteUtilities.BackColor = System.Drawing.Color.Black;
            this.NoteUtilities.ColumnCount = 7;
            this.NoteUtilities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NoteUtilities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NoteUtilities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NoteUtilities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NoteUtilities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.NoteUtilities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.NoteUtilities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.NoteUtilities.Controls.Add(this.btnBold, 0, 0);
            this.NoteUtilities.Controls.Add(this.btnUnderline, 1, 0);
            this.NoteUtilities.Controls.Add(this.btnItalic, 2, 0);
            this.NoteUtilities.Controls.Add(this.btnCode, 6, 0);
            this.NoteUtilities.Controls.Add(this.btnClear, 5, 0);
            this.NoteUtilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteUtilities.Location = new System.Drawing.Point(0, 38);
            this.NoteUtilities.Margin = new System.Windows.Forms.Padding(0);
            this.NoteUtilities.Name = "NoteUtilities";
            this.NoteUtilities.RowCount = 1;
            this.NoteUtilities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NoteUtilities.Size = new System.Drawing.Size(990, 26);
            this.NoteUtilities.TabIndex = 1;
            // 
            // btnBold
            // 
            this.btnBold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.Location = new System.Drawing.Point(3, 3);
            this.btnBold.Margin = new System.Windows.Forms.Padding(0);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(14, 20);
            this.btnBold.TabIndex = 0;
            this.btnBold.TabStop = false;
            // 
            // btnUnderline
            // 
            this.btnUnderline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.Location = new System.Drawing.Point(23, 3);
            this.btnUnderline.Margin = new System.Windows.Forms.Padding(0);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(14, 20);
            this.btnUnderline.TabIndex = 1;
            this.btnUnderline.TabStop = false;
            // 
            // btnItalic
            // 
            this.btnItalic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnItalic.Image = global::NoteTrackUI.Properties.Resources.italic;
            this.btnItalic.Location = new System.Drawing.Point(43, 3);
            this.btnItalic.Margin = new System.Windows.Forms.Padding(0);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(14, 20);
            this.btnItalic.TabIndex = 2;
            this.btnItalic.TabStop = false;
            // 
            // btnCode
            // 
            this.btnCode.BackColor = System.Drawing.Color.White;
            this.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnCode.ForeColor = System.Drawing.Color.Black;
            this.btnCode.Location = new System.Drawing.Point(920, 0);
            this.btnCode.Margin = new System.Windows.Forms.Padding(0);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(70, 23);
            this.btnCode.TabIndex = 3;
            this.btnCode.Text = "code";
            this.btnCode.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(850, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // MainContent
            // 
            this.MainContent.AcceptsTab = true;
            this.MainContent.BackColor = System.Drawing.Color.White;
            this.MainContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContent.Location = new System.Drawing.Point(0, 64);
            this.MainContent.Margin = new System.Windows.Forms.Padding(0);
            this.MainContent.Name = "MainContent";
            this.MainContent.Size = new System.Drawing.Size(990, 425);
            this.MainContent.TabIndex = 2;
            this.MainContent.Text = "";
            // 
            // TopicManagementUtilities
            // 
            this.TopicManagementUtilities.BackColor = System.Drawing.Color.Black;
            this.TopicManagementUtilities.Controls.Add(this.btnNewOldTopicSave);
            this.TopicManagementUtilities.Controls.Add(this.LabelNewTopicName);
            this.TopicManagementUtilities.Controls.Add(this.InputNewTopicName);
            this.TopicManagementUtilities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopicManagementUtilities.Location = new System.Drawing.Point(0, 489);
            this.TopicManagementUtilities.Margin = new System.Windows.Forms.Padding(0);
            this.TopicManagementUtilities.Name = "TopicManagementUtilities";
            this.TopicManagementUtilities.Size = new System.Drawing.Size(990, 44);
            this.TopicManagementUtilities.TabIndex = 7;
            // 
            // btnNewOldTopicSave
            // 
            this.btnNewOldTopicSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewOldTopicSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnNewOldTopicSave.Location = new System.Drawing.Point(454, 8);
            this.btnNewOldTopicSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewOldTopicSave.Name = "btnNewOldTopicSave";
            this.btnNewOldTopicSave.Size = new System.Drawing.Size(75, 23);
            this.btnNewOldTopicSave.TabIndex = 7;
            this.btnNewOldTopicSave.Text = "Save";
            this.btnNewOldTopicSave.UseVisualStyleBackColor = true;
            // 
            // LabelNewTopicName
            // 
            this.LabelNewTopicName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelNewTopicName.AutoSize = true;
            this.LabelNewTopicName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LabelNewTopicName.Location = new System.Drawing.Point(0, 11);
            this.LabelNewTopicName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelNewTopicName.Name = "LabelNewTopicName";
            this.LabelNewTopicName.Size = new System.Drawing.Size(185, 28);
            this.LabelNewTopicName.TabIndex = 6;
            this.LabelNewTopicName.Text = "Save as a new topic:";
            // 
            // InputNewTopicName
            // 
            this.InputNewTopicName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InputNewTopicName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.InputNewTopicName.Location = new System.Drawing.Point(170, 9);
            this.InputNewTopicName.Margin = new System.Windows.Forms.Padding(0);
            this.InputNewTopicName.Name = "InputNewTopicName";
            this.InputNewTopicName.Size = new System.Drawing.Size(272, 32);
            this.InputNewTopicName.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 536);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelVideos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnAddVideos);
            this.splitContainer1.Size = new System.Drawing.Size(984, 32);
            this.splitContainer1.SplitterDistance = 541;
            this.splitContainer1.TabIndex = 8;
            // 
            // labelVideos
            // 
            this.labelVideos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVideos.AutoSize = true;
            this.labelVideos.BackColor = System.Drawing.Color.Black;
            this.labelVideos.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelVideos.Location = new System.Drawing.Point(450, 0);
            this.labelVideos.Name = "labelVideos";
            this.labelVideos.Size = new System.Drawing.Size(100, 38);
            this.labelVideos.TabIndex = 4;
            this.labelVideos.Text = "Videos";
            // 
            // btnAddVideos
            // 
            this.btnAddVideos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddVideos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnAddVideos.Location = new System.Drawing.Point(365, 6);
            this.btnAddVideos.Name = "btnAddVideos";
            this.btnAddVideos.Size = new System.Drawing.Size(65, 23);
            this.btnAddVideos.TabIndex = 0;
            this.btnAddVideos.Text = " Add";
            this.btnAddVideos.UseVisualStyleBackColor = true;
            // 
            // VideoThumbPanel
            // 
            this.VideoThumbPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoThumbPanel.Location = new System.Drawing.Point(0, 571);
            this.VideoThumbPanel.Margin = new System.Windows.Forms.Padding(0);
            this.VideoThumbPanel.Name = "VideoThumbPanel";
            // 
            // VideoThumbPanel.PanelContainer
            // 
            this.VideoThumbPanel.PanelContainer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.VideoThumbPanel.PanelContainer.Size = new System.Drawing.Size(988, 168);
            this.VideoThumbPanel.Size = new System.Drawing.Size(990, 170);
            this.VideoThumbPanel.TabIndex = 9;
            this.VideoThumbPanel.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.RadScrollablePanelElement)(this.VideoThumbPanel.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(1);
            ((Telerik.WinControls.UI.RadScrollablePanelElement)(this.VideoThumbPanel.GetChildAt(0))).StretchVertically = false;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VideoThumbPanel.GetChildAt(0).GetChildAt(1))).ForeColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VideoThumbPanel.GetChildAt(0).GetChildAt(1))).ForeColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VideoThumbPanel.GetChildAt(0).GetChildAt(1))).ForeColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VideoThumbPanel.GetChildAt(0).GetChildAt(1))).InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VideoThumbPanel.GetChildAt(0).GetChildAt(1))).InnerColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VideoThumbPanel.GetChildAt(0).GetChildAt(1))).InnerColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VideoThumbPanel.GetChildAt(0).GetChildAt(1))).InnerColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.VideoThumbPanel.GetChildAt(0).GetChildAt(1))).ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // ListboxPanel
            // 
            this.ListboxPanel.BackColor = System.Drawing.Color.Black;
            this.ListboxPanel.ColumnCount = 1;
            this.ListboxPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ListboxPanel.Controls.Add(this.LabelTopicListbox, 0, 0);
            this.ListboxPanel.Controls.Add(this.TopicListbox, 0, 1);
            this.ListboxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListboxPanel.Location = new System.Drawing.Point(1, 1);
            this.ListboxPanel.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.ListboxPanel.Name = "ListboxPanel";
            this.ListboxPanel.RowCount = 2;
            this.ListboxPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.ListboxPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ListboxPanel.Size = new System.Drawing.Size(346, 739);
            this.ListboxPanel.TabIndex = 1;
            this.ListboxPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.ListboxPanel_CellPaint);
            // 
            // LabelTopicListbox
            // 
            this.LabelTopicListbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTopicListbox.AutoSize = true;
            this.LabelTopicListbox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LabelTopicListbox.ForeColor = System.Drawing.Color.OliveDrab;
            this.LabelTopicListbox.Location = new System.Drawing.Point(126, 0);
            this.LabelTopicListbox.Name = "LabelTopicListbox";
            this.LabelTopicListbox.Size = new System.Drawing.Size(93, 38);
            this.LabelTopicListbox.TabIndex = 2;
            this.LabelTopicListbox.Text = "Topics";
            // 
            // TopicListbox
            // 
            this.TopicListbox.AllowEdit = false;
            this.TopicListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopicListbox.Location = new System.Drawing.Point(3, 41);
            this.TopicListbox.Name = "TopicListbox";
            this.TopicListbox.Size = new System.Drawing.Size(340, 695);
            this.TopicListbox.TabIndex = 3;
            this.TopicListbox.ThemeName = "VisualStudio2012Dark";
            // 
            // SetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1357, 741);
            this.Controls.Add(this.SetViewMainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SetView";
            this.Text = "SetView";
            this.SetViewMainPanel.ResumeLayout(false);
            this.MainPanelTable.ResumeLayout(false);
            this.MainPanelTable.PerformLayout();
            this.NoteUtilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnderline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnItalic)).EndInit();
            this.TopicManagementUtilities.ResumeLayout(false);
            this.TopicManagementUtilities.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VideoThumbPanel)).EndInit();
            this.VideoThumbPanel.ResumeLayout(false);
            this.ListboxPanel.ResumeLayout(false);
            this.ListboxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopicListbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TableLayoutPanel SetViewMainPanel;
        private System.Windows.Forms.TableLayoutPanel MainPanelTable;
        private System.Windows.Forms.Label LabelNotesTitle;
        private System.Windows.Forms.TableLayoutPanel NoteUtilities;
        public System.Windows.Forms.Button btnCode;
        public System.Windows.Forms.PictureBox btnBold;
        public System.Windows.Forms.PictureBox btnUnderline;
        public System.Windows.Forms.PictureBox btnItalic;
        private System.Windows.Forms.Label labelVideos;
        private System.Windows.Forms.Panel TopicManagementUtilities;
        public System.Windows.Forms.RichTextBox MainContent;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox InputNewTopicName;
        public System.Windows.Forms.Label LabelNewTopicName;
        public System.Windows.Forms.Button btnNewOldTopicSave;
        public System.Windows.Forms.TableLayoutPanel ListboxPanel;
        private System.Windows.Forms.Label LabelTopicListbox;
        public System.Windows.Forms.Button btnAddVideos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public Telerik.WinControls.UI.RadScrollablePanel VideoThumbPanel;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme2;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        public Telerik.WinControls.UI.RadListView TopicListbox;
    }
}