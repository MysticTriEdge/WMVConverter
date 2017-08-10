namespace WMVConverter
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
            this.tbSaveVidLocation = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSetVidLocation = new System.Windows.Forms.Button();
            this.btnSetSaveLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFrameRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAudioSample = new System.Windows.Forms.TextBox();
            this.rbhd480 = new System.Windows.Forms.RadioButton();
            this.rbhd720 = new System.Windows.Forms.RadioButton();
            this.rbhd1080 = new System.Windows.Forms.RadioButton();
            this.cbxMP4 = new System.Windows.Forms.CheckBox();
            this.cbxWMV = new System.Windows.Forms.CheckBox();
            this.cbxWholeFolder = new System.Windows.Forms.RadioButton();
            this.cbxFiles = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbVidLocation = new System.Windows.Forms.TextBox();
            this.lbxVideostoConvert = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbOtherExt = new System.Windows.Forms.TextBox();
            this.cbxOther = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbOriginal = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSaveVidLocation
            // 
            this.tbSaveVidLocation.Location = new System.Drawing.Point(6, 19);
            this.tbSaveVidLocation.Name = "tbSaveVidLocation";
            this.tbSaveVidLocation.ReadOnly = true;
            this.tbSaveVidLocation.Size = new System.Drawing.Size(254, 20);
            this.tbSaveVidLocation.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(280, 378);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSetVidLocation
            // 
            this.btnSetVidLocation.Location = new System.Drawing.Point(266, 43);
            this.btnSetVidLocation.Name = "btnSetVidLocation";
            this.btnSetVidLocation.Size = new System.Drawing.Size(75, 23);
            this.btnSetVidLocation.TabIndex = 5;
            this.btnSetVidLocation.Text = "Browse";
            this.btnSetVidLocation.UseVisualStyleBackColor = true;
            this.btnSetVidLocation.Click += new System.EventHandler(this.btnSetVidLocation_Click);
            // 
            // btnSetSaveLocation
            // 
            this.btnSetSaveLocation.Location = new System.Drawing.Point(266, 19);
            this.btnSetSaveLocation.Name = "btnSetSaveLocation";
            this.btnSetSaveLocation.Size = new System.Drawing.Size(75, 23);
            this.btnSetSaveLocation.TabIndex = 6;
            this.btnSetSaveLocation.Text = "Browse";
            this.btnSetSaveLocation.UseVisualStyleBackColor = true;
            this.btnSetSaveLocation.Click += new System.EventHandler(this.btnSetSaveLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Frame Rate";
            // 
            // tbFrameRate
            // 
            this.tbFrameRate.Location = new System.Drawing.Point(78, 19);
            this.tbFrameRate.MaxLength = 2;
            this.tbFrameRate.Name = "tbFrameRate";
            this.tbFrameRate.Size = new System.Drawing.Size(35, 20);
            this.tbFrameRate.TabIndex = 8;
            this.tbFrameRate.Text = "25";
            this.tbFrameRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFrameRate_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Audio Sample Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pixel Size:";
            // 
            // tbAudioSample
            // 
            this.tbAudioSample.Location = new System.Drawing.Point(113, 51);
            this.tbAudioSample.MaxLength = 5;
            this.tbAudioSample.Name = "tbAudioSample";
            this.tbAudioSample.Size = new System.Drawing.Size(55, 20);
            this.tbAudioSample.TabIndex = 11;
            this.tbAudioSample.Text = "48000";
            // 
            // rbhd480
            // 
            this.rbhd480.AutoSize = true;
            this.rbhd480.Location = new System.Drawing.Point(68, 86);
            this.rbhd480.Name = "rbhd480";
            this.rbhd480.Size = new System.Drawing.Size(66, 17);
            this.rbhd480.TabIndex = 12;
            this.rbhd480.Text = "852x480";
            this.rbhd480.UseVisualStyleBackColor = true;
            // 
            // rbhd720
            // 
            this.rbhd720.AutoSize = true;
            this.rbhd720.Location = new System.Drawing.Point(137, 86);
            this.rbhd720.Name = "rbhd720";
            this.rbhd720.Size = new System.Drawing.Size(72, 17);
            this.rbhd720.TabIndex = 13;
            this.rbhd720.Text = "1280x720";
            this.rbhd720.UseVisualStyleBackColor = true;
            // 
            // rbhd1080
            // 
            this.rbhd1080.AutoSize = true;
            this.rbhd1080.Location = new System.Drawing.Point(215, 86);
            this.rbhd1080.Name = "rbhd1080";
            this.rbhd1080.Size = new System.Drawing.Size(78, 17);
            this.rbhd1080.TabIndex = 14;
            this.rbhd1080.Text = "1920x1080";
            this.rbhd1080.UseVisualStyleBackColor = true;
            // 
            // cbxMP4
            // 
            this.cbxMP4.AutoSize = true;
            this.cbxMP4.Checked = true;
            this.cbxMP4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMP4.Location = new System.Drawing.Point(6, 45);
            this.cbxMP4.Name = "cbxMP4";
            this.cbxMP4.Size = new System.Drawing.Size(48, 17);
            this.cbxMP4.TabIndex = 15;
            this.cbxMP4.Text = "MP4";
            this.cbxMP4.UseVisualStyleBackColor = true;
            // 
            // cbxWMV
            // 
            this.cbxWMV.AutoSize = true;
            this.cbxWMV.Checked = true;
            this.cbxWMV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxWMV.Location = new System.Drawing.Point(54, 45);
            this.cbxWMV.Name = "cbxWMV";
            this.cbxWMV.Size = new System.Drawing.Size(53, 17);
            this.cbxWMV.TabIndex = 16;
            this.cbxWMV.Text = "WMV";
            this.cbxWMV.UseVisualStyleBackColor = true;
            // 
            // cbxWholeFolder
            // 
            this.cbxWholeFolder.AutoSize = true;
            this.cbxWholeFolder.Checked = true;
            this.cbxWholeFolder.Location = new System.Drawing.Point(6, 22);
            this.cbxWholeFolder.Name = "cbxWholeFolder";
            this.cbxWholeFolder.Size = new System.Drawing.Size(121, 17);
            this.cbxWholeFolder.TabIndex = 17;
            this.cbxWholeFolder.TabStop = true;
            this.cbxWholeFolder.Text = "Select Whole Folder";
            this.cbxWholeFolder.UseVisualStyleBackColor = true;
            this.cbxWholeFolder.CheckedChanged += new System.EventHandler(this.cbxWholeFolder_CheckedChanged);
            // 
            // cbxFiles
            // 
            this.cbxFiles.AutoSize = true;
            this.cbxFiles.Location = new System.Drawing.Point(137, 22);
            this.cbxFiles.Name = "cbxFiles";
            this.cbxFiles.Size = new System.Drawing.Size(74, 17);
            this.cbxFiles.TabIndex = 18;
            this.cbxFiles.Text = "Select File";
            this.cbxFiles.UseVisualStyleBackColor = true;
            this.cbxFiles.CheckedChanged += new System.EventHandler(this.cbxFiles_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbVidLocation);
            this.groupBox1.Controls.Add(this.lbxVideostoConvert);
            this.groupBox1.Controls.Add(this.cbxFiles);
            this.groupBox1.Controls.Add(this.cbxWholeFolder);
            this.groupBox1.Controls.Add(this.btnSetVidLocation);
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 147);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Video\'s to Convert";
            // 
            // tbVidLocation
            // 
            this.tbVidLocation.Location = new System.Drawing.Point(6, 45);
            this.tbVidLocation.Name = "tbVidLocation";
            this.tbVidLocation.ReadOnly = true;
            this.tbVidLocation.Size = new System.Drawing.Size(250, 20);
            this.tbVidLocation.TabIndex = 20;
            // 
            // lbxVideostoConvert
            // 
            this.lbxVideostoConvert.Enabled = false;
            this.lbxVideostoConvert.FormattingEnabled = true;
            this.lbxVideostoConvert.Location = new System.Drawing.Point(5, 45);
            this.lbxVideostoConvert.Name = "lbxVideostoConvert";
            this.lbxVideostoConvert.Size = new System.Drawing.Size(191, 95);
            this.lbxVideostoConvert.TabIndex = 19;
            this.lbxVideostoConvert.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOtherExt);
            this.groupBox2.Controls.Add(this.cbxOther);
            this.groupBox2.Controls.Add(this.cbxWMV);
            this.groupBox2.Controls.Add(this.cbxMP4);
            this.groupBox2.Controls.Add(this.btnSetSaveLocation);
            this.groupBox2.Controls.Add(this.tbSaveVidLocation);
            this.groupBox2.Location = new System.Drawing.Point(7, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 71);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Save Location";
            // 
            // tbOtherExt
            // 
            this.tbOtherExt.Location = new System.Drawing.Point(273, 43);
            this.tbOtherExt.MaxLength = 5;
            this.tbOtherExt.Name = "tbOtherExt";
            this.tbOtherExt.Size = new System.Drawing.Size(60, 20);
            this.tbOtherExt.TabIndex = 19;
            this.tbOtherExt.Text = ".";
            this.tbOtherExt.Visible = false;
            this.tbOtherExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOtherExt_KeyPress);
            // 
            // cbxOther
            // 
            this.cbxOther.AutoSize = true;
            this.cbxOther.Location = new System.Drawing.Point(144, 45);
            this.cbxOther.Name = "cbxOther";
            this.cbxOther.Size = new System.Drawing.Size(132, 17);
            this.cbxOther.TabIndex = 17;
            this.cbxOther.Text = "Other(Must start with .)";
            this.cbxOther.UseVisualStyleBackColor = true;
            this.cbxOther.CheckedChanged += new System.EventHandler(this.cbxOther_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOriginal);
            this.groupBox3.Controls.Add(this.tbAudioSample);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rbhd1080);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.rbhd720);
            this.groupBox3.Controls.Add(this.tbFrameRate);
            this.groupBox3.Controls.Add(this.rbhd480);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(7, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 131);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Variables";
            // 
            // rbOriginal
            // 
            this.rbOriginal.AutoSize = true;
            this.rbOriginal.Checked = true;
            this.rbOriginal.Location = new System.Drawing.Point(68, 108);
            this.rbOriginal.Name = "rbOriginal";
            this.rbOriginal.Size = new System.Drawing.Size(111, 17);
            this.rbOriginal.TabIndex = 15;
            this.rbOriginal.TabStop = true;
            this.rbOriginal.Text = "Keep Original Size";
            this.rbOriginal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Video Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbSaveVidLocation;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSetVidLocation;
        private System.Windows.Forms.Button btnSetSaveLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFrameRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAudioSample;
        private System.Windows.Forms.RadioButton rbhd480;
        private System.Windows.Forms.RadioButton rbhd720;
        private System.Windows.Forms.RadioButton rbhd1080;
        private System.Windows.Forms.CheckBox cbxMP4;
        private System.Windows.Forms.CheckBox cbxWMV;
        private System.Windows.Forms.RadioButton cbxWholeFolder;
        private System.Windows.Forms.RadioButton cbxFiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbxVideostoConvert;
        private System.Windows.Forms.TextBox tbVidLocation;
        private System.Windows.Forms.TextBox tbOtherExt;
        private System.Windows.Forms.CheckBox cbxOther;
        private System.Windows.Forms.RadioButton rbOriginal;
    }
}

