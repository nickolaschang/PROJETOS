using System;
using DemoStringBuilder.Entities;

namespace DemoStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("Woah, that is awesome!");
            Comment comment3 = new Comment("Cya!! good luck!");
            Comment comment4 = new Comment("May the force be with you! :D");

            Post post1 = new Post(DateTime.Parse("19/04/2022 13:55:36"), "Traveling to New Zealand", "Im going to visit this wonderful country!!", 12);
            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Post post2 = new Post(DateTime.Parse("21/06/2022 13:25:16"), "Have fun!!", "See you tomorrow!!", 5);
            post1.AddComment(comment3);
            post1.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);

        }
    }
}
