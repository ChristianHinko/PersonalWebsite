namespace CHWebApplication.Types
{
    /// <summary>
    /// Library of helpful functions for CHPost.
    /// </summary>
    public static class CHPostExtensionMethods
    {
        public static string GetHref(this CHPost post)
        {
            return $"/posts/{post.Slug}";
        }
    }
}
