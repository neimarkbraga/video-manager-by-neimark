using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using NReco.VideoConverter;
using System.Web.Script.Serialization;
using System.Drawing;

namespace Video_Manager_By_Neimark
{
    public class Video
    {
        public FileInfo VideoFile;
        public VideoInfo Info;
        public Image TemporaryImage = null;

        public Video(FileInfo VideoFile, VideoInfo Info)
        {
            this.VideoFile = VideoFile;
            this.Info = Info;
        }

        public Video Clone()
        {
            Video v = (Video)MemberwiseClone();
            v.Info = Info.Clone();
            return v;
        }

        public string getThumbnailFullName()
        {
            return VideoFile.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(VideoFile.FullName) + "_THUMBNAIL.jpg";
        }

        public string getInfoFullName()
        {
            return VideoFile.DirectoryName + "\\" + Path.GetFileNameWithoutExtension(VideoFile.FullName) + "_INFO.json";
        }

        public void createThumbnail()
        {
            int totalsec = Info.getTotalSeconds();
            if (totalsec > 0)
            {
                Random rand = new Random();
                double half = totalsec / 2;
                int sec = (int)Math.Ceiling(half);
                if (totalsec > 50)
                    sec = rand.Next(45, (int)Math.Ceiling(half));
                FFMpegConverter ffmpeg = new FFMpegConverter();
                ffmpeg.GetVideoThumbnail(VideoFile.FullName, getThumbnailFullName(), sec);
            }   
        }

        public void createThumbnail(Image img)
        {
            img.Save(getThumbnailFullName());
            File.SetAttributes(getThumbnailFullName(), FileAttributes.Hidden);
        }

        public void saveInfo()
        {
            if (new FileInfo(getInfoFullName()).Exists)
                File.SetAttributes(getInfoFullName(), FileAttributes.Normal);
            File.WriteAllText(getInfoFullName(), new JavaScriptSerializer().Serialize(Info));
            File.SetAttributes(getInfoFullName(), FileAttributes.Hidden);
        }

        public ListViewItem createListViewItemCompleteInfo()
        {
            ListViewItem l = new ListViewItem(Info.Title);
            l.SubItems.Add(Info.Year.ToString());
            l.SubItems.Add(Info.getResolutionString());
            l.SubItems.Add(Info.getDurationString());
            l.SubItems.Add(Info.getGenreString());
            return l;
        }
    }

    public class VideoInfo
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Genre { get; set; }
        public int Year { get; set; }
        public int Resolution { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int DurationHour { get; set; }
        public int DurationMinute { get; set; }
        public int DurationSecond { get; set; }

        public VideoInfo()
        {
            Title = "";
            Description = "";
            Genre = new List<string>();
            Year = 0;
            Resolution = 0;
            Height = 0;
            Width = 0;
            DurationHour = 0;
            DurationMinute = 0;
            DurationSecond = 0;
        }

        public VideoInfo Clone()
        {
            return (VideoInfo)MemberwiseClone();
        }

        private string doublizeDigit(int number)
        {
            string doubled = number.ToString();
            return (doubled.Length > 1) ? doubled : "0" + doubled;
        }

        public string getResolutionString()
        {
            return Resolution + "p";
        }

        public string getDurationString()
        {
            return doublizeDigit(DurationHour) + ":" + doublizeDigit(DurationMinute) + ":" + doublizeDigit(DurationSecond);
        }

        public string getGenreString()
        {
            string genres = "";
            foreach (string genre in Genre)
                genres += genre + ", ";
            if (genres.Length > 1)
                return genres.Substring(0, genres.Length - 2);
            return genres;
        }

        public string getDimensionString()
        {
            return Width + "x" + Height;
        }

        public int getTotalSeconds()
        {
            return (DurationSecond) + (DurationMinute * 60) + (DurationHour * 3600);
        }

        public int getGuessResolution()
        {
            if (Height <= 240)
                return 240;
            if (Height <= 360)
                return 360;
            if (Height <= 480)
                return 480;
            if (Height <= 720)
                return 720;
            return 1080;
        }
    }

    public static class myTools
    {
        public static int GetRandomFrame(int totalsec)
            {
                int sec = 0;
                if (totalsec > 0)
                {
                    Random rand = new Random();
                    double half = totalsec / 2;
                    sec = (int)Math.Ceiling(half);
                    if (totalsec > 50)
                        sec = rand.Next(45, (int)Math.Ceiling(half));
                }
                return sec;
            }
    }

    class ListViewItemStringComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemStringComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemStringComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            if (order == SortOrder.Descending)
                returnVal *= -1;
            return returnVal;
        }
    }
}