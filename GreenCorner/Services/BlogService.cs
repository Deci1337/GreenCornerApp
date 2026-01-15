using GreenCorner.Models;
using System;
using System.Collections.Generic;

namespace GreenCorner.Services;

public class BlogService
{
    private List<Post> _posts;

    public BlogService()
    {
        _posts = new List<Post>
        {
            new Post
            {
                Id = 1,
                Title = "5 Tips for New Plant Parents",
                Excerpt = "Just bought your first plant? Here are the essential tips to keep it alive and thriving.",
                Content = "Content of the article...",
                ImageUrl = "blog1.png", // Placeholder
                DatePublished = DateTime.Now.AddDays(-5),
                Author = "Anna Green"
            },
            new Post
            {
                Id = 2,
                Title = "Understanding Light Conditions",
                Excerpt = "What does 'bright indirect light' actually mean? We break it down for you.",
                Content = "Content of the article...",
                ImageUrl = "blog2.png", // Placeholder
                DatePublished = DateTime.Now.AddDays(-12),
                Author = "Mike Soil"
            },
            new Post
            {
                Id = 3,
                Title = "Repotting 101",
                Excerpt = "Busting out of the pot? Learn when and how to give your plant a new home.",
                Content = "Content of the article...",
                ImageUrl = "blog3.png", // Placeholder
                DatePublished = DateTime.Now.AddDays(-20),
                Author = "Sarah Leaf"
            }
        };
    }

    public List<Post> GetPosts()
    {
        return _posts;
    }

    public Post GetPostById(int id)
    {
        return _posts.FirstOrDefault(p => p.Id == id);
    }
}
