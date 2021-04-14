FROM mcr.microsoft.com/dotnet/sdk:3.1
LABEL version="1.0.2" description="APP Net Core"
COPY dist /app/
WORKDIR /app/
ENV ASPNETCORE_URLS=http://+:80 
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "mvc.dll"]

