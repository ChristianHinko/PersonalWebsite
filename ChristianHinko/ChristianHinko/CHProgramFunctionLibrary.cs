using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using MudBlazorExtensionLibrary.Services;
using ChristianHinko.Services;

namespace ChristianHinko
{
    /// <summary>
    /// Library of helpful functions for the Program.
    /// </summary>
    public static class CHProgramFunctionLibrary
    {
        public static IServiceCollection AddChristianHinkoServices(this IServiceCollection inServiceCollection)
        {
            return inServiceCollection
                .AddMudServices()
                .AddScoped<MBELLayoutService, CHLayoutService>()
                .AddScoped<ICHPostInfoService, CHPostInfoService>();
        }
    }
}
