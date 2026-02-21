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

- **Windows 10 or 11**  
- **.NET SDK 6.x – 7.x**  
- **Visual Studio 2022 or newer**  
  (with **ASP.NET and web development** workload installed)  
  → [Download Visual Studio 2022 Community (free)](https://visualstudio.microsoft.com/vs/community/)  
  During installation, select the "ASP.NET and web development" workload.

- **SQL Server**  
  Choose one of the following free options:  
  - **SQL Server Developer Edition** 
    → [Download SQL Server 2025 Developer](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (scroll to Developer edition)  

- **SQL Server Management Studio (SSMS)**  
  → [Download latest SSMS 22.x (recommended)](https://aka.ms/ssms/22/release/vs_SSMS.exe)  
  (Direct installer from Microsoft – run and install)



### Installation & Running Locally

## Project Structure
```text
Backend Challenge (solution)
└── Backend Challenge (project)
    ├── Controllers/
    │   └── IssuesController.cs           # REST API endpoints (CRUD operations)
    ├── Models/
    │   ├── Issues.cs                     # Main entity / database model
    │   └── IssuesCr.cs                   # DTO or model for creating issues
    ├── Properties/
    │   └── launchSettings.json           # IIS Express / launch profiles & ports
    ├── Configuration files
    │   ├── appsettings.json              # Production / base configuration
    │   └── appsettings.Development.json  # Development settings (connection string, etc.)
    ├── Root files
    │   ├── Program.cs                    # Application entry point & configuration
    │   ├── Backend Challenge.http        # REST Client file (for testing in VS)
    │   ├── README.md                     # This documentation file
    │   ├── SQLQuery.sql                  # SQL scripts (table creation, tests, etc.)
    │   ├── .gitignore                    # Files & folders ignored by Git
    │   └── .gitattributes                # Git line-ending & attribute rules
```

1. **Clone the repository**

```bash
git clone https://github.com/BonganiChauke/Backend-Challenge.git
cd Backend-Challenge.git
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


6. ** The API should now be running at:**
- http://localhost:5123
- https://localhost:7123

## Contributing
- Contributions are welcome and appreciated!
- Fork the repository
- Create your feature branch (git checkout -b feature/amazing-feature)
- Commit your changes (git commit -m 'Add some amazing feature')
- Push to the branch (git push origin feature/amazing-feature)
- Open a Pull Request
  
### Please
- Follow the existing code style
- Add comments for new logic
- Update the README if you add/remove features

## License
- This project is licensed under the MIT License – see the LICENSE file for details.
- You are free to use, modify, distribute, and sell this software (with or without changes), as long as you include the original copyright and license notice.
- [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)



