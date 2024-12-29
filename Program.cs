using Microsoft.EntityFrameworkCore;
using System.Linq;
using Blogg.Data;
using Blogg.Models;
using System;

namespace Blogg
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();
            // context.Users.Add(new User
            // {
            //     Bio = "9x microsoft MVP",
            //     Email = "André@balta.io",
            //     Image = "https://balta.io",
            //     Name = "André Baltieri",
            //     PasswordHash = "1234",
            //     Slug = "andré-baltieri"
            // });
            // context.SaveChanges();

            var user = context.Users.FirstOrDefault();
            var post = new Post
            {
                Author = user,
                Body = "Meu artigo",
                Category = new Category{
                    Name = "Backend2",
                    Slug = "backend2"
                },
                CreateDate = System.DateTime.Now,
                Slug = "meu-artigo",
                Summary = "Neste artigo vamos conferir",
                Title = "Meu artigo",
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
