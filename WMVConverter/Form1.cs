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

        //Create a list to store the selected video files to convert on the file selection
        List<FileInfo> vids = new List<FileInfo>();

        //Add reference for the code in the other classes
        Conversion runConvert = new Conversion();
        View viewControl = new View();

        private void btnSetVidLocation_Click(object sender, EventArgs e)
        {
            //If whole folder radio button is selected open a folderbrowser dialog and get the folder path. The display in the textbox.
            if (cbxWholeFolder.Checked == true)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    tbVidLocation.Text = fbd.SelectedPath.ToString();
                }
            }
            //Otherwise if file radio button is selected open a filebrowser dialog and get a list of files. Then display in the listbox.
            else if (cbxFiles.Checked == true)
            {
                using (var fbd = new OpenFileDialog())
                {
                    //List of acceptable file extensions. Can add more following the same format as below
                    fbd.Filter = "All Videos Files |*.wmv; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.flv; *.gxf; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                  " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.ogg; *.ogm; *.webm";
                    fbd.FilterIndex = 1;
                    //Allow multiple files to be selected
                    fbd.Multiselect = true;
                    
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        //Loop through the selected files from the filebrowser
                        foreach (string vidname in fbd.FileNames)
                        {
                            //Get the info of the video
                            FileInfo vid = new FileInfo(vidname);
                            //Add video to the list
                            vids.Add(vid);
                            //Add video name to the listbox
                            lbxVideostoConvert.Items.Add(vid.Name);

                            
                        }

                        
                    }

                }
            }
        }

        private void btnSetSaveLocation_Click(object sender, EventArgs e)
        {
            //Get the folder path and display in the textbox
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                tbSaveVidLocation.Text = fbd.SelectedPath.ToString();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //If no extension then display error message
            if (cbxMP4.Checked == false && cbxWMV.Checked == false && cbxOther.Checked == false)
            {
                MessageBox.Show("Extension must be selected","Error", MessageBoxButtons.OK);
            }

            //If other is selected display message box asking for confirmation that the other textbox has the right extension
            else if(cbxOther.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("You have selected other. If the extension is not correct the conversion will fail." + Environment.NewLine + "Do you wish to continue?", "Confirm Start?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Run the variables and programme
                    getVariablesAndRun();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //Do nothing which will take the programme back to the start
                }
            }

            //If cbxOther is not selected run the programme as there is no issue with file extension
            else if (cbxOther.Checked == false)
            {
                getVariablesAndRun();
            }
            
        }

        private void getVariablesAndRun ()
        {
            //Collect the variables from the inputs
            int framerate = Convert.ToInt32(tbFrameRate.Text);
            int audioSample = Convert.ToInt32(tbAudioSample.Text);
            string vidLocation = tbVidLocation.Text;
            string vidSaveLocation = tbSaveVidLocation.Text;
            string pixelsize = "";
            string ext = tbOtherExt.Text;

            if (rbhd480.Checked == true)
            {
                pixelsize = "hd480";
            }
            else if (rbhd720.Checked == true)
            {
                pixelsize = "hd720";
            }
            else if (rbhd1080.Checked == true)
            {
                pixelsize = "hd1080";
            }
            else if (rbOriginal.Checked == true)
            {
                pixelsize = null;
            }

            try
            {
                //Run function depending on what format needed and if its for a whole folder 
                if (cbxWholeFolder.Checked == true)
            {
                if (cbxWMV.Checked == true)
                {
                    runConvert.ConvertWMVFolder(vidLocation, vidSaveLocation, framerate, audioSample, pixelsize);
                }

                if (cbxMP4.Checked == true)
                {
                    runConvert.ConvertMP4Folder(vidLocation, vidSaveLocation, framerate, audioSample, pixelsize);
                }

                if (cbxOther.Checked == true)
                {
                    runConvert.ConvertOtherFolder(vidLocation, vidSaveLocation, framerate, audioSample, pixelsize, ext);
                }

                    viewControl.finishedMessageBox();
                    vids.Clear();
            }


                //Run function depending on what format needed and if its on specific files
                if (cbxFiles.Checked == true)
                {
                    if (cbxWMV.Checked == true)
                    {
                        foreach (FileInfo vid in vids)
                        {
                            runConvert.ConvertWMVFiles(vid, vidSaveLocation, framerate, audioSample, pixelsize);
                        }
                    }

                    if (cbxMP4.Checked == true)
                    {
                        foreach (FileInfo vid in vids)
                        {
                            runConvert.ConvertMP4Files(vid, vidSaveLocation, framerate, audioSample, pixelsize);
                        }
                    }

                    if (cbxOther.Checked == true)
                    {
                        foreach (FileInfo vid in vids)
                        {
                            runConvert.ConvertOtherFiles(vid, vidSaveLocation, framerate, audioSample, pixelsize, ext);
                        }
                    }
                    viewControl.finishedMessageBox();
                    vids.Clear();
                }
            }
            //If there is an error then display the error with its exception message
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK);
            }

        }

        private void tbFrameRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow numbers to be allowed in the textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbxFiles_CheckedChanged(object sender, EventArgs e)
        {
            //If the cbxFiles is checked hide the folderpath textbox and show the list of selected videos
            if(cbxFiles.Checked == true)
            {
                tbVidLocation.Visible = false;
                lbxVideostoConvert.Visible = true;
            }
        }

        private void cbxWholeFolder_CheckedChanged(object sender, EventArgs e)
        {
            //If the cbxWholeFolder is selected then hide the listbox of files and show the folder path textbox
            tbVidLocation.Visible = true;
            lbxVideostoConvert.Visible = false;
        }

        

        private void cbxOther_CheckedChanged(object sender, EventArgs e)
        {
            //Depending if the cbxOther is checked or not show or hide the extension textbox
            if (cbxOther.Checked == true)
            {
                tbOtherExt.Visible = true;
            }
            if (cbxOther.Checked == false)
            {
                tbOtherExt.Visible = false;
            }
        }

        private void tbOtherExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow letters and fullstops to be added to the textbox
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.');
        }

    }

}
