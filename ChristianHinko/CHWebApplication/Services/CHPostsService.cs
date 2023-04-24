using CHWebApplication.Types;

namespace CHWebApplication.Services
{
    /// <summary>
    /// Central container of post infos.
    /// </summary>
    public class CHPostInfoService : ICHPostInfoService
    {
        public List<CHPostInfo> PostInfos { get; set; }

        public CHPostInfoService()
        {
            PostInfos = new List<CHPostInfo>()
            {
                new CHPostInfo()
                {
                    Title = "Trig Functions Make So Much Sense!",
                    Subtitle = "Visualize and understand the circular functions.",
                    Date = new DateTime(2023, 02, 04),
                    ImageSrc = "/images/TrigFunctionsMakeSoMuchSense.png",
                    Slug = "trig-functions-make-so-much-sense",
                    Component = typeof(Shared.Components.Posts.TrigFunctionsMakeSoMuchSense)
                }
            };

            // Sort PostInfos by date
            PostInfos.Sort((a, b) => a.Date.CompareTo(b.Date));
        }
    }
}
