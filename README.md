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


## Installation & Running Locally

## Step-by-Step Installation Guide  
**SQL Server Management Studio (SSMS) & Visual Studio**

### 1. Install SQL Server Management Studio (SSMS)

SSMS is the primary tool for managing SQL Server databases.

1. Go to the official Microsoft documentation page:  
   [https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

2. Download the latest installer (SSMS 22):  
   Click the download link for **SQL Server Management Studio 22** → [Direct download (vs_SSMS.exe)](https://aka.ms/ssms/22/release/vs_SSMS.exe)  
   *(This is a small bootstrapper that uses the Visual Studio Installer engine.)*

3. Run the downloaded file (`vs_SSMS.exe`):  
   - It will launch the Visual Studio Installer.  
   - Follow the prompts (administrator rights required).  
   - You can optionally select additional components or language packs.  
   - Click **Install** and wait for completion.

4. Launch SSMS:  
   After installation finishes, search for "SQL Server Management Studio" in the Start menu and open it.

### 2. Install Visual Studio

Visual Studio is needed for .NET development, including web and desktop apps that connect to SQL.

1. Go to the official Visual Studio downloads page:  
   [https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/)  
   or directly to the Community edition:  
   [https://visualstudio.microsoft.com/vs/community/](https://visualstudio.microsoft.com/vs/community/)

2. Download **Visual Studio Community** (free edition):  
   - Click **Free download** under Community.  
   - This downloads the web installer (`vs_community.exe` or similar).  

3. Run the installer and select workloads:  
   - In the Visual Studio Installer, go to the **Workloads** tab.  
   - **Required**: Check **ASP.NET and web development** (for web apps, APIs, Blazor, etc.).   
   - Click **Install**.

4. Complete installation and launch:  
   - Once done, launch Visual Studio from the Start menu.

## 2. Get the Project (Continued)

### Option B: ZIP Download (Quick, No Git Needed)

1. Go to the repository on GitHub:  
   [https://github.com/BonganiChauke/Backend-Challenge](https://github.com/BonganiChauke/Backend-Challenge)

2. Click the green **Code** button → **Download ZIP**.

3. Extract the ZIP file to a local folder of your choice:  
   Example: `C:\Projects\Backend-Challenge`

4. Open the extracted folder — inside you'll find:  
   - `Backend Challenge.sln` (the Visual Studio solution file)  
   - Source code folders, `appsettings.json`, etc.

### 3. Open and Run the Project in Visual Studio

This project is an **ASP.NET Core Web API** called **Issue Tracker**, built with .NET, Entity Framework Core, and SQL Server.

1. Launch **Visual Studio** (2022 or newer recommended).

2. Open the solution file:  
   - Go to **File** → **Open** → **Project/Solution**  
   - Navigate to your extracted/cloned folder (e.g., `C:\Projects\Backend-Challenge`)  
   - Select **Backend Challenge.sln** → click **Open**

3. Restore NuGet packages:  
   - Visual Studio typically restores them automatically when the solution opens.  
   - If you see red squiggles or errors:  
     Right-click the solution in **Solution Explorer** → **Restore NuGet Packages**  
     Wait until the process completes (check the **Output** window → Package Manager).

4. Build the solution:  
   - Go to **Build** → **Build Solution** (or press **Ctrl+Shift+B**)  
   - Watch for any build errors in the **Error List** window.  
     Common fixes:  
     - Missing .NET SDK → install the version listed in the project file  
     - NuGet restore failed → try restoring again or clear NuGet cache

5. Set the startup project (if necessary):  
   - In **Solution Explorer**, right-click the project named **Backend Challenge**  
   - Select **Set as Startup Project**  

6. Configure the database connection (very important!):  
   - Open `appsettings.json` or `appsettings.Development.json` in the project.  
   - Update (or verify) the **ConnectionStrings** section to match your local SQL Server setup:

     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=.\\SQLEXPRESS;Database=IssueTrackerDb;Trusted_Connection=True;TrustServerCertificate=True;"
     }
     ```

     
### Project Structure
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



