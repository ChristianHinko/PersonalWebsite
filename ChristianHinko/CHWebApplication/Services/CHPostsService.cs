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
                new CHPost()
                {
                    Title = "Trig Functions Make So Much Sense!",
                    Subtitle = "Visualize and understand the circular functions.",
                    Date = new DateTime(2023, 02, 04),
                    ImageSrc = "/images/TrigFunctionsMakeSoMuchSense.png",
                    Slug = "trig-functions-make-so-much-sense",
                    Component = typeof(Shared.Components.Posts.TrigFunctionsMakeSoMuchSense)
                }
            };

            // Sort Posts by date
            Posts.Sort((a, b) => a.Date.CompareTo(b.Date));
        }
    }
}
