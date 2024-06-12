## Core (Domain Model) Project

```mermaid
graph TB

subgraph Core - Domain model
   Entities --> Entities_and_Business_Rules
   Value_Objects --> Entities_and_Business_Rules
   Business_Logic --> Entities_and_Business_Rules
   Entities_and_Business_Rules[Entities and Business Rules]
   Aggregate{Aggregate}
   Encapsulation[Leverage Encapsulation]
   Domain_Events[Domain Events]
   Specifications[Specifications]
end

subgraph Infrastructure
   Repository_Interface[Repository Interface]
   Query_Services[Query Services]
end

Entities_and_Business_Rules --> Aggregate
Entities --> Encapsulation
Entities --> Domain_Events
Entities --> Specifications
Aggregate -.-> Repository_Interface
Query_Services -.-> Entities_and_Business_Rules

click Entities "Entities that are related and should change together should be grouped into an Aggregate."
click Encapsulation "Entities should leverage encapsulation and should minimize public setters."
click Domain_Events "Entities can leverage Domain Events to communicate changes to other parts of the system."
click Specifications "Entities can define Specifications that can be used to query for them."
click Repository_Interface "For mutable access, Entities should be accessed through a Repository interface."
click Query_Services "Read-only ad hoc queries can use separate Query Services that don't use the Domain Model."
```

In Clean Architecture, the central focus should be on Entities and business rules.

In Domain-Driven Design, this is the Domain Model.

This project should contain all of your Entities, Value Objects, and business logic.

Entities that are related and should change together should be grouped into an Aggregate.

Entities should leverage encapsulation and should minimize public setters.

Entities can leverage Domain Events to communicate changes to other parts of the system.

Entities can define Specifications that can be used to query for them.

For mutable access, Entities should be accessed through a Repository interface.

Read-only ad hoc queries can use separate Query Services that don't use the Domain Model.

Need help? Check out the sample here:
https://github.com/ardalis/CleanArchitecture/tree/main/sample

Still need help?
Contact us at https://nimblepros.com
