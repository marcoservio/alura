FROM mcr.microsoft.com/dotnet/sdk:2.1
COPY . /source
RUN dotnet publish "source/web/FinancasWeb.csproj" -o /app -c Release
CMD [ "dotnet", "/app/FinancasWeb.dll" ]