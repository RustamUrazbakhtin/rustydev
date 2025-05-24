# Используем SDK-образ .NET 8 для сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Копируем .csproj и восстанавливаем зависимости
COPY rustydev/*.csproj ./rustydev/
RUN dotnet restore ./rustydev/rustydev.csproj

# Копируем все файлы и публикуем проект
COPY . .
WORKDIR /app/rustydev
RUN dotnet publish -c Release -o /app/out

# Используем ASP.NET образ для запуска
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Указываем порт для Render
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

ENTRYPOINT ["dotnet", "rustydev.dll"]
