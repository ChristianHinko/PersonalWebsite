using CHWebApplication.Types;

namespace CHWebApplication.Services
{
    /// <summary>
    /// Central container of posts.
    /// </summary>
    public class CHPostsService : ICHPostsService
    {
        public List<CHPost> Posts { get; set; }

        public CHPostsService()
        {
            Posts = new List<CHPost>()
            {
            };

            // Sort Posts by date
            Posts.Sort((a, b) => a.Date.CompareTo(b.Date));
        }
    }
}
