// Screenshot of the program output is included in this project folder.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Basics", "CodeMaster", 600);
        video1.AddComment(new Comment("Ana", "Very helpful!"));
        video1.AddComment(new Comment("Luis", "Great explanation."));
        video1.AddComment(new Comment("Maria", "Thanks for this video!"));
        videos.Add(video1);

        Video video2 = new Video("OOP in C#", "DevPro", 800);
        video2.AddComment(new Comment("Carlos", "Now I understand classes."));
        video2.AddComment(new Comment("Sofia", "This was amazing!"));
        video2.AddComment(new Comment("Pedro", "Clear and simple."));
        videos.Add(video2);

        Video video3 = new Video("Advanced C#", "TechGuru", 1200);
        video3.AddComment(new Comment("Laura", "Very detailed."));
        video3.AddComment(new Comment("Jorge", "I learned a lot."));
        video3.AddComment(new Comment("Elena", "Excellent content!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}