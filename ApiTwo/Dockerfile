FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-environment
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/sdk:3.1
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
COPY --from=build-environment /app/out .
ENTRYPOINT [ "dotnet", "ApiTwo.dll" ]