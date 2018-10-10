using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using ModelLibrary.Models.Set;
using ModelLibrary.Models.Topic;

namespace FileHandlerLibrary.FileHandlers
{
    public static class GenerateThumbnails
    {
        public static string[] ReturnThumbnailList(string path, string setName, string topicName)
        {
            path = Path.Combine(path, setName, topicName, "Videos", "Thumbnails");
            return Directory.GetFiles(path, "*.jpg");
        }

        public static void CreateSingleThumbnail(string homepath, string setName, string topicName, string videoPath)
        {

            //Thumb folder (save location)
            string topicfolder = Path.Combine(homepath, setName, topicName, "Videos", "Thumbnails");
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();

            string oldImage = "";
            //If thumbnail doesn't exist, extract frame from video with a 'D' prefix
            if (!File.Exists(topicfolder + @"\" + Path.GetFileNameWithoutExtension(videoPath) + ".jpg"))
                {
                    ffMpeg.GetVideoThumbnail(videoPath, topicfolder + @"\D" + Path.GetFileNameWithoutExtension(videoPath) + ".jpg", 5);
                    oldImage = topicfolder + @"\D" + Path.GetFileNameWithoutExtension(videoPath) + ".jpg";
                }

            if (oldImage != "")
            {
                Bitmap newImage = new Bitmap(260, 130);
                using (Graphics gr = Graphics.FromImage(newImage))
                {
                    gr.SmoothingMode = SmoothingMode.HighQuality;
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    using (Image img = Image.FromFile(oldImage))
                    {
                        gr.DrawImage(img, new Rectangle(0, 0, 260, 130));
                    }
                }
                var newfilename = Path.Combine(topicfolder, Path.GetFileNameWithoutExtension(oldImage).Remove(0, 1) + ".jpg"); //Generate filename without .ext
                newImage.Save(@newfilename, ImageFormat.Jpeg); //Save small thumbnail
                File.Delete(oldImage);
            }


        }
        
        public static void CreateThumbnailsForAllTopics(string path, SetModel setModel) 
        {
            foreach (TopicModel topicModel in setModel.SetTopics)
            {
                CreateThumbnails(path, setModel.SetName, topicModel.TopicName);
            }
        }


        public static void CreateThumbnails(string homepath, string setName, string topicName) {
            
            //Get videos in topic folder
            homepath = Path.Combine(homepath, setName, topicName, "Videos");
            var extensions = new List<string> {".mp4", ".avi" };
            var videos = Directory.GetFiles(homepath, "*.mp4", SearchOption.TopDirectoryOnly);


            //Thumb folder (save location)
            string topicfolder = Path.Combine(homepath, "Thumbnails");            
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            

            //Generate original size thumbnails from existing videos and save them to /Thumbnails dir
            foreach (var video in videos)
            {
                if (!File.Exists(topicfolder + @"\" + Path.GetFileNameWithoutExtension(video) + ".jpg"))
                {
                    ffMpeg.GetVideoThumbnail(video, topicfolder + @"\D" + Path.GetFileNameWithoutExtension(video) + ".jpg", 5);
                }
            }


            //Generate small thumbnails
            List<string> oldImages = new List<string>();

            foreach (string image in Directory.GetFiles(topicfolder, "*.jpg"))
            {
                oldImages.Add(image);
                Bitmap newImage = new Bitmap(260, 130);
                using (Graphics gr = Graphics.FromImage(newImage))
                {
                    gr.SmoothingMode = SmoothingMode.HighQuality;
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    using (Image img = Image.FromFile(image))
                    {
                        gr.DrawImage(img, new Rectangle(0, 0, 260, 130));
                    }
                }
                var newfilename = Path.Combine(topicfolder, Path.GetFileNameWithoutExtension(image).Remove(0, 1) + ".jpg"); //Generate filename without .ext
                newImage.Save(@newfilename, ImageFormat.Jpeg); //Save small thumbnail
            }

            //Delete old images
            foreach (string image in oldImages)
            {
                File.Delete(image);
            }
        }
    }
}
