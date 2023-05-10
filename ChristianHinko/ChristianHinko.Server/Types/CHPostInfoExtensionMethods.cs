namespace ChristianHinko.Server.Types
{
    /// <summary>
    /// Library of helpful functions for CHPostInfo.
    /// </summary>
    public static class CHPostInfoExtensionMethods
    {
        public static string GetHref(this CHPostInfo postInfo)
        {
            return $"/posts/{postInfo.Slug}";
        }
    }
}
