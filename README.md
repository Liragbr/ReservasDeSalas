# 📅 Room Reservation System


This system simplifies the process of reserving rooms for various events. Whether you're planning meetings, conferences, or other gatherings, our system offers a user-friendly solution for managing room reservations effectively.

With features like creating, viewing, updating, and canceling reservations, along with seamless integration with a SQL Server database using Entity Framework Core, our system provides flexibility and reliability.

## Features

- Create new room reservations
- View existing room reservations
- Make changes to existing room reservations
- Cancel room reservations

## Database

The database integration was done using Entity Framework Core with the SQL Server provider. Migrations were used to manage the database structure.

```
dotnet ef migrations add *InitialCreate*
```
```
dotnet ef database update
```

## Used Packages

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

## How to Use

1. Clone this repository.
2. Configure the database connection in the `appsettings.json` file.
```
"DefaultConnection": "Server=exmp\\SQLEXPRESS;Database=ReservationSystemDb;Trusted_Connection=True;MultipleActiveResultSets=true"
```
```
"DefaultConnection": "Server=exmp\\SQLEXPRESS;DataBase=ReservationSystemDb;Integrated Security=SSPI;TrustServerCertificate=True"
```

## API Routes

- **GET /api/reservations**: Returns all room reservations.
- **GET /api/reservations/{id}**: Returns a specific room reservation by ID.
- **POST /api/reservations**: Creates a new room reservation.
- **PUT /api/reservations/{id}**: Updates an existing room reservation.
- **DELETE /api/reservations/{id}**: Deletes an existing room reservation.

Make sure to test all the features to ensure that the system is functioning as expected.

