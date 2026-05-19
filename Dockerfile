# Estágio de compilação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copiar tudo e restaurar as dependências
COPY . ./
RUN dotnet restore

# Compilar a aplicação para a pasta 'out'
RUN dotnet publish -c Release -o out

# Estágio de execução
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build-env /app/out .

# Configurar a porta que o Render espera (geralmente 8080)
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# Comando para rodar a aplicação (substitua pelo nome da sua DLL)
ENTRYPOINT ["dotnet", "Uninove.Web.dll"]