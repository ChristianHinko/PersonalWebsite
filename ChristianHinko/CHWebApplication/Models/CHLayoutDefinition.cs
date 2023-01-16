using MudBlazor;

namespace CHWebApplication.Models
{
    /// <summary>
    /// Static definition of default values for CHLayoutService.
    /// This is the definition of the web application's layout.
    /// </summary>
    public static class CHLayoutDefinition
    {
        public static readonly MudTheme Theme;
        public static readonly bool DefaultScrollbar;
        public static readonly bool IsDarkMode;
        public static readonly bool RightToLeft;

        static CHLayoutDefinition()
        {
            Theme = new MudTheme()
            {
                Palette = new Palette()
                {

                },
                PaletteDark = new PaletteDark()
                {

                },
                Shadows = new Shadow()
                {

                },
                Typography = new Typography()
                {

                },
                LayoutProperties = new LayoutProperties()
                {

                },
                ZIndex = new ZIndex()
                {

                }
            };

            DefaultScrollbar = false;

            IsDarkMode = true;

            RightToLeft = false;
        }
    }
}
