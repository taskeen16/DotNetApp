FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS RUNTIME
WORKDIR /app
COPY SimpleApp/bin/Debug/netcoreapp2.1/SimpleApp.dll ./
ENTRYPOINT ["dotnet", "SimpleApp.dll"]
EXPOSE 44315
