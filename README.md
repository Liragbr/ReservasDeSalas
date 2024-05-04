# 📅 Room Reservation System

A system to allow users to reserve rooms for events. Developed in C# with ASP.NET Core using .NET 8.0.

## Features

- Create new room reservations
- View existing room reservations
- Make changes to existing room reservations
- Cancel room reservations

## Database

The database integration was done using Entity Framework Core with the SQL Server provider. Migrations were used to manage the database structure.

## Used Packages

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

## How to Use

1. Clone this repository.
2. Configure the database connection in the `appsettings.json` file.
3. Run the migrations to create the database using the `dotnet ef database update` command.
4. Run the application and use the API routes to interact with the room reservations.

## API Routes

- **GET /api/reservations**: Returns all room reservations.
- **GET /api/reservations/{id}**: Returns a specific room reservation by ID.
- **POST /api/reservations**: Creates a new room reservation.
- **PUT /api/reservations/{id}**: Updates an existing room reservation.
- **DELETE /api/reservations/{id}**: Deletes an existing room reservation.

Make sure to test all the features to ensure that the system is functioning as expected.
