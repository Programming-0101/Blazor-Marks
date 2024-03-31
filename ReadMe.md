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

## Running the App

When you run the app, it's going to make changes to the database contents. Because the database is included in the repository, you might want to either make a "backup" before you run the app or you might want to mark that file as being "ignored" by git for updates.

```ps
git update-index --assume-unchanged src/Website/Data/myMarks.db
```

----

## Credits/Resources

- [Using Entity Framework Core and SQLite in Blazor](https://www.allhandsontech.com/programming/blazor/how-to-sqlite-blazor/)
- [CRUD w/ Blazor in .NET 8 🔥 All Render Modes (SSR, Server, Wasm, Auto), Entity Framework & SQL Server](https://youtu.be/w8imy7LT9zY?si=EP6TA3iGeAj1i9gZ) (1 hr, 32 min)
- [Dan Roth's Blazor Scaffolding](https://github.com/danroth27/BlazorScaffolding) (garnished/adapted the *Movies* CRUD pages for Marks)
- [Learn Entity Framework Core](https://www.learnentityframeworkcore.com/) *(and the [`[NotMapped]` attribute](https://www.learnentityframeworkcore.com/configuration/data-annotation-attributes/notmapped-attribute))*
- Some images from [Blazor.net](https://blazor.net)
