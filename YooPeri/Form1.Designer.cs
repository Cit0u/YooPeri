namespace YooPeri
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
            BtDow = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Audio = new ComboBox();
            Video = new ComboBox();
            Link = new TextBox();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // BtDow
            // 
            BtDow.Anchor = AnchorStyles.None;
            BtDow.AutoSize = true;
            BtDow.BackColor = Color.FromArgb(192, 255, 192);
            BtDow.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtDow.Location = new Point(662, 541);
            BtDow.Name = "BtDow";
            BtDow.Size = new Size(194, 68);
            BtDow.TabIndex = 0;
            BtDow.Text = "Download";
            BtDow.UseVisualStyleBackColor = false;
            BtDow.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Background_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(1106, -5);
            pictureBox1.Margin = new Padding(3, 3, 1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 848);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImage = Properties.Resources.PeriYooElegan;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(398, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(786, 197);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Audio
            // 
            Audio.Anchor = AnchorStyles.None;
            Audio.DropDownStyle = ComboBoxStyle.DropDownList;
            Audio.FormattingEnabled = true;
            Audio.Items.AddRange(new object[] { "160 kbps", "70 kbps", "50 kbps", "No" });
            Audio.Location = new Point(224, 514);
            Audio.Name = "Audio";
            Audio.Size = new Size(174, 23);
            Audio.TabIndex = 6;
            Audio.Tag = "";
            Audio.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Video
            // 
            Video.Anchor = AnchorStyles.None;
            Video.DropDownStyle = ComboBoxStyle.DropDownList;
            Video.FormattingEnabled = true;
            Video.Items.AddRange(new object[] { "2160p (4K)", "1440p (2K)", "1080p", "720p", "480p", "360p", "240p", "144p", "No" });
            Video.Location = new Point(1062, 514);
            Video.Name = "Video";
            Video.Size = new Size(174, 23);
            Video.TabIndex = 6;
            Video.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Link
            // 
            Link.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Link.BackColor = Color.FromArgb(192, 255, 192);
            Link.ForeColor = SystemColors.WindowText;
            Link.Location = new Point(595, 327);
            Link.Name = "Link";
            Link.Size = new Size(322, 23);
            Link.TabIndex = 7;
            Link.TextAlign = HorizontalAlignment.Center;
            Link.TextChanged += Link_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 440);
            label1.Name = "label1";
            label1.Size = new Size(115, 41);
            label1.TabIndex = 8;
            label1.Text = "Audio";
            label1.Click += label1_Click_2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Forte", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1106, 440);
            label2.Name = "label2";
            label2.Size = new Size(104, 41);
            label2.TabIndex = 8;
            label2.Text = "Video";
            label2.Click += label1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1448, 844);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Link);
            Controls.Add(Video);
            Controls.Add(Audio);
            Controls.Add(pictureBox2);
            Controls.Add(BtDow);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtDow;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox Audio;
        private ComboBox Video;
        private TextBox Link;
        private Label label1;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
