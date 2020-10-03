using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasefirstdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabasefirstdemoEntities();
            var post = new Post()
            {
                Body = "hello",
                DatePublished = DateTime.Now,
                Title = "python",
                Postid=2


            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
