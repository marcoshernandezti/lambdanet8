# README.md
# LambdaRegionComunaNet8

Proyecto desarrollado en **.NET 8** que implementa un servicio serverless utilizando **AWS Lambda** y **DynamoDB** para exponer un endpoint que entrega las regiones y comunas de Chile. Este proyecto está diseñado para ser seguro, escalable y fácilmente desplegable mediante archivos YAML para integración y despliegue continuo.

---

## 🚀 Características principales

- **.NET 8**: Aprovecha las últimas mejoras de rendimiento y seguridad.
- **AWS Lambda**: Arquitectura serverless para alta disponibilidad y bajo costo.
- **DynamoDB**: Base de datos NoSQL rápida y flexible para almacenar regiones y comunas.
- **API RESTful**: Endpoint para consultar regiones y comunas de Chile.
- **Variables de entorno**: Gestión segura de credenciales y configuraciones sensibles.
- **Despliegue automatizado**: Archivos YAML para CI/CD, facilitando la integración y el despliegue continuo.
- **Documentación OpenAPI/Swagger**: Explora y prueba el endpoint fácilmente.

---

## 🗺️ ¿Qué resuelve este proyecto?

Permite consultar de manera eficiente y centralizada las regiones y comunas de Chile, ideal para aplicaciones que requieren esta información actualizada y confiable, sin depender de fuentes externas o archivos estáticos.

---

## ⚙️ Tecnologías utilizadas

- [.NET 8](https://dotnet.microsoft.com/)
- [AWS Lambda](https://aws.amazon.com/lambda/)
- [Amazon DynamoDB](https://aws.amazon.com/dynamodb/)
- [Swagger/OpenAPI](https://swagger.io/)
- [CI/CD con YAML](https://docs.github.com/en/actions/using-workflows/workflow-syntax-for-github-actions)

---

## 🏗️ Estructura del proyecto

- **/src**: Código fuente principal.
- **/deploy**: Archivos YAML para despliegue automatizado.
- **/docs**: Documentación adicional y ejemplos de uso.

---

## 🔒 Seguridad

- Uso de **variables de entorno** para almacenar claves y configuraciones sensibles.
- No se exponen credenciales en el código fuente ni en los archivos de configuración.

---

## 🚦 Despliegue e integración continua

El proyecto incluye archivos YAML para facilitar el despliegue automático en AWS Lambda y la integración continua con GitHub Actions u otras plataformas compatibles.

---

## 📦 Instalación y uso local

1. Clona el repositorio: