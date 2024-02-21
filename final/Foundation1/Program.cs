using System;
using System.Collections.Generic;


public class Comment
{
    public string _commenterName { get; set; }
    public string _commentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
}


public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _lengthSeconds { get; set; }
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AddComment(string commenterName, string commentText)
    {
        comments.Add(new Comment(commenterName, commentText));
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _lengthSeconds + " seconds");
        Console.WriteLine("Number of comments: " + GetNumberOfComments());
        Console.WriteLine("Comments:");

        foreach (var comment in comments)
        {
            Console.WriteLine(" - " + comment._commenterName + ": " + comment._commentText);
        }
        Console.WriteLine();
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        // Creating videos and details
        Video video1 = new Video("How to write a c# Program", "Andrew", 180);
        video1.AddComment("John Bush", "Great video!");
        video1.AddComment("Rogers Miller", "I learned a lot from this.");

        Video video2 = new Video("C# Class", "Jacob", 240);
        video2.AddComment("Imam", "Interesting content.");
        video2.AddComment("Williams", "We need more contents like these");



        // Putting videos in a list
        List<Video> videos = new List<Video> { video1, video2 };

        // Displaying information for each video created
        foreach (var video in videos)
        {
            video.DisplayInformation();
        }
    }
}
