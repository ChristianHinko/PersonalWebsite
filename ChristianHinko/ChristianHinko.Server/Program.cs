using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;
using ChristianHinko.Server.Services;
using MudBlazorExtensionLibrary.Services;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Http.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.Configure<ForwardedHeadersOptions>(
    (forwardedHeadersOptions) =>
    {
        // Ensure that we get information about the protocol that the client uses
        forwardedHeadersOptions.ForwardedHeaders |= (ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto);
    }
);
builder.Services.AddMudServices();
builder.Services.AddScoped<ICHPostInfoService, CHPostInfoService>();
builder.Services.AddScoped<MBELLayoutService, CHLayoutService>();

var app = builder.Build();

app.UseForwardedHeaders();

// Cover the case that the use of HTTPS was lost while going through a proxy server (e.g., a load balancer)
app.Use(
    async (context, next) =>
    {
        if (context.Request.IsHttps || context.Request.Headers[ForwardedHeadersDefaults.XForwardedProtoHeaderName] == Uri.UriSchemeHttps)
        {
            // We are already using HTTPS - nice
            await next.Invoke();
            return;
        }

        // Rebuild URL to use HTTPS
        string urlHttps = UriHelper.BuildAbsolute(Uri.UriSchemeHttps, context.Request.Host, context.Request.PathBase, context.Request.Path, context.Request.QueryString);
        context.Response.Redirect(urlHttps, true);
    }
);

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
