namespace NoteTrackUI.Views
{
    partial class SetNameUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetNameUpdater));
            this.inputNewSetTitle = new System.Windows.Forms.TextBox();
            this.LabelWindowTitle = new System.Windows.Forms.Label();
            this.SetNameUpdaterBtnSubmit = new System.Windows.Forms.Button();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputNewSetTitle
            // 
            this.inputNewSetTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNewSetTitle.BackColor = System.Drawing.Color.White;
            this.inputNewSetTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNewSetTitle.Location = new System.Drawing.Point(32, 65);
            this.inputNewSetTitle.MaximumSize = new System.Drawing.Size(621, 43);
            this.inputNewSetTitle.MinimumSize = new System.Drawing.Size(621, 43);
            this.inputNewSetTitle.Name = "inputNewSetTitle";
            this.inputNewSetTitle.Size = new System.Drawing.Size(621, 43);
            this.inputNewSetTitle.TabIndex = 0;
            // 
            // LabelWindowTitle
            // 
            this.LabelWindowTitle.AccessibleName = "Change set title";
            this.LabelWindowTitle.AutoSize = true;
            this.LabelWindowTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWindowTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LabelWindowTitle.Location = new System.Drawing.Point(131, 7);
            this.LabelWindowTitle.Name = "LabelWindowTitle";
            this.LabelWindowTitle.Size = new System.Drawing.Size(417, 38);
            this.LabelWindowTitle.TabIndex = 1;
            this.LabelWindowTitle.Text = "The new set title is going to be...";
            // 
            // SetNameUpdaterBtnSubmit
            // 
            this.SetNameUpdaterBtnSubmit.AutoSize = true;
            this.SetNameUpdaterBtnSubmit.BackColor = System.Drawing.Color.White;
            this.SetNameUpdaterBtnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SetNameUpdaterBtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SetNameUpdaterBtnSubmit.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SetNameUpdaterBtnSubmit.Location = new System.Drawing.Point(294, 114);
            this.SetNameUpdaterBtnSubmit.Name = "SetNameUpdaterBtnSubmit";
            this.SetNameUpdaterBtnSubmit.Size = new System.Drawing.Size(114, 48);
            this.SetNameUpdaterBtnSubmit.TabIndex = 2;
            this.SetNameUpdaterBtnSubmit.Text = "Submit";
            this.SetNameUpdaterBtnSubmit.UseVisualStyleBackColor = false;
            this.SetNameUpdaterBtnSubmit.Visible = false;
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.WarningLabel.ForeColor = System.Drawing.Color.Yellow;
            this.WarningLabel.Location = new System.Drawing.Point(23, 136);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(504, 23);
            this.WarningLabel.TabIndex = 3;
            this.WarningLabel.Text = "Title can only contain letters and numbers, and cannot be empty";
            // 
            // SetNameUpdater
            // 
            this.AcceptButton = this.SetNameUpdaterBtnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 173);
            this.Controls.Add(this.SetNameUpdaterBtnSubmit);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.LabelWindowTitle);
            this.Controls.Add(this.inputNewSetTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(75, 350);
            this.MaximumSize = new System.Drawing.Size(700, 220);
            this.MinimumSize = new System.Drawing.Size(700, 220);
            this.Name = "SetNameUpdater";
            this.Text = "Change title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox inputNewSetTitle;
        private System.Windows.Forms.Label LabelWindowTitle;
        public System.Windows.Forms.Button SetNameUpdaterBtnSubmit;
        public System.Windows.Forms.Label WarningLabel;
    }
}