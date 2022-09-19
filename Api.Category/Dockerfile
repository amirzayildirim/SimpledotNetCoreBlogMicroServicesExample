#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Api.Category/Api.Category.csproj", "Api.Category/"]
RUN dotnet restore "Api.Category/Api.Category.csproj"
COPY . .
WORKDIR "/src/Api.Category"
RUN dotnet build "Api.Category.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Category.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Category.dll"]