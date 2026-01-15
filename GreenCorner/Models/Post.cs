using System;

namespace GreenCorner.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Excerpt { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public DateTime DatePublished { get; set; }
    public string Author { get; set; }
}
