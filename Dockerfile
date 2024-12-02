FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

RUN dotnet tool install --global dotnet-ef
RUN apt-get update && apt-get install -y netcat-openbsd libbsd0

ENV PATH="$PATH:/root/.dotnet/tools"

COPY . ./
RUN dotnet publish -c Release -o /app/out

# Etapa de Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

COPY --from=build /app/out ./

COPY --from=build /usr/bin/nc /usr/bin/nc

EXPOSE 5056
EXPOSE 403
EXPOSE 80

ENTRYPOINT ["dotnet", "AppointmentApplication.dll"]
