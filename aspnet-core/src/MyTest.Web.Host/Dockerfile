FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/MyTest.Web.Host/MyTest.Web.Host.csproj", "src/MyTest.Web.Host/"]
COPY ["src/MyTest.Web.Core/MyTest.Web.Core.csproj", "src/MyTest.Web.Core/"]
COPY ["src/MyTest.Application/MyTest.Application.csproj", "src/MyTest.Application/"]
COPY ["src/MyTest.Core/MyTest.Core.csproj", "src/MyTest.Core/"]
COPY ["src/MyTest.EntityFrameworkCore/MyTest.EntityFrameworkCore.csproj", "src/MyTest.EntityFrameworkCore/"]
WORKDIR "/src/src/MyTest.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MyTest.Web.Host", "src/MyTest.Web.Host"]
COPY ["src/MyTest.Web.Core", "src/MyTest.Web.Core"]
COPY ["src/MyTest.Application", "src/MyTest.Application"]
COPY ["src/MyTest.Core", "src/MyTest.Core"]
COPY ["src/MyTest.EntityFrameworkCore", "src/MyTest.EntityFrameworkCore"]
WORKDIR "/src/src/MyTest.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MyTest.Web.Host.dll"]
