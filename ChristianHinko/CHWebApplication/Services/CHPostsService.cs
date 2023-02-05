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
                    Title = "Cool Post",
                    Subtitle = "This is my really cool post where I talk about perspective and orthographic and the different projections of our three-dimensional world.",
                    Date = new DateTime(2000, 01, 01),
                    ImageSrc = "https://github.blog/wp-content/uploads/2021/06/GitHub-Bug-Bounty_for-social.png",
                    Slug = "cool-post",
                    Component = typeof(Shared.Components.Posts.CoolPost)
                },
                new CHPost()
                {
                    Title = "New Post Hyea",
                    Subtitle = "Heyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfdaHeyh yeh hgasdljadohfda",
                    Date = new DateTime(2023, 02, 01),
                    ImageSrc = "https://thumbs.dreamstime.com/b/yeah-comic-vector-cartoon-illustration-explosions-comics-boom-symbol-sticker-tag-special-offer-label-advertising-badge-sign-banner-135602070.jpg",
                    Slug = "new-post-hyea",
                    Component = typeof(Shared.Components.Posts.CoolPost)
                },
                new CHPost()
                {
                    Title = "Evan With Rasin Bran On Top",
                    Subtitle = "Even shows us how to make cerial with rason brand and krave.",
                    Date = new DateTime(2023, 02, 01),
                    ImageSrc = "https://www.kelloggs.com/content/dam/NorthAmerica/kelloggs/en_US/images/BrandDetail/Raisin-Bran/Raisin-Bran_1880x835_hero-image.jpg",
                    Slug = "evan-with-rasin-brand-on-top-pog",
                    Component = typeof(Shared.Components.Posts.EvanWithRasinBranOnTop)
                }
            };

            // Sort Posts by date
            Posts.Sort((a, b) => a.Date.CompareTo(b.Date));
        }
    }
}
