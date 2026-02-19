# Issue Management API
- A clean, straightforward RESTful backend service for managing "issues" as part of a backend take-home assignment.
- Built with **ASP.NET Core Web API** (C#) + **SQL Server** (via Entity Framework Core) + GitHub for version control.

## Features
- Create a new issue
- Get all issues
- Get a single issue by ID
- Update an existing issue
- Delete an issue
- Basic input validation
- Proper HTTP status codes & error handling

## Tech Stack

| Layer              | Technology                          |
|--------------------|-------------------------------------|
| Language           | C# (.NET 8 )              |
| Framework          | ASP.NET Core Web API               |
| ORM                | Entity Framework Core              |
| Database           | Microsoft SQL Server               |
| Version Control    | Git + GitHub                       |
| API Documentation  | Swagger (built-in)       |


## Getting Started

### Prerequisites

- .NET 8 SDK (or .NET 6/7 depending on your target)
- SQL Server 2019+ or SQL Server Express
-  Visual Studio 2022

### Installation & Running Locally

## Project Structure

1. **Clone the repository**

```bash
git clone https://github.com/yourusername/your-repo-name.git
cd your-repo-name
```

2. **Restore dependencies**
``` bash
dotnet restore
```

3. **Update connection string**
- Open appsettings.json (or appsettings.Development.json) and set your SQL Server connection:
``` json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=IssueTrackerDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```
4. **Create and migrate the database**
``` bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

5. **Run the API**
```bash
dotnet run
# or
dotnet watch run
```

6. ** The API should now be running at:**
- (http)[http://localhost:5123]
- (https)[https://localhost:7123]

## License 
- MIT License feel free to use for learning purposes.



