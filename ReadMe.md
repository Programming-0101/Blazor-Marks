# Blazor Marks

> A simple Blazor-8 + SQLite project to manage course marks.

## Prerequisites

It's assumed you have the following installed:

- .NET 8 SDK
- SQLite - `winget install sqlite.sqlite`

## Creating the Database

> Based on the docs to [Create SQLite Database](https://sqldocs.org/sqlite/sqlite-create-database/). You might also want to read [SQLite Syntax: A Complete Beginner's Guide](https://sqldocs.org/sqlite/sqlite-syntax/).

```ps
dotnet ef migrations add InitialCreate -o Data/Migrations
dotnet ef database update
```

----

## Credits

- [Using Entity Framework Core and SQLite in Blazor](https://www.allhandsontech.com/programming/blazor/how-to-sqlite-blazor/)
