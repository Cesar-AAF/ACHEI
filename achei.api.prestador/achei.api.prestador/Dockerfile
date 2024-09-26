#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["achei.api.prestadorservico/achei.api.prestadorservico.csproj", "achei.api.prestadorservico/"]
RUN dotnet restore "achei.api.prestadorservico/achei.api.prestadorservico.csproj"
COPY . .
WORKDIR "/src/achei.api.prestadorservico"
RUN dotnet build "achei.api.prestadorservico.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "achei.api.prestadorservico.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "achei.api.prestadorservico.dll"]