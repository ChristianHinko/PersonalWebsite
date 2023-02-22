# This Dockerfile is intended to deploy the Blazor Server project to Google Cloud App Engine.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app/
# Expose the TCP port for Google Cloud App Engine
EXPOSE 8080
# Have our web server listen on the TCP port (for Google Cloud App Engine) instead of the HTTP ports
ENV ASPNETCORE_URLS=http://*:8080

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src/
COPY ["./ChristianHinko/CHWebApplication/CHWebApplication.csproj", "./ChristianHinko/CHWebApplication/"]
COPY ["./MudBlazorExtension/MudBlazorExtension/MudBlazorExtensionLibrary/MudBlazorExtensionLibrary.csproj", "./MudBlazorExtension/MudBlazorExtension/MudBlazorExtensionLibrary/"]
RUN dotnet restore "ChristianHinko/CHWebApplication/CHWebApplication.csproj"
COPY ./ ./
RUN dotnet build "ChristianHinko/CHWebApplication/CHWebApplication.csproj" --output /app/build/ --configuration Release

FROM build AS publish
RUN dotnet publish "ChristianHinko/CHWebApplication/CHWebApplication.csproj" --output /app/publish/ --configuration Release

FROM base AS final
WORKDIR /app/
COPY --from=publish ["./app/publish/", "./"]
ENTRYPOINT ["dotnet", "CHWebApplication.dll"]