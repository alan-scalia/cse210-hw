using System;

class Program
{
    static void Main(string[] args)
    {
        Video Video1 = new Video("My first video", "JackYT", 659);
        Video Video2 = new Video("New content in the channel", "Lauren", 540);
        Video Video3 = new Video("How to fix your laptop", "TechGuy", 831);

        Comment FirstVideo1 = new Comment("Susan", "Good luck!");
        Comment FirstVideo2 = new Comment("User", "Good video");
        Comment FirstVideo3 = new Comment("John123", "Too long");
        Video1.AddComment(FirstVideo1);
        Video1.AddComment(FirstVideo2);
        Video1.AddComment(FirstVideo3);

        Comment SecondVideo1 = new Comment("Rick", "great");
        Comment SecondVideo2 = new Comment("User2", "you finally updated!");
        Comment SecondVideo3 = new Comment("sean33", "I like your new content");
        Video2.AddComment(SecondVideo1);
        Video2.AddComment(SecondVideo2);
        Video2.AddComment(SecondVideo3);

        Comment ThirdVideo1 = new Comment("Lucas", "thank you!");
        Comment ThirdVideo2 = new Comment("bot45567", "I fixed my laptop");
        Comment ThirdVideo3 = new Comment("ilovetech", "thanks for your video");
        Video3.AddComment(ThirdVideo1);
        Video3.AddComment(ThirdVideo2);
        Video3.AddComment(ThirdVideo3);

        List<Video> Videos = [];
        Videos.Add(Video1);
        Videos.Add(Video2);
        Videos.Add(Video3);

        foreach (Video video in Videos)
        {
            video.DisplayVideo();
            video.DisplayComments();
            
        }
    }
}