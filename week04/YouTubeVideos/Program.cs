using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("Intro to C#", "Kelsey Woodland", 600);
        Video video2 = new Video("Understanding APIs", "Jane Doe", 450);
        Video video3 = new Video("CSS Animations", "John Smith", 300);

        video1.AddComment(new Comment("Alice", "Great introduction!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Loved the examples!"));

        video2.AddComment(new Comment("Dave", "This was very informative."));
        video2.AddComment(new Comment("Eve", "I learned a lot about APIs!"));
        video2.AddComment(new Comment("Frank", "CSS animations are so cool!"));

        video3.AddComment(new Comment("Grace", "CSS animations are awesome!"));
        video3.AddComment(new Comment("Heidi", "I love how you explained the concepts."));
        video3.AddComment(new Comment("Ivan", "Great video on CSS!"));

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (var video in _videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}