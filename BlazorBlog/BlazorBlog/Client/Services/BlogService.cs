using BlazorBlog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Client.Services
{
    public class BlogService : IBlogService
    {
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>()
        {
            new BlogPost {Url = "new-tutorial", Title = "A new Tutorial about Blazor", Description = "This is a new tutorial showing you how to build a blog with blazor",
            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."},
            new BlogPost{Url = "first-post", Title = "My first blog post", Description = "Hi! This is my new shiny blog. Enjoy!",
            Content = "This is my beautiful short blog post. Isn't it nice?"}
        };

        public List<BlogPost> GetBlogPosts()
        {
            return Posts;
        }

        public BlogPost GetBlogPostByUrl(string url)
        {
            return Posts.FirstOrDefault(p => p.Url.ToLower().Equals(url.ToLower()));
        }
    }
}

