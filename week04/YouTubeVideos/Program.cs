using System;
using System.Collections.Generic;

namespace YouTubeVideos
{    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new("C# tutoriral", "Brighton Dube", 300);
            Video video2 = new("Advanced c# tutorial", "Brighton Dube", 420);
            Video video3 = new("How to make money coding", "Brighton Dube", 275);

            video1.AddComment(new Comment("Zoe","This is a great video." ));
            video1.AddComment(new Comment("Jon", "Your tutorials are always helpful, thank you for providing such great content."));
            video1.AddComment(new Comment("Don","I'm always looking forward to your new videos."));

            video2.AddComment(new Comment("David", "Good explanation."));
            video2.AddComment(new Comment("Eve", "Please make more videos like this."));
            video2.AddComment(new Comment("Frank", "Well done!"));
            video3.AddComment(new Comment("Grace", "This is very informative."));
            video3.AddComment(new Comment("Henry", "Can you explain this further?"));
            video3.AddComment(new Comment("Ivy", "Thank you for sharing."));
            video3.AddComment(new Comment("Jack", "You have great insight"));

            List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length: {video.GetLength()} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

                Console.WriteLine("Comments:");
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetCommentText()}");
                }
                Console.WriteLine();
            }

        }
    }
}