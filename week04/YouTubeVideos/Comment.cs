using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeVideos
{
    public class Comment
    {
        private string _commenterName;
        private string _commentText;
        
        public Comment(string commenterName, string commentText)
        {
            _commenterName = commenterName;
            _commentText = commentText;
        }

        public string GetCommenterName()
        {
            return _commenterName;
        }

        public string GetCommentText()
        {
            return _commentText;
        }

    }
}