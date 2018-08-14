#core1.Dockerfile

FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
EXPOSE 80
EXPOSE 44355
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "entitlements.api.dll"]