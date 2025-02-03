using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using MudBlazorExtensionLibrary.Services;
using ChristianHinko.Services;
using System.Reflection;

namespace ChristianHinko
{
    public static class CHProgramUtils
    {
        public static IServiceCollection AddChristianHinkoServices(this IServiceCollection inServiceCollection)
        {
            return inServiceCollection
                .AddMudServices()
                .AddScoped<MBELLayoutService, CHLayoutService>()
                .AddScoped<ICHPostInfoService, CHPostInfoService>();
        }

        public static DateTime GetExecutingAssemblyFileDate()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            FileInfo assemblyFileInfo = new FileInfo(executingAssembly.Location);
            return assemblyFileInfo.LastWriteTime;
        }
    }
}
