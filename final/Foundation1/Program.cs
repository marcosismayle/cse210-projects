using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create Video objects
        Video video1 = new Video("Title1", "Author1", 120);
        Video video2 = new Video("Title2", "Author2", 180);
        Video video3 = new Video("Title3", "Author3", 150);
        Video video4 = new Video("Title4", "Author4", 110);

        // Create a list of videos
        List<Video> videoList = new List<Video> { video1, video2, video3, video4 };

        foreach (var video in videoList)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");

            // Create and add comments to the video
            for (int i = 1; i <= 4; i++)
            {
                video.AddComment($"User{i}", $"Comment {i} for {video.GetTitle()}");
            }

            // Count and display number of comments
            video.SetNumberOfComments();

            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            // Display CommenterName and CommentText
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}
