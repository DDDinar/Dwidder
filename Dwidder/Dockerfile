FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Dwidder/Dwidder.csproj", "Dwidder/"]
RUN dotnet restore "Dwidder/Dwidder.csproj"
COPY . .
WORKDIR "/src/Dwidder"
RUN dotnet build "Dwidder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dwidder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dwidder.dll"]
