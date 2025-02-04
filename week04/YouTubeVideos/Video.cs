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
            _comments = new List<Comment>();
        }

        public string GetTitle()
        {
            return _title;
        }
        public string GetAuthor()
        {
            return _author;
            
        }

        public int GetLength()
        {
            return _lenght;
        }
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return _comments.Count;
        }
        
    }
}