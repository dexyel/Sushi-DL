namespace Sushi_DL
{
    partial class MainForm
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
            this.titleBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.coverBox = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.genreLabel1 = new System.Windows.Forms.Label();
            this.volumeBox = new System.Windows.Forms.ListBox();
            this.chapterBox = new System.Windows.Forms.ListBox();
            this.genreLabel2 = new System.Windows.Forms.Label();
            this.synopsisLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.combineRadio = new System.Windows.Forms.RadioButton();
            this.chapterRadio = new System.Windows.Forms.RadioButton();
            this.volumeRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.downloadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coverBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.FormattingEnabled = true;
            this.titleBox.ItemHeight = 15;
            this.titleBox.Location = new System.Drawing.Point(12, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(235, 664);
            this.titleBox.TabIndex = 0;
            this.titleBox.SelectedIndexChanged += new System.EventHandler(this.titleBox_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(266, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(352, 34);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "TITLE";
            // 
            // coverBox
            // 
            this.coverBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.coverBox.Location = new System.Drawing.Point(266, 76);
            this.coverBox.Name = "coverBox";
            this.coverBox.Size = new System.Drawing.Size(284, 412);
            this.coverBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverBox.TabIndex = 3;
            this.coverBox.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 682);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Search...";
            this.searchBox.Size = new System.Drawing.Size(235, 23);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tomes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chapitres";
            // 
            // genreLabel1
            // 
            this.genreLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreLabel1.Location = new System.Drawing.Point(685, 9);
            this.genreLabel1.Name = "genreLabel1";
            this.genreLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.genreLabel1.Size = new System.Drawing.Size(174, 25);
            this.genreLabel1.TabIndex = 8;
            this.genreLabel1.Text = "Genre";
            // 
            // volumeBox
            // 
            this.volumeBox.FormattingEnabled = true;
            this.volumeBox.ItemHeight = 15;
            this.volumeBox.Location = new System.Drawing.Point(556, 94);
            this.volumeBox.Name = "volumeBox";
            this.volumeBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.volumeBox.Size = new System.Drawing.Size(146, 394);
            this.volumeBox.TabIndex = 9;
            this.volumeBox.SelectedIndexChanged += new System.EventHandler(this.volumeBox_SelectedIndexChanged);
            // 
            // chapterBox
            // 
            this.chapterBox.FormattingEnabled = true;
            this.chapterBox.ItemHeight = 15;
            this.chapterBox.Location = new System.Drawing.Point(708, 94);
            this.chapterBox.Name = "chapterBox";
            this.chapterBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.chapterBox.Size = new System.Drawing.Size(151, 394);
            this.chapterBox.TabIndex = 10;
            this.chapterBox.SelectedIndexChanged += new System.EventHandler(this.chapterBox_SelectedIndexChanged);
            // 
            // genreLabel2
            // 
            this.genreLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreLabel2.Location = new System.Drawing.Point(685, 34);
            this.genreLabel2.Name = "genreLabel2";
            this.genreLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.genreLabel2.Size = new System.Drawing.Size(174, 25);
            this.genreLabel2.TabIndex = 8;
            this.genreLabel2.Text = "Genre";
            // 
            // synopsisLabel
            // 
            this.synopsisLabel.Location = new System.Drawing.Point(6, 19);
            this.synopsisLabel.Name = "synopsisLabel";
            this.synopsisLabel.Size = new System.Drawing.Size(424, 189);
            this.synopsisLabel.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.synopsisLabel);
            this.groupBox1.Location = new System.Drawing.Point(266, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 211);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Synopsis";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 711);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(690, 32);
            this.progressBar1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.combineRadio);
            this.groupBox2.Controls.Add(this.chapterRadio);
            this.groupBox2.Controls.Add(this.volumeRadio);
            this.groupBox2.Location = new System.Drawing.Point(708, 494);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 99);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // combineRadio
            // 
            this.combineRadio.AutoSize = true;
            this.combineRadio.Location = new System.Drawing.Point(6, 72);
            this.combineRadio.Name = "combineRadio";
            this.combineRadio.Size = new System.Drawing.Size(124, 19);
            this.combineRadio.TabIndex = 0;
            this.combineRadio.TabStop = true;
            this.combineRadio.Text = "Combine Chapters";
            this.combineRadio.UseVisualStyleBackColor = true;
            // 
            // chapterRadio
            // 
            this.chapterRadio.AutoSize = true;
            this.chapterRadio.Location = new System.Drawing.Point(6, 47);
            this.chapterRadio.Name = "chapterRadio";
            this.chapterRadio.Size = new System.Drawing.Size(137, 19);
            this.chapterRadio.TabIndex = 0;
            this.chapterRadio.TabStop = true;
            this.chapterRadio.Text = "Download Chapter(s)";
            this.chapterRadio.UseVisualStyleBackColor = true;
            // 
            // volumeRadio
            // 
            this.volumeRadio.AutoSize = true;
            this.volumeRadio.Location = new System.Drawing.Point(6, 22);
            this.volumeRadio.Name = "volumeRadio";
            this.volumeRadio.Size = new System.Drawing.Size(135, 19);
            this.volumeRadio.TabIndex = 0;
            this.volumeRadio.TabStop = true;
            this.volumeRadio.Text = "Download Volume(s)";
            this.volumeRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(708, 599);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 106);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Format";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(95, 72);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(47, 19);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "PDF";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 72);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 19);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "EPUB";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(95, 22);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 19);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "RAR";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(95, 47);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(43, 19);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "ZIP";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "CBZ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "CBR";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(708, 711);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(151, 32);
            this.downloadButton.TabIndex = 15;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 750);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chapterBox);
            this.Controls.Add(this.volumeBox);
            this.Controls.Add(this.genreLabel2);
            this.Controls.Add(this.genreLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.coverBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coverBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox titleBox;
        private Label titleLabel;
        private PictureBox coverBox;
        private TextBox searchBox;
        private Label label1;
        private Label label2;
        private Label genreLabel1;
        private ListBox volumeBox;
        private ListBox chapterBox;
        private Label genreLabel2;
        private Label synopsisLabel;
        private GroupBox groupBox1;
        private ProgressBar progressBar1;
        private GroupBox groupBox2;
        private RadioButton combineRadio;
        private RadioButton chapterRadio;
        private RadioButton volumeRadio;
        private GroupBox groupBox3;
        private CheckBox checkBox5;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button downloadButton;
    }
}