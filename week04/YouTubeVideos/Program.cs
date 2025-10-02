using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to make an origami tulip!", "Origami Lover", 600);
        Video video2 = new Video("Painting with watercolors for the first time", "Some Artist", 1000);
        Video video3 = new Video("How to make ramen", "HowToCook", 1200);

        video1.AddComment(new Comment("Daniela", "I gifted one to my mom!"));
        video1.AddComment(new Comment("Eva", "Thanks for explaining clearly."));
        video1.AddComment(new Comment("Mia", "Can you do a heart next time?"));

        video2.AddComment(new Comment("Jin", "What brand are the paintbrushes you used?"));
        video2.AddComment(new Comment("Travis", "Nice color palette."));
        video2.AddComment(new Comment("Ryan", "What a great painting technique!"));

        video3.AddComment(new Comment("Theo", "Such a nice recipe!"));
        video3.AddComment(new Comment("Jay", "Tried to do it, it was very easy. Thanks!"));
        video3.AddComment(new Comment("Jeremy", "10 times better than instant noodles."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Lenght: {video.GetLenght()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
        }
        Console.WriteLine();

    }
}