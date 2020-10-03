using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Codefirstdemo
{ public class Post // created by the developer to define the attributes in the table
    {
        public int Postid { get; set; }
        public System.DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
    public class BlogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BlogDbContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a New Values: ");
                var name = Console.ReadLine();

                var blog = new Post
                { Body = name,
                    DatePublished = DateTime.Now,
                    Title="entity framework",
                    Postid=1
                   
                };
                db.Posts.Add(blog);
                db.SaveChanges();
            }
        }
    }
}
