#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["achei.api.orcamentosservico/achei.api.orcamentosservico.csproj", "achei.api.orcamentosservico/"]
RUN dotnet restore "achei.api.orcamentosservico/achei.api.orcamentosservico.csproj"
COPY . .
WORKDIR "/src/achei.api.orcamentosservico"
RUN dotnet build "achei.api.orcamentosservico.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "achei.api.orcamentosservico.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "achei.api.orcamentosservico.dll"]
