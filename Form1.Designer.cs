namespace Songy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exitButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.sButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.PictureBox();
            this.skip = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SongDisplay = new System.Windows.Forms.ListView();
            this.header = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // title
            // 
            this.title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.title.BackColor = System.Drawing.Color.Black;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.title.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            this.title.Click += new System.EventHandler(this.Label2_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // sButton
            // 
            this.sButton.FlatAppearance.BorderSize = 2;
            this.sButton.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.sButton, "sButton");
            this.sButton.Name = "sButton";
            this.sButton.UseVisualStyleBackColor = false;
            this.sButton.Click += new System.EventHandler(this.Search_Click);
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderSize = 2;
            this.playButton.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.playButton, "playButton");
            this.playButton.Name = "playButton";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.FlatAppearance.BorderSize = 2;
            this.nextButton.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.nextButton, "nextButton");
            this.nextButton.Name = "nextButton";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // search
            // 
            this.search.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.search, "search");
            this.search.Name = "search";
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // skip
            // 
            this.skip.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.skip, "skip");
            this.skip.Name = "skip";
            this.skip.TabStop = false;
            this.skip.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // back
            // 
            this.back.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.back, "back");
            this.back.Name = "back";
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pause
            // 
            this.pause.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.pause, "pause");
            this.pause.Name = "pause";
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.StopButton_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SongDisplay
            // 
            this.SongDisplay.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.SongDisplay, "SongDisplay");
            this.SongDisplay.Name = "SongDisplay";
            this.SongDisplay.UseCompatibleStateImageBehavior = false;
            this.SongDisplay.SelectedIndexChanged += new System.EventHandler(this.SongDisplay_SelectedIndexChanged);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Controls.Add(this.pictureBox2);
            this.header.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.header, "header");
            this.header.Name = "header";
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.SongDisplay);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.back);
            this.Controls.Add(this.skip);
            this.Controls.Add(this.search);
            this.Controls.Add(this.title);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sButton);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox search;
        private System.Windows.Forms.PictureBox skip;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView SongDisplay;
        private System.Windows.Forms.Panel header;
    }
}

