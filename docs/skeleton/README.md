# Dotnet Microservice Blueprint

## Project templete

In this project, I'm using [ardalis-cleanarchitecture](https://github.com/ardalis/cleanarchitecture?tab=readme-ov-file) to init project.

If you want to read more about Clean architecture, you can check out this link: https://medium.com/@linhvuquach/clean-architecture-in-enterprise-application-47d94015c93a

## Project structure

```
🛠️MyAppServiceSolution/
├── #️⃣MyApp.API/
│ ├── 📂Controllers/
│ │ ├── 📂Contributors
│ │ ├── ├── ContributorsController.cs
│ ├── Startup.cs
│ └── …
├── #️⃣MyApp.Application/
│ ├── 📂Contributors/
│ │ ├── 📂Create
│ │ ├── ├── CreateContributorCommand.cs
│ │ ├── ├── CreateContributorHandler.cs
│ │ ├── 📂Delete
│ │ ├── 📂Get
│ │ ├── 📂List
│ │ ├── 📂Update
│ │ ├── 📂Dtos/
│ │ ├── ├── ContributorDto.cs
│ └── …
├── #️⃣MyApp.Domain | Core
│ ├── 📂AggregatesModel/
│ │ ├── 📂 ContributorAggregate/
│ │ ├── ├── 📂 Events/ (part of Domain event pattern)
│ │ ├── ├── ├── ContributorDeletedEvent.cs
│ │ ├── ├── 📂 Handlers/
│ │ ├── ├── ├── ContributorDeletedHandler.cs
│ │ ├── ├── 📂 Specificaitons/ (Entities can define Specifications that can be used to query for them.)
│ │ ├── ├── ├── ├── ContributorByIdSpec.cs
│ │ ├── ├── Contributor.cs
│ │ ├── ├── ContributorStatus.cs
│ ├── 📂 Repositories/
│ │ │   ├── IContributorRepository.cs/
│ ├── 📂 Interfaces/
│ │ │   ├── IContributorService.cs/
│ ├── 📂 Services/
│ │ │   ├── ContributorService.cs/
│ └── …
├── #️⃣MyApp.Infrastructure/
│  ├── 📂Persistent
│  ├── ├── 📂EntityConfigurations
│  ├── ├──  ├── ContributorEntityTypeConfiguration.cs
│  ├── ├── 📂Migrations
│  ├── ├── 📂Repositories/ - Implement interface repositories from MyApp.Domain | Core
│  ├── ├── ├── ContributorRepository.cs
│  ├── ├── 📂Extentions/ - Contains config extensions
│  ├── ├── ├── MediatorExtension.cs
│  ├── MyAppContext.cs
│ └── …
└── 📂MyApp.Tests/
 ├── #️⃣MyApp.UnitTests/
 ├── #️⃣MyApp.IntegrationTests/
```
