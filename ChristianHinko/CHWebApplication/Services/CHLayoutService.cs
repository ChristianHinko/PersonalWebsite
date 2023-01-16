using MudBlazor;

namespace CHWebApplication.Services
{
    /// <summary>
    /// Central layout control over the web application.
    /// </summary>
    public class CHLayoutService
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
        /// Determines whether to use the right-to-left layout.
        /// </summary>
        public bool RightToLeft { get; private set; }

        /// <summary>
        /// Invoked when layout changes occur. Use this for
        /// notifying ComponentBase.StateHasChanged() when necessary.
        /// </summary>
        public event EventHandler? LayoutChanged;

        public CHLayoutService()
        {
            Theme = new();
            DefaultScrollbar = false;
            IsDarkMode = false;
            RightToLeft = false;

            LayoutChanged = null;
        }

        public void SetIsDarkMode(bool isDarkMode)
        {
            IsDarkMode = isDarkMode;
            if (LayoutChanged is not null)
            {
                LayoutChanged.Invoke(this, EventArgs.Empty);
            }
        }

        public void ToggleIsDarkMode()
        {
            SetIsDarkMode(!IsDarkMode);
        }

        public void SetRightToLeft(bool rightToLeft)
        {
            RightToLeft = rightToLeft;
            if (LayoutChanged is not null)
            {
                LayoutChanged.Invoke(this, EventArgs.Empty);
            }
        }

        public void ToggleRightToLeft()
        {
            SetRightToLeft(!RightToLeft);
        }
    }
}
