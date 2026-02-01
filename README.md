# Modern .NET 8 Enterprise Framework

A production-ready, clean architecture .NET 8 Web API framework with built-in **Multi-language (I18n)** support and enterprise-grade project structure.

## 🌟 Advanced Features

- **Multi-language Support (I18n)**: Integrated localization using standard `.resx` files. Supports English (`en`) and Chinese (`zh`).
- **Enterprise Project Structure**:
  - `Api`: Entry point and Controllers.
  - `Application`: Business logic interfaces, DTOs, and application services.
  - `Domain`: Core entities and domain logic.
  - `Infrastructure`: External integrations, DB access, and service implementations.
  - `Shared`: Cross-cutting concerns like common models, resources, and utilities.
- **Clean Architecture**: Strict dependency flow from outer layers to the core.
- **Swagger/OpenAPI**: Interactive API documentation.

## 📁 New Folder Structure

```text
ModernDotNetFramework/
├── ModernDotNetFramework.Api/           # Controllers & Configuration
├── ModernDotNetFramework.Application/   # Application Interfaces & Logic
├── ModernDotNetFramework.Domain/        # Entities & Domain Models
├── ModernDotNetFramework.Infrastructure/# Implementations & Data
├── ModernDotNetFramework.Shared/        # Resources (I18n) & Common Models
└── ModernDotNetFramework.sln            # Solution File
```

## 🌍 Internationalization (I18n)

The framework supports switching languages via the `Accept-Language` header or `culture` query string.

- **English**: `Accept-Language: en`
- **Chinese**: `Accept-Language: zh`

Try the `GET /api/hello` endpoint to see localized greetings!

## 🛠️ Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Running the Project
```bash
dotnet run --project ModernDotNetFramework.Api/ModernDotNetFramework.Api.csproj
```

---
*Enhanced by Manus Agent*
