FROM mcr.microsoft.com/dotnet/core/sdk:2.1

EXPOSE 80

WORKDIR /api

COPY ./JsonPlaceholder.Api/bin/Release/netcoreapp2.1/publish .

CMD ["dotnet", "JsonPlaceholder.Api.dll"]
