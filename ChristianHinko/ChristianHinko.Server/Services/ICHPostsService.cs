using ChristianHinko.Server.Types;

namespace ChristianHinko.Server.Services
{
    /// <summary>
    /// Implement this and give a list of post infos to use.
    /// </summary>
    public interface ICHPostInfoService
    {
        public List<CHPostInfo> PostInfos { get; set; }
    }
}
