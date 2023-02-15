using MudBlazor;
using MudBlazor.Utilities;
using MudBlazorExtensionLibrary.Services;

namespace CHWebApplication.Services
{
    /// <summary>
    /// Defines the layout of the web application.
    /// </summary>
    public class CHLayoutService : MBELLayoutService
    {
        public CHLayoutService()
        {
            Theme = new MudTheme()
            {
                Palette = new Palette()
                {
                    Primary = new MudColor(127, 95, 255, 1.0),
                    Secondary = new MudColor(15, 223, 191, 1.0),
                    Tertiary = new MudColor(255, 127, 143, 1.0),
                    HoverOpacity = 0.05
                },
                PaletteDark = new PaletteDark()
                {
                    Primary = new MudColor(127, 95, 255, 1.0),
                    Secondary = new MudColor(15, 223, 191, 1.0),
                    Tertiary = new MudColor(255, 127, 143, 1.0),
                    HoverOpacity = 0.05
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
