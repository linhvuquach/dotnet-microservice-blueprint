## Infrastructure Project

```mermaid
graph BT

subgraph Infrastructure
   Infrastructure_Project[Infrastructure Project]
   EF[Entity Framework]
   Files[Files]
   Email[Email]
   Web_Services[Web Services]
   Cloud_Services[Cloud Services]
   Infrastructure_Implementations[Implement interfaces]
end

subgraph Domain
   Core[Core]
   Use_Cases[Use Cases]
   Interfaces[Interfaces]
end

Infrastructure_Project --> EF
Infrastructure_Project --> Files
Infrastructure_Project --> Email
Infrastructure_Project --> Web_Services
Infrastructure_Project --> Cloud_Services
Infrastructure_Implementations -.-> Interfaces
Infrastructure_Implementations --> |wire up at startup| Dependency_Injection[Dependency Injection]

Core --> Interfaces
Use_Cases --> Interfaces

click Infrastructure_Project "The Infrastructure Project should have code concerned with frameworks and drivers such as EF, Files, Email, Web Services, Azure/AWS/GCP, etc."
click Infrastructure_Implementations "Infrastructure classes implement interfaces found in the Core (Use Cases) projects."
click Dependency_Injection "These implementations are wired up at startup using Dependency Injection."
```

In Clean Architecture, Infrastructure concerns are kept separate from the core business rules (or domain model in DDD).

The only project that should have code concerned with EF, Files, Email, Web Services, Azure/AWS/GCP, etc is Infrastructure.

Infrastructure should depend on Core (and, optionally, Use Cases) where abstractions (interfaces) exist.

Infrastructure classes implement interfaces found in the Core (Use Cases) project(s).

These implementations are wired up at startup using DI. In this case using `Microsoft.Extensions.DependencyInjection` and extension methods defined in each project.

Need help? Check out the sample here:
https://github.com/ardalis/CleanArchitecture/tree/main/sample

Still need help?
Contact us at https://nimblepros.com
