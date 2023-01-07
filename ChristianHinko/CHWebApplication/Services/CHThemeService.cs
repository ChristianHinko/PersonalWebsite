using MudBlazor;

namespace CHWebApplication.Services
{
    /// <summary>
    /// Central theming control over the web application.
    /// </summary>
    public class CHThemeService
    {
        /// <summary>
        /// Current theme of the application.
        /// </summary>
        public MudTheme Theme { get; private set; }

        /// <summary>
        /// Determines whether to use the default scrollbar.
        /// </summary>
        public bool DefaultScrollbar { get; private set; }

        /// <summary>
        /// Determines whether to use the dark palette.
        /// </summary>
        public bool IsDarkMode { get; private set; }

        /// <summary>
        /// Invoked when theme changes occur. Use this for
        /// notifying ComponentBase.StateHasChanged() when necessary.
        /// </summary>
        public event EventHandler? ThemeChanged;

        public CHThemeService()
        {
            Theme = new();
            DefaultScrollbar = false;
            IsDarkMode = false;
            ThemeChanged = null;
        }

        public void SetIsDarkMode(bool isDarkMode)
        {
            IsDarkMode = isDarkMode;
            if (ThemeChanged is not null)
            {
                ThemeChanged.Invoke(this, EventArgs.Empty);
            }
        }

        public void ToggleIsDarkMode()
        {
            SetIsDarkMode(!IsDarkMode);
        }
    }
}
