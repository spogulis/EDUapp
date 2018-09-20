namespace FormsApp
{
    partial class SetviewBtnBack
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.SetviewLabelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainBtnAddSet = new System.Windows.Forms.Button();
            this.SetviewMainPanel = new System.Windows.Forms.Panel();
            this.SetviewTopicPanel = new System.Windows.Forms.Panel();
            this.SetviewTextPanel = new System.Windows.Forms.Panel();
            this.SetviewRightVideoPanel = new System.Windows.Forms.Panel();
            this.SetviewTextbox = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SetviewMainPanel.SuspendLayout();
            this.SetviewTextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.panel3.Controls.Add(this.SetviewLabelTitle);
            this.panel3.Location = new System.Drawing.Point(378, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 32);
            this.panel3.TabIndex = 2;
            // 
            // SetviewLabelTitle
            // 
            this.SetviewLabelTitle.AutoSize = true;
            this.SetviewLabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SetviewLabelTitle.Location = new System.Drawing.Point(321, 8);
            this.SetviewLabelTitle.Name = "SetviewLabelTitle";
            this.SetviewLabelTitle.Size = new System.Drawing.Size(93, 20);
            this.SetviewLabelTitle.TabIndex = 1;
            this.SetviewLabelTitle.Text = "List of sets";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.MainBtnAddSet);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 38);
            this.panel1.TabIndex = 1;
            // 
            // MainBtnAddSet
            // 
            this.MainBtnAddSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(236)))), ((int)(((byte)(162)))));
            this.MainBtnAddSet.Location = new System.Drawing.Point(256, 3);
            this.MainBtnAddSet.Name = "MainBtnAddSet";
            this.MainBtnAddSet.Size = new System.Drawing.Size(116, 32);
            this.MainBtnAddSet.TabIndex = 3;
            this.MainBtnAddSet.Text = "Back to list";
            this.MainBtnAddSet.UseVisualStyleBackColor = false;
            // 
            // SetviewMainPanel
            // 
            this.SetviewMainPanel.Controls.Add(this.SetviewRightVideoPanel);
            this.SetviewMainPanel.Controls.Add(this.SetviewTextPanel);
            this.SetviewMainPanel.Controls.Add(this.SetviewTopicPanel);
            this.SetviewMainPanel.Location = new System.Drawing.Point(4, 48);
            this.SetviewMainPanel.Name = "SetviewMainPanel";
            this.SetviewMainPanel.Size = new System.Drawing.Size(1085, 487);
            this.SetviewMainPanel.TabIndex = 2;
            // 
            // SetviewTopicPanel
            // 
            this.SetviewTopicPanel.Location = new System.Drawing.Point(4, 4);
            this.SetviewTopicPanel.Name = "SetviewTopicPanel";
            this.SetviewTopicPanel.Size = new System.Drawing.Size(172, 480);
            this.SetviewTopicPanel.TabIndex = 0;
            // 
            // SetviewTextPanel
            // 
            this.SetviewTextPanel.Controls.Add(this.SetviewTextbox);
            this.SetviewTextPanel.Location = new System.Drawing.Point(182, 4);
            this.SetviewTextPanel.Name = "SetviewTextPanel";
            this.SetviewTextPanel.Size = new System.Drawing.Size(897, 236);
            this.SetviewTextPanel.TabIndex = 1;
            // 
            // SetviewRightVideoPanel
            // 
            this.SetviewRightVideoPanel.Location = new System.Drawing.Point(182, 246);
            this.SetviewRightVideoPanel.Name = "SetviewRightVideoPanel";
            this.SetviewRightVideoPanel.Size = new System.Drawing.Size(897, 238);
            this.SetviewRightVideoPanel.TabIndex = 2;
            // 
            // SetviewTextbox
            // 
            this.SetviewTextbox.Location = new System.Drawing.Point(3, 3);
            this.SetviewTextbox.Multiline = true;
            this.SetviewTextbox.Name = "SetviewTextbox";
            this.SetviewTextbox.ReadOnly = true;
            this.SetviewTextbox.Size = new System.Drawing.Size(891, 230);
            this.SetviewTextbox.TabIndex = 0;
            // 
            // SetviewBtnBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(240)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1095, 547);
            this.Controls.Add(this.SetviewMainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "SetviewBtnBack";
            this.Text = "SetView";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.SetviewMainPanel.ResumeLayout(false);
            this.SetviewTextPanel.ResumeLayout(false);
            this.SetviewTextPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label SetviewLabelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MainBtnAddSet;
        private System.Windows.Forms.Panel SetviewMainPanel;
        private System.Windows.Forms.Panel SetviewRightVideoPanel;
        private System.Windows.Forms.Panel SetviewTextPanel;
        private System.Windows.Forms.TextBox SetviewTextbox;
        private System.Windows.Forms.Panel SetviewTopicPanel;
    }
}