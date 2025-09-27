using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Creating a List of Videos
        List<Video> videos = new List<Video>();

        // Creating and adding first video
        Video video1 = new Video();
        video1._title = "C# Tutorial for Beginners";
        video1._author = "John Doe";
        video1._lengthInSeconds = 600;
        video1._comments = new List<Comment>();
        video1.AddComment(new Comment ( "Alice", "Great tutorial!" ));
        video1.AddComment(new Comment ( "Bob", "Very helpful, thanks!" ));
        videos.Add(video1);

        // Creating and adding second video
        Video video2 = new Video();
        video2._title = "Learn Python in 10 Minutes";
        video2._author = "Jane Smith";
        video2._lengthInSeconds = 600;
        video2._comments = new List<Comment>();
        video2.AddComment(new Comment ( "Charlie", "Awesome content!" ));
        video2.AddComment(new Comment ( "Dave", "Loved it!" ));
        video2.AddComment(new Comment ( "Eve", "Thanks for sharing!" ));
        videos.Add(video2);

        // Creating and adding third video
        Video video3 = new Video();
        video3._title = "JavaScript Basics";
        video3._author = "Mike Johnson";
        video3._lengthInSeconds = 450;
        video3._comments = new List<Comment>();
        video3.AddComment(new Comment ( "Frank", "Very informative." ));
        video3.AddComment(new Comment ( "Grace", "Helped me a lot!" ));
        videos.Add(video3);

        //Creating and adding fourth video
        Video video4 = new Video();
        video4._title = "HTML & CSS Crash Course";
        video4._author = "Emily Davis";
        video4._lengthInSeconds = 700;
        video4._comments = new List<Comment>();
        video4.AddComment(new Comment ( "Hannah", "This was super useful!" ));
        video4.AddComment(new Comment ( "Ian", "Well explained." ));
        video4.AddComment(new Comment ( "Jack", "I learned a lot!" ));
        videos.Add(video4);

        // Iterating through the list to display details of each video
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}