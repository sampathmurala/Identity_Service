# Use the official .NET SDK image as a build environment
# This is a multi-stage build to create a small final image.
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy the project files and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application code
COPY . .
WORKDIR /app
# Build the application in Release mode
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image for the final stage
# This image is much smaller and more secure for production.
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/out .

# Set the entry point to run the published application
ENTRYPOINT ["dotnet", "Identity.Api.dll"]
