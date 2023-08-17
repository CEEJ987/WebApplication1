### What is a Schema?
A **schema** in the context of a database refers to the logical blueprint or structure that defines the organization, arrangement, and relationships of data within a database. It outlines the tables, fields, data types, constraints, and other elements that together define the data model for the database.

### Why do we use Schemas?
Schemas provide structure and consistency to the data stored in a database. They help in organizing data, enforcing data integrity through constraints, and ensuring that data can be queried and manipulated efficiently. Schemas also aid in defining security permissions and access control to different parts of the database.

### Different Types of Database Keys:
- **Primary Key**: A primary key uniquely identifies each record in a table. It ensures data integrity and serves as the basis for creating relationships between tables.
- **Foreign Key**: A foreign key establishes a link between tables by referencing the primary key of another table. It enforces referential integrity and maintains relationships between related data.
- **Composite Key**: A composite key consists of two or more columns that together uniquely identify a record. It's used when no single column can uniquely identify records. Choosing between these keys depends on the nature of the data and the relationships between tables.

### Primary Key:
A **primary key** is a unique identifier for a record in a table. It ensures that each record is distinct and can be used as a reference in other tables via foreign keys.

### Foreign Key:
A **foreign key** is a column or set of columns in one table that refers to the primary key of another table. It establishes relationships between tables, ensuring data consistency and enabling joins for querying related data.

### Composite Key:
A **composite key** is a combination of two or more columns that together form a unique identifier for a record. It's used when a single column isn't sufficient for uniqueness, often in complex relationships.

### Relationships in Relational Databases:
- **1:1 Relationship**: In a 1:1 relationship, one record in a table is associated with exactly one record in another table. This is used to split data that could be logically separated for efficiency or organizational reasons.
- **Many:Many Relationship**: In a many-to-many relationship, multiple records in one table are associated with multiple records in another table. This is achieved through intermediary tables (junction or linking tables).
- **1:Many or Many:1 Relationship**: In a 1:Many relationship, one record in a table is associated with multiple records in another table. In a Many:1 relationship, multiple records in one table are associated with a single record in another table. This is the most common type of relationship.

These relationships help organize and connect data in a way that reflects real-world interactions or dependencies.
