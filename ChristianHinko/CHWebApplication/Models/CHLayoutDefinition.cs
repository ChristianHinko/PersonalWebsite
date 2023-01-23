using MudBlazor;
using MudBlazor.Utilities;

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
                    Primary = new MudColor(127, 95, 255, 1.0),
                    Secondary = new MudColor(15, 223, 191, 1.0),
                    Tertiary = new MudColor(255, 127, 143, 1.0)
                },
                PaletteDark = new PaletteDark()
                {
                    Primary = new MudColor(127, 95, 255, 1.0),
                    Secondary = new MudColor(15, 223, 191, 1.0),
                    Tertiary = new MudColor(255, 127, 143, 1.0)
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
