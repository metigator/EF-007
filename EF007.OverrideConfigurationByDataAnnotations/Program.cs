using EF007.OverrideConfigurationByDataAnnotations.Data;
using System;
namespace EF007.OverrideConfigurationByDataAnnotations
{
    class Program
    {
        public static void Main()
        {
            using (var context = new AppDbContext())
            {
                Console.WriteLine("-------- Users -----------");
                Console.WriteLine();
                foreach (var user in context.Users)
                {
                    Console.WriteLine(user.Username);
                }
                Console.WriteLine();
                Console.WriteLine("-------- Tweets -----------");
                Console.WriteLine();
                foreach (var tweet in context.Tweets)
                {
                    Console.WriteLine(tweet.TweetText);
                }
                Console.WriteLine();
                Console.WriteLine("-------- Comments -----------");
                Console.WriteLine();
                foreach (var comment in context.Comments)
                {
                    Console.WriteLine(comment.CommentText);
                }
            }
            Console.ReadKey();
        }
    }
}
