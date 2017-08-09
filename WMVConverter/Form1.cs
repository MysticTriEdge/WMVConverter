using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco;
using System.IO;
using System.Reflection;

namespace WMVConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetVidLocation_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                tbVidLocation.Text = fbd.SelectedPath.ToString();
            }
        }

        private void btnSetSaveLocation_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                tbSaveVidLocation.Text = fbd.SelectedPath.ToString();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertWMV(tbVidLocation.Text, tbSaveVidLocation.Text);
        }

        private void ConvertWMV (string rawvidpath, string savevidpath)
        {
            DirectoryInfo dir = new DirectoryInfo(rawvidpath);

            FileInfo[] vidsToConvert = dir.GetFiles("*");

            foreach(FileInfo vid in vidsToConvert)
            {
                var vidconvertmp4 = new NReco.VideoConverter.FFMpegConverter();
                vidconvertmp4.ConvertMedia(vid.FullName, null,  savevidpath + "\\" + vid.Name + ".mp4", null, new NReco.VideoConverter.ConvertSettings()
                {
                    VideoFrameRate = 25,
                    VideoFrameSize = "hd1080",
                    AudioSampleRate = 48000,
                    VideoCodec = "libx264",
                    CustomOutputArgs = " -pix_fmt yuv420p "
                });

                var vidconvert = new NReco.VideoConverter.FFMpegConverter();
                vidconvert.ConvertMedia(vid.FullName, null, savevidpath + "\\" + vid.Name + ".wmv", null, new NReco.VideoConverter.ConvertSettings() {
                    VideoFrameRate = 25,
                    VideoFrameSize = "hd1080",
                    AudioSampleRate = 48000,
                    VideoCodec = "msmpeg4",
                    AudioCodec = "wmav2",
                    //Below setting sontrols quality over file size - the lower the number the higher the quality and filesize
                    CustomOutputArgs = " -qscale 11 "
                });
            }

            MessageBox.Show("Finished", "Finished", MessageBoxButtons.OK);
            
        }
    }
}
