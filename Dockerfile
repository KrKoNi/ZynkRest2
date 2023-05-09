FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ZynkRest2.csproj", "./"]
RUN dotnet restore "ZynkRest2.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "ZynkRest2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZynkRest2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZynkRest2.dll"]
