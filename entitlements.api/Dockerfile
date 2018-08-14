FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 64006
EXPOSE 44355

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY entitlements.api/entitlements.api.csproj entitlements.api/
RUN dotnet restore entitlements.api/entitlements.api.csproj
COPY . .
WORKDIR /src/entitlements.api
RUN dotnet build entitlements.api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish entitlements.api.csproj -c Release -o /app

# docker build --target publish -t entitlements:latest .

FROM base AS final	
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "entitlements.api.dll"]
