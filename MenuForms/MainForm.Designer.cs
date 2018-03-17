namespace MenuForms
{
    partial class MainForm
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
            this.mHeader = new System.Windows.Forms.MenuStrip();
            this.mFileHeader = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stStatusBar = new System.Windows.Forms.StatusStrip();
            this.stLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.stProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.stTimeNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGetCountUsers = new System.Windows.Forms.Button();
            this.mHeader.SuspendLayout();
            this.stStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mHeader
            // 
            this.mHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileHeader});
            this.mHeader.Location = new System.Drawing.Point(0, 0);
            this.mHeader.Name = "mHeader";
            this.mHeader.Size = new System.Drawing.Size(513, 24);
            this.mHeader.TabIndex = 0;
            this.mHeader.Text = "menuStrip1";
            // 
            // mFileHeader
            // 
            this.mFileHeader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileExit});
            this.mFileHeader.Name = "mFileHeader";
            this.mFileHeader.Size = new System.Drawing.Size(37, 20);
            this.mFileHeader.Text = "File";
            // 
            // mFileExit
            // 
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mFileExit.Size = new System.Drawing.Size(152, 22);
            this.mFileExit.Text = "Exit";
            this.mFileExit.Click += new System.EventHandler(this.mFileExit_Click);
            // 
            // stStatusBar
            // 
            this.stStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLabelInfo,
            this.stProgressBar,
            this.stTimeNow});
            this.stStatusBar.Location = new System.Drawing.Point(0, 265);
            this.stStatusBar.Name = "stStatusBar";
            this.stStatusBar.Size = new System.Drawing.Size(513, 22);
            this.stStatusBar.TabIndex = 1;
            this.stStatusBar.Text = "statusStrip1";
            // 
            // stLabelInfo
            // 
            this.stLabelInfo.Name = "stLabelInfo";
            this.stLabelInfo.Size = new System.Drawing.Size(67, 17);
            this.stLabelInfo.Text = "Загрузка ...";
            // 
            // stProgressBar
            // 
            this.stProgressBar.Name = "stProgressBar";
            this.stProgressBar.Size = new System.Drawing.Size(100, 16);
            this.stProgressBar.Value = 50;
            // 
            // stTimeNow
            // 
            this.stTimeNow.Name = "stTimeNow";
            this.stTimeNow.Size = new System.Drawing.Size(329, 17);
            this.stTimeNow.Spring = true;
            this.stTimeNow.Text = "00:00:00";
            this.stTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGetCountUsers
            // 
            this.btnGetCountUsers.Location = new System.Drawing.Point(114, 27);
            this.btnGetCountUsers.Name = "btnGetCountUsers";
            this.btnGetCountUsers.Size = new System.Drawing.Size(120, 39);
            this.btnGetCountUsers.TabIndex = 2;
            this.btnGetCountUsers.Text = "Кількість користувачів";
            this.btnGetCountUsers.UseVisualStyleBackColor = true;
            this.btnGetCountUsers.Click += new System.EventHandler(this.btnGetCountUsers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 287);
            this.Controls.Add(this.btnGetCountUsers);
            this.Controls.Add(this.stStatusBar);
            this.Controls.Add(this.mHeader);
            this.MainMenuStrip = this.mHeader;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mHeader.ResumeLayout(false);
            this.mHeader.PerformLayout();
            this.stStatusBar.ResumeLayout(false);
            this.stStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mHeader;
        private System.Windows.Forms.ToolStripMenuItem mFileHeader;
        private System.Windows.Forms.ToolStripMenuItem mFileExit;
        private System.Windows.Forms.StatusStrip stStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel stLabelInfo;
        private System.Windows.Forms.ToolStripProgressBar stProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel stTimeNow;
        private System.Windows.Forms.Button btnGetCountUsers;
    }
}

