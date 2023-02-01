using CHWebApplication.Models;

namespace CHWebApplication.Services
{
    /// <summary>
    /// Implement this and give a list of posts to use.
    /// </summary>
    public interface ICHPostsService
    {
        public List<CHPost> Posts { get; set; }
    }
}
