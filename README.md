
# 🎬 DevFlix

![.NET](https://img.shields.io/badge/.NET-6.0-purple)
![C#](https://img.shields.io/badge/C%23-12-blue)
![Architecture](https://img.shields.io/badge/Architecture-Clean%20Architecture-green)
![DDD](https://img.shields.io/badge/DDD-Domain%20Driven%20Design-orange)
![CI](https://img.shields.io/badge/CI-GitHub%20Actions-black)
![Docker](https://img.shields.io/badge/Docker-Containerized-blue)
![License](https://img.shields.io/badge/License-MIT-lightgrey)

---

## 📌 Sobre o projeto

**DevFlix** é uma plataforma de **streaming de vídeos**, inspirada em serviços como Netflix, desenvolvida com **.NET** seguindo práticas modernas de engenharia de software.

O objetivo do projeto é **aplicar conceitos avançados** como:

- Clean Architecture
- Domain-Driven Design (DDD)
- Event-Driven Architecture (EDA)
- TDD
- Integração contínua (CI/CD)
- Microsserviços e mensageria

Este projeto tem foco **educacional e arquitetural**, simulando um cenário real de produção.

---

## 🧱 Arquitetura

O projeto segue **Clean Architecture**, com separação clara de responsabilidades:

```

src/
├─ DevFlix.Api              → ASP.NET Core (Controllers, Filters)
├─ DevFlix.Application      → Casos de uso, MediatR, Validações
├─ DevFlix.Domain           → Entidades, Aggregates, Regras de Negócio
├─ DevFlix.Infrastructure  → EF Core, Repositórios, RabbitMQ, Auth

```

### 📐 Princípios aplicados
- Dependências apontam **sempre para dentro**
- O domínio não depende de frameworks
- Infraestrutura é detalhe, não regra

---

## 🛠️ Tecnologias e ferramentas

### Backend
- **.NET 8**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQL Server**
- **MediatR**
- **FluentValidation**
- **Polly**
- **JWT**
- **Keycloak**

### Arquitetura & Padrões
- Clean Architecture
- DDD (Aggregates, Value Objects, Domain Events)
- Unit of Work
- Repository Pattern
- Event-Driven Architecture (EDA)
- MVC Filters

### Mensageria
- RabbitMQ

### Testes
- xUnit
- FluentAssertions
- TDD

### DevOps
- Docker
- Docker Compose
- GitHub Actions (CI/CD)
- Migrations automatizadas

---

## 🧪 Testes

Os testes ficam isolados em `tests/`:

```

tests/
├─ DevFlix.UnitTests
└─ DevFlix.IntegrationTests

````

- Testes unitários focados no domínio e casos de uso
- Testes de integração para infraestrutura e API

---

## 🚀 Como executar o projeto

### Pré-requisitos
- .NET 6 SDK
- Docker e Docker Compose
- SQL Server
- RabbitMQ
- Keycloak

### Subir ambiente com Docker
```bash
docker-compose up -d
````

### Aplicar migrations

```bash
dotnet ef database update
```

### Executar a API

```bash
dotnet run --project src/DevFlix.Api
```

---

## 🔐 Autenticação e Autorização

* Autenticação via **JWT**
* Identity Provider: **Keycloak**
* Controle de acesso por **Roles e Claims**

---

## 📦 CI/CD

Pipeline configurado com **GitHub Actions**:

* Build
* Testes
* Análise de qualidade
* Build de imagem Docker

---

## 📚 Status do projeto

🚧 **Em desenvolvimento**

Funcionalidades sendo implementadas incrementalmente seguindo TDD e DDD.

---

## 📄 Licença

Este projeto está sob a licença MIT.

```

---

