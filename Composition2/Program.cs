using System;
using Composition2.Entities;

namespace Composition2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Post 1
            Post post1 = new Post(new DateTime(2018, 6, 21, 13, 5, 44),
             "Traveling New Zeland",
             "I'm going to visit this wonderful country",
             12);

            Comment coment1 = new Comment("Have a nice trip");
            Comment coment2 = new Comment("Wow that's awesome!");

            post1.addComment(coment1);
            post1.addComment(coment2);

            //Post 2
            Post post2 = new Post(new DateTime(2018, 7, 28, 23, 14, 19),
             "Good night guys",
             "See you tomorrow",
             5);
            Comment coment3 = new Comment("Good night");
            Comment coment4 = new Comment("May the force be with you");

            post2.addComment(coment3);
            post2.addComment(coment4);

            //Output
            Console.WriteLine(post1.Title);
            Console.WriteLine(post1.Likes + " Likes - " + post1.Moment);
            Console.WriteLine(post1.Content);
            Console.WriteLine("Comments: ");
            foreach (Comment comment in post1.Comments)
            {
                Console.WriteLine(comment.Text);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(post2.Title);
            Console.WriteLine(post2.Likes + " Likes - " + post2.Moment);
            Console.WriteLine(post2.Content);
            Console.WriteLine("Comments: ");
            foreach (Comment comment in post2.Comments)
            {
                Console.WriteLine(comment.Text);
            }
        }
    }
}