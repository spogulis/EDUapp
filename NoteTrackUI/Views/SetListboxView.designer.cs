namespace NoteTrackUI.Views
{
    partial class SetListboxView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetListboxView));
            this.SetlistPanel = new System.Windows.Forms.Panel();
            this.HomeSetList = new Telerik.WinControls.UI.RadListView();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.SetlistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeSetList)).BeginInit();
            this.SuspendLayout();
            // 
            // SetlistPanel
            // 
            this.SetlistPanel.BackColor = System.Drawing.Color.White;
            this.SetlistPanel.Controls.Add(this.HomeSetList);
            this.SetlistPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetlistPanel.Location = new System.Drawing.Point(0, 0);
            this.SetlistPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SetlistPanel.Name = "SetlistPanel";
            this.SetlistPanel.Size = new System.Drawing.Size(1196, 472);
            this.SetlistPanel.TabIndex = 1;
            // 
            // HomeSetList
            // 
            this.HomeSetList.AllowEdit = false;
            this.HomeSetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeSetList.Location = new System.Drawing.Point(0, 0);
            this.HomeSetList.Margin = new System.Windows.Forms.Padding(0);
            this.HomeSetList.Name = "HomeSetList";
            this.HomeSetList.Size = new System.Drawing.Size(1196, 472);
            this.HomeSetList.TabIndex = 0;
            this.HomeSetList.ThemeName = "VisualStudio2012Dark";
            ((Telerik.WinControls.UI.SimpleListViewElement)(this.HomeSetList.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // SetListboxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1196, 472);
            this.Controls.Add(this.SetlistPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SetListboxView";
            this.Text = "SetlistView";
            this.SetlistPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeSetList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel SetlistPanel;
        public Telerik.WinControls.UI.RadListView HomeSetList;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}