using ChristianHinko.Types;
using ChristianHinko.Shared.Components.Posts;

namespace ChristianHinko.Services
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
                    ImageSrc = "/_content/ChristianHinko/images/TrigFunctionsMakeSoMuchSense.png",
                    Slug = "trig-functions-make-so-much-sense",
                    Component = typeof(TrigFunctionsMakeSoMuchSense)
                },
                new CHPostInfo()
                {
                    Title = "Get Faster Unreal Engine Build Times!",
                    Subtitle = "Use UBT BuildConfiguration to optimize build times.",
                    Date = new DateTime(2023, 07, 05),
                    ImageSrc = "/_content/ChristianHinko/images/GetFasterUnrealEngineBuildTimes.png",
                    Slug = "get-faster-unreal-engine-build-times",
                    Component = typeof(GetFasterUnrealEngineBuildTimes)
                }
            };

            // Sort PostInfos by date
            PostInfos.Sort((a, b) => a.Date.CompareTo(b.Date));
        }
    }
}
