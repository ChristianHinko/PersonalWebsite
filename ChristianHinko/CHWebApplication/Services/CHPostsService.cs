using CHWebApplication.Models;

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
                new CHPost()
                {
                    Title = "Cool Post",
                    Subtitle = "This is my really cool post where I talk about perspective and orthographic and the different projections of our three-dimensional world.",
                    Date = new DateTime(2000, 01, 01),
                    ImageSrc = "https://github.blog/wp-content/uploads/2021/06/GitHub-Bug-Bounty_for-social.png",
                    Slug = "cool-post",
                    Component = typeof(Shared.Components.Posts.CoolPost)
                }
            };
        }
    }
}
