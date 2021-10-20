using BlazorBlog.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorBlog.Client.Services
{
    interface IBlogService
    {
        Task<List<BlogPost>> GetBlogPosts();
        Task<BlogPost> GetBlogPostByUrl(string url);
        Task<BlogPost> CreateNewBlogPost(BlogPost request);
    }
}
