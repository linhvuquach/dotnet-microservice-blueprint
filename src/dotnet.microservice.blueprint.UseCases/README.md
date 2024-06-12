## Use Cases Project

```mermaid
graph TB

subgraph Domain
   Domain_Model[Domain Model]
end

subgraph Use_Cases
   Use_Cases_Project[Use Cases Project]
   CRUD_Operations[CRUD Operations]
   Complex_Activities[Complex Activities]
   Commands[Commands]
   Queries[Queries]
end

subgraph UI_Infrastructure
   UI_Project[UI Project]
   Infrastructure_Project[Infrastructure Project]
end

Domain_Model --> Use_Cases_Project
Use_Cases_Project --> CRUD_Operations
Use_Cases_Project --> Complex_Activities
Use_Cases_Project --> Commands
Use_Cases_Project --> Queries
Use_Cases_Project --> UI_Project
Use_Cases_Project --> Infrastructure_Project

click Use_Cases_Project "The Use Cases project is a thin layer that wraps the Domain Model."
click CRUD_Operations "Use Cases can include simple CRUD operations."
click Complex_Activities "Use Cases can include more complex activities."
click Commands "Use Cases are often grouped into Commands (following CQRS)."
click Queries "Use Cases are often grouped into Queries (following CQRS)."
click UI_Project "Having Use Cases as a separate project can reduce the amount of logic in UI projects."
click Infrastructure_Project "Having Use Cases as a separate project can reduce the amount of logic in Infrastructure projects."
```

In Clean Architecture, the Use Cases (or Application Services) project is a relatively thin layer that wraps the domain model.

Use Cases are typically organized by feature. These may be simple CRUD operations or much more complex activities.

Use Cases should not depend directly on infrastructure concerns, making them simple to unit test in most cases.

Use Cases are often grouped into Commands and Queries, following CQRS.

Having Use Cases as a separate project can reduce the amount of logic in UI and Infrastructure projects.

For simpler projects, the Use Cases project can be omitted, and its behavior moved into the UI project, either as separate services or MediatR handlers, or by simply putting the logic into the API endpoints.

For ideas on organizing your Use Case project's folder structure, see this thread:
https://twitter.com/ardalis/status/1686406393018945536

Need help? Check out the sample here:
https://github.com/ardalis/CleanArchitecture/tree/main/sample

Still need help?
Contact us at https://nimblepros.com
