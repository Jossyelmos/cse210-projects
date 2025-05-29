using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("PJ Mask", "Disney Junior", 500);
        video1.AddComment(new Comment("Jeff", "Very Interesting"));
        video1.AddComment(new Comment("Johny", "Amaya is very naughty"));
        video1.AddComment(new Comment("Theo", "Looking forward to next episode"));
        video1.AddComment(new Comment("Inny", "Very beautiful episode, the graphiics is insane"));

        Video video2 = new Video("Jungle Book", "Amatuer", 1200);
        video2.AddComment(new Comment("Patra", "I really love this episode"));
        video2.AddComment(new Comment("Johny", "Amaya is very naughty"));
        video2.AddComment(new Comment("Theo", "Looking forward to next episode"));

        Video video3 = new Video("Mysterious Note", "Harold Scamper", 2600);
        video3.AddComment(new Comment("Johny", "Amaya is very naughty"));
        video3.AddComment(new Comment("Theo", "Looking forward to next episode"));
        video3.AddComment(new Comment("Kim", "Very educative. i love the characters"));
        video3.AddComment(new Comment("Rodri", "Glue to my screen.d"));

        Video video4 = new Video("Big Trip", "Hollywood", 1050);
        video4.AddComment(new Comment("Patra", "I really love this episode"));
        video4.AddComment(new Comment("Johny", "Amaya is very naughty"));
        video4.AddComment(new Comment("Theo", "Looking forward to next episode"));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            video.DisplayVideos();
        }
    }

}