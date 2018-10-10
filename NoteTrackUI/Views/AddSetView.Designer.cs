namespace NoteTrackUI.Views
{
    partial class AddSetView
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
            this.AddSetViewOuterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InnerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TopicTitle = new System.Windows.Forms.Label();
            this.ContentTitle = new System.Windows.Forms.Label();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.TopicContentInput = new System.Windows.Forms.RichTextBox();
            this.TopicInput = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.AddSetViewOuterPanel.SuspendLayout();
            this.InnerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddSetViewOuterPanel
            // 
            this.AddSetViewOuterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(108)))));
            this.AddSetViewOuterPanel.ColumnCount = 3;
            this.AddSetViewOuterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AddSetViewOuterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddSetViewOuterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AddSetViewOuterPanel.Controls.Add(this.InnerPanel, 1, 1);
            this.AddSetViewOuterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSetViewOuterPanel.Location = new System.Drawing.Point(0, 0);
            this.AddSetViewOuterPanel.Margin = new System.Windows.Forms.Padding(0);
            this.AddSetViewOuterPanel.Name = "AddSetViewOuterPanel";
            this.AddSetViewOuterPanel.RowCount = 3;
            this.AddSetViewOuterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AddSetViewOuterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AddSetViewOuterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AddSetViewOuterPanel.Size = new System.Drawing.Size(1171, 570);
            this.AddSetViewOuterPanel.TabIndex = 0;
            // 
            // InnerPanel
            // 
            this.InnerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(108)))));
            this.InnerPanel.ColumnCount = 2;
            this.InnerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.InnerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InnerPanel.Controls.Add(this.LabelTitle, 0, 1);
            this.InnerPanel.Controls.Add(this.TopicTitle, 0, 3);
            this.InnerPanel.Controls.Add(this.ContentTitle, 0, 5);
            this.InnerPanel.Controls.Add(this.TitleInput, 1, 1);
            this.InnerPanel.Controls.Add(this.TopicContentInput, 1, 5);
            this.InnerPanel.Controls.Add(this.TopicInput, 1, 3);
            this.InnerPanel.Controls.Add(this.SubmitBtn, 1, 6);
            this.InnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerPanel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.InnerPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.InnerPanel.Location = new System.Drawing.Point(20, 20);
            this.InnerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.InnerPanel.Name = "InnerPanel";
            this.InnerPanel.RowCount = 7;
            this.InnerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InnerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.InnerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.InnerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.InnerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.InnerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InnerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.InnerPanel.Size = new System.Drawing.Size(1131, 530);
            this.InnerPanel.TabIndex = 0;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LabelTitle.Location = new System.Drawing.Point(75, 29);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(102, 32);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Set title";
            // 
            // TopicTitle
            // 
            this.TopicTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TopicTitle.AutoSize = true;
            this.TopicTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TopicTitle.Location = new System.Drawing.Point(49, 84);
            this.TopicTitle.Name = "TopicTitle";
            this.TopicTitle.Size = new System.Drawing.Size(128, 32);
            this.TopicTitle.TabIndex = 1;
            this.TopicTitle.Text = "Topic title";
            // 
            // ContentTitle
            // 
            this.ContentTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ContentTitle.AutoSize = true;
            this.ContentTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ContentTitle.Location = new System.Drawing.Point(6, 289);
            this.ContentTitle.Name = "ContentTitle";
            this.ContentTitle.Size = new System.Drawing.Size(171, 32);
            this.ContentTitle.TabIndex = 2;
            this.ContentTitle.Text = "Topic content";
            // 
            // TitleInput
            // 
            this.TitleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.TitleInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleInput.Location = new System.Drawing.Point(183, 23);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(945, 38);
            this.TitleInput.TabIndex = 0;
            // 
            // TopicContentInput
            // 
            this.TopicContentInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.TopicContentInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopicContentInput.Location = new System.Drawing.Point(183, 133);
            this.TopicContentInput.Name = "TopicContentInput";
            this.TopicContentInput.Size = new System.Drawing.Size(945, 344);
            this.TopicContentInput.TabIndex = 2;
            this.TopicContentInput.Text = "";
            // 
            // TopicInput
            // 
            this.TopicInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.TopicInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopicInput.Location = new System.Drawing.Point(183, 78);
            this.TopicInput.Name = "TopicInput";
            this.TopicInput.Size = new System.Drawing.Size(945, 38);
            this.TopicInput.TabIndex = 1;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitBtn.AutoSize = true;
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.SubmitBtn.Location = new System.Drawing.Point(600, 484);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(110, 42);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            // 
            // AddSetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1171, 570);
            this.Controls.Add(this.AddSetViewOuterPanel);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "AddSetView";
            this.Text = "AddSetView";
            this.AddSetViewOuterPanel.ResumeLayout(false);
            this.InnerPanel.ResumeLayout(false);
            this.InnerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel InnerPanel;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label TopicTitle;
        private System.Windows.Forms.Label ContentTitle;
        public System.Windows.Forms.TextBox TitleInput;
        public System.Windows.Forms.RichTextBox TopicContentInput;
        public System.Windows.Forms.TextBox TopicInput;
        public System.Windows.Forms.TableLayoutPanel AddSetViewOuterPanel;
        public System.Windows.Forms.Button SubmitBtn;
    }
}