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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVidLocation = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw Video Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Save Video Location";
            // 
            // tbVidLocation
            // 
            this.tbVidLocation.Location = new System.Drawing.Point(13, 56);
            this.tbVidLocation.Name = "tbVidLocation";
            this.tbVidLocation.ReadOnly = true;
            this.tbVidLocation.Size = new System.Drawing.Size(254, 20);
            this.tbVidLocation.TabIndex = 2;
            // 
            // tbSaveVidLocation
            // 
            this.tbSaveVidLocation.Location = new System.Drawing.Point(13, 130);
            this.tbSaveVidLocation.Name = "tbSaveVidLocation";
            this.tbSaveVidLocation.ReadOnly = true;
            this.tbSaveVidLocation.Size = new System.Drawing.Size(254, 20);
            this.tbSaveVidLocation.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(273, 294);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSetVidLocation
            // 
            this.btnSetVidLocation.Location = new System.Drawing.Point(273, 54);
            this.btnSetVidLocation.Name = "btnSetVidLocation";
            this.btnSetVidLocation.Size = new System.Drawing.Size(75, 23);
            this.btnSetVidLocation.TabIndex = 5;
            this.btnSetVidLocation.Text = "Browse";
            this.btnSetVidLocation.UseVisualStyleBackColor = true;
            this.btnSetVidLocation.Click += new System.EventHandler(this.btnSetVidLocation_Click);
            // 
            // btnSetSaveLocation
            // 
            this.btnSetSaveLocation.Location = new System.Drawing.Point(273, 128);
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
            this.label3.Location = new System.Drawing.Point(13, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Frame Rate";
            // 
            // tbFrameRate
            // 
            this.tbFrameRate.Location = new System.Drawing.Point(81, 169);
            this.tbFrameRate.MaxLength = 2;
            this.tbFrameRate.Name = "tbFrameRate";
            this.tbFrameRate.Size = new System.Drawing.Size(35, 20);
            this.tbFrameRate.TabIndex = 8;
            this.tbFrameRate.Text = "25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Audio Sample Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pixel Size";
            // 
            // tbAudioSample
            // 
            this.tbAudioSample.Location = new System.Drawing.Point(116, 201);
            this.tbAudioSample.MaxLength = 5;
            this.tbAudioSample.Name = "tbAudioSample";
            this.tbAudioSample.Size = new System.Drawing.Size(55, 20);
            this.tbAudioSample.TabIndex = 11;
            this.tbAudioSample.Text = "48000";
            // 
            // rbhd480
            // 
            this.rbhd480.AutoSize = true;
            this.rbhd480.Location = new System.Drawing.Point(72, 236);
            this.rbhd480.Name = "rbhd480";
            this.rbhd480.Size = new System.Drawing.Size(66, 17);
            this.rbhd480.TabIndex = 12;
            this.rbhd480.Text = "852x480";
            this.rbhd480.UseVisualStyleBackColor = true;
            // 
            // rbhd720
            // 
            this.rbhd720.AutoSize = true;
            this.rbhd720.Location = new System.Drawing.Point(144, 236);
            this.rbhd720.Name = "rbhd720";
            this.rbhd720.Size = new System.Drawing.Size(72, 17);
            this.rbhd720.TabIndex = 13;
            this.rbhd720.Text = "1280x720";
            this.rbhd720.UseVisualStyleBackColor = true;
            // 
            // rbhd1080
            // 
            this.rbhd1080.AutoSize = true;
            this.rbhd1080.Checked = true;
            this.rbhd1080.Location = new System.Drawing.Point(222, 236);
            this.rbhd1080.Name = "rbhd1080";
            this.rbhd1080.Size = new System.Drawing.Size(78, 17);
            this.rbhd1080.TabIndex = 14;
            this.rbhd1080.TabStop = true;
            this.rbhd1080.Text = "1920x1080";
            this.rbhd1080.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 329);
            this.Controls.Add(this.rbhd1080);
            this.Controls.Add(this.rbhd720);
            this.Controls.Add(this.rbhd480);
            this.Controls.Add(this.tbAudioSample);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFrameRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSetSaveLocation);
            this.Controls.Add(this.btnSetVidLocation);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbSaveVidLocation);
            this.Controls.Add(this.tbVidLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVidLocation;
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
    }
}

