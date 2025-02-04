using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeVideos
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _lenght;
        private List<Comment> _comments;

        public Video(string title, string author, int lenght)
        {
            _title = title;
            _author = author;
            _lenght = lenght;
        }

        
    }
}