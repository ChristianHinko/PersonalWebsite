namespace ChristianHinko.Types
{
    /// <summary>
    /// Defines information about a post, including what to render.
    /// </summary>
    public record CHPostInfo
    {
        public string Title { get; init; } = default!;

        public string Subtitle { get; init; } = default!;

        public DateTime Date { get; init; } = default!;

        public string ImageSrc { get; init; } = default!;

        /// <summary>
        /// The slug portion of the URL pathname.
        /// </summary>
        /// <seealso cref="Pages.Posts.Post"/>
        public string Slug { get; init; } = default!;

        /// <summary>
        /// Type of component to render.
        /// </summary>
        /// <seealso cref="Pages.Posts.Post"/>
        public Type Component { get; init; } = default!;
    }
}
