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
    class Conversion
    {
        //Convert Folder Functions
        public void ConvertWMVFolder(string rawvidpath, string savevidpath, int framerate, int audiosample, string pixelSize)
        {
            //Get the DirectoryInfo
            DirectoryInfo dir = new DirectoryInfo(rawvidpath);

            //Create an array of videos by getting all the files within the folder
            FileInfo[] vidsToConvert = dir.GetFiles("*");

            foreach (FileInfo vid in vidsToConvert)
            {
                //Convert the video to a new video using the below settings
                var vidconvert = new NReco.VideoConverter.FFMpegConverter();
                vidconvert.ConvertMedia(vid.FullName, null, savevidpath + "\\" + vid.Name + ".wmv", null, new NReco.VideoConverter.ConvertSettings()
                {
                    VideoFrameRate = framerate,
                    VideoFrameSize = pixelSize,
                    AudioSampleRate = audiosample,
                    VideoCodec = "msmpeg4",
                    AudioCodec = "wmav2",
                    //Below setting sontrols quality over file size - the lower the number the higher the quality and filesize
                    CustomOutputArgs = " -qscale 11 "
                });
            }

        }

        public void ConvertMP4Folder(string rawvidpath, string savevidpath, int framerate, int audiosample, string pixelSize)
        {
            //Get the DirectoryInfo
            DirectoryInfo dir = new DirectoryInfo(rawvidpath);

            //Create an array of videos by getting all the files within the folder
            FileInfo[] vidsToConvert = dir.GetFiles("*");

            foreach (FileInfo vid in vidsToConvert)
            {
                //Convert the video to a new video using the below settings
                var vidconvertmp4 = new NReco.VideoConverter.FFMpegConverter();
                vidconvertmp4.ConvertMedia(vid.FullName, null, savevidpath + "\\" + vid.Name + ".mp4", null, new NReco.VideoConverter.ConvertSettings()
                {
                    VideoFrameRate = framerate,
                    VideoFrameSize = pixelSize,
                    AudioSampleRate = audiosample,
                    VideoCodec = "libx264",
                    CustomOutputArgs = " -pix_fmt yuv420p "
                });
            }

        }

        public void ConvertOtherFolder(string rawvidpath, string savevidpath, int framerate, int audiosample, string pixelSize, string extension)
        {
            //Get the DirectoryInfo
            DirectoryInfo dir = new DirectoryInfo(rawvidpath);

            //Create an array of videos by getting all the files within the folder
            FileInfo[] vidsToConvert = dir.GetFiles("*");

            foreach (FileInfo vid in vidsToConvert)
            {
                //Convert the video to a new video using the below settings
                var vidconvertmp4 = new NReco.VideoConverter.FFMpegConverter();
                vidconvertmp4.ConvertMedia(vid.FullName, null, savevidpath + "\\" + vid.Name + extension, null, new NReco.VideoConverter.ConvertSettings()
                {
                    VideoFrameRate = framerate,
                    VideoFrameSize = pixelSize,
                    AudioSampleRate = audiosample
                });
            }
        }

        //Convert File Fucntions
        public void ConvertWMVFiles(FileInfo vidtoConvert, string savevidpath, int framerate, int audiosample, string pixelSize)
        {
            //Convert the video to a new video using the below settings
            var vidconvert = new NReco.VideoConverter.FFMpegConverter();
            vidconvert.ConvertMedia(vidtoConvert.FullName, null, savevidpath + "\\" + vidtoConvert.Name + ".wmv", null, new NReco.VideoConverter.ConvertSettings()
            {
                VideoFrameRate = framerate,
                VideoFrameSize = pixelSize,
                AudioSampleRate = audiosample,
                VideoCodec = "msmpeg4",
                AudioCodec = "wmav2",
                //Below setting sontrols quality over file size - the lower the number the higher the quality and filesize
                CustomOutputArgs = " -qscale 11 "
            });

        }

        public void ConvertMP4Files(FileInfo vidtoConvert, string savevidpath, int framerate, int audiosample, string pixelSize)
        {
            //Convert the video to a new video using the below settings
            var vidconvertmp4 = new NReco.VideoConverter.FFMpegConverter();
            vidconvertmp4.ConvertMedia(vidtoConvert.FullName, null, savevidpath + "\\" + vidtoConvert.Name + ".mp4", null, new NReco.VideoConverter.ConvertSettings()
            {
                VideoFrameRate = framerate,
                VideoFrameSize = pixelSize,
                AudioSampleRate = audiosample,
                VideoCodec = "libx264",
                CustomOutputArgs = " -pix_fmt yuv420p "
            });

        }

        public void ConvertOtherFiles(FileInfo vidtoConvert, string savevidpath, int framerate, int audiosample, string pixelSize, string extension)
        {
            //Convert the video to a new video using the below settings
            var vidconvert = new NReco.VideoConverter.FFMpegConverter();
            vidconvert.ConvertMedia(vidtoConvert.FullName, null, savevidpath + "\\" + vidtoConvert.Name + extension, null, new NReco.VideoConverter.ConvertSettings()
            {
                VideoFrameRate = framerate,
                VideoFrameSize = pixelSize,
                AudioSampleRate = audiosample
            });
        }

        
    }
}
