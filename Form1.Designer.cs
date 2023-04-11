namespace SpotifyAppLiam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.repeat = new System.Windows.Forms.Button();
            this.curentsong = new System.Windows.Forms.TextBox();
            this.friendList = new System.Windows.Forms.ListBox();
            this.playList = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(409, 419);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(94, 29);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(309, 419);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(94, 29);
            this.pause.TabIndex = 1;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // repeat
            // 
            this.repeat.Location = new System.Drawing.Point(509, 419);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(94, 29);
            this.repeat.TabIndex = 2;
            this.repeat.Text = "Repeat";
            this.repeat.UseVisualStyleBackColor = true;
            this.repeat.Click += new System.EventHandler(this.repeat_Click);
            // 
            // curentsong
            // 
            this.curentsong.Location = new System.Drawing.Point(309, 386);
            this.curentsong.Name = "curentsong";
            this.curentsong.Size = new System.Drawing.Size(294, 27);
            this.curentsong.TabIndex = 3;
            this.curentsong.TextChanged += new System.EventHandler(this.curentsong_TextChanged);
            // 
            // friendList
            // 
            this.friendList.FormattingEnabled = true;
            this.friendList.ItemHeight = 20;
            this.friendList.Location = new System.Drawing.Point(609, 239);
            this.friendList.Name = "friendList";
            this.friendList.Size = new System.Drawing.Size(150, 244);
            this.friendList.TabIndex = 4;
            this.friendList.SelectedIndexChanged += new System.EventHandler(this.friendList_SelectedIndexChanged);
            // 
            // playList
            // 
            this.playList.FormattingEnabled = true;
            this.playList.ItemHeight = 20;
            this.playList.Location = new System.Drawing.Point(153, 239);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(150, 244);
            this.playList.TabIndex = 5;
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(309, 454);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(294, 29);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.friendList);
            this.Controls.Add(this.curentsong);
            this.Controls.Add(this.repeat);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button play;
        private Button pause;
        private Button repeat;
        private TextBox curentsong;
        private ListBox friendList;
        private ListBox playList;
        private ProgressBar progressBar1;
        private Label label1;
    }
}