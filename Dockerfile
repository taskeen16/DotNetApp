FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY bin/Debug/netcoreapp2.1/ SimpleApp/
WORKDIR /SimpleApp
ENTRYPOINT ["dotnet", "SimpleApp.dll"]
EXPOSE 44315
