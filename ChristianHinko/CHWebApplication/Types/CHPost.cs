namespace CHWebApplication.Types
{
    /// <summary>
    /// Defines a post - basic information and what to render.
    /// </summary>
    public record CHPost
    {
        public string Title { get; init; } = default!;

        public string Subtitle { get; init; } = default!;

        public DateTime Date { get; init; } = default!;

        public string ImageSrc { get; init; } = default!;

        /// <summary>
        /// The slug portion of the URL pathname.
        /// </summary>
        /// <seealso cref="Pages.PostPage"/>
        public string Slug { get; init; } = default!;

        /// <summary>
        /// Type of component to render.
        /// </summary>
        /// <seealso cref="Pages.PostPage"/>
        public Type Component { get; init; } = default!;
    }
}
