FROM public.ecr.aws/lambda/dotnet:8 AS base
WORKDIR /var/task

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish "LambdaRegionComunaNet8.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /var/task
COPY --from=build /app/publish .

# Opcional: copia el archivo .env para pruebas locales con Docker Compose
# (AWS Lambda ignora este archivo, pero puede ser útil en local)
# COPY .env .env

CMD ["LambdaRegionComunaNet8::LambdaRegionComunaNet8.LambdaEntryPoint::FunctionHandlerAsync"]
