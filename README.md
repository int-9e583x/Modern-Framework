# 🦞 ModernDotNetFramework — Enterprise AI Assistant Plane

**EXFOLIATE! EXFOLIATE!**

**ModernDotNetFramework** is a personal AI assistant framework built with .NET 8, inspired by the architecture of **OpenClaw**. It provides a robust, modular, and multi-layered control plane for building AI-driven applications that can run on any OS and any platform.

## 🌟 Key Highlights

- **[Local-first Gateway]** — A single control plane for managing sessions, modules, and system events.
- **[Modular Architecture]** — Decoupled layers including `Gateway`, `CLI`, `Core`, `Domain`, `Infrastructure`, and `Modules`.
- **[CLI Surface]** — Comprehensive command-line interface for onboarding, diagnostics, and service management.
- **[Enterprise Standards]** — Built-in support for Dependency Injection, I18n, and Clean Architecture principles.

## 📁 Project Structure

```text
ModernDotNetFramework/
├── ModernDotNetFramework.Gateway/    # The control plane (Web API)
├── ModernDotNetFramework.CLI/        # Command-line interface tool
├── ModernDotNetFramework.Core/       # Core abstractions and module interfaces
├── ModernDotNetFramework.Domain/     # Domain entities and business rules
├── ModernDotNetFramework.Infrastructure/ # Service implementations and data access
├── ModernDotNetFramework.Modules/    # Pluggable skills and extensions
└── ModernDotNetFramework.Shared/     # Constants, I18n resources, and common models
```

## 🛠️ Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Quick Start
1. Clone the repository:
   ```bash
   git clone https://github.com/int-9e583x/ModernDotNetFramework.git
   ```
2. Run the onboarding wizard (Simulated):
   ```bash
   dotnet run --project ModernDotNetFramework.CLI/ModernDotNetFramework.CLI.csproj onboard
   ```
3. Start the Gateway:
   ```bash
   dotnet run --project ModernDotNetFramework.Gateway/ModernDotNetFramework.Gateway.csproj
   ```

## 🌍 Internationalization (I18n)
The framework follows the **"Lobster Way"** of localization, supporting multiple cultures via standardized resource files in the `Shared` layer.

## 📝 License
Licensed under the MIT License.

