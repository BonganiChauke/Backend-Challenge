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

## 2. Get the Project
### Option A: Git

Cloning via Git keeps the project up-to-date and makes it easy to pull future changes.

1. Open a terminal or PowerShell:  
   - Windows: Search for "PowerShell" or "Command Prompt" in the Start menu.  
   - (Tip: Use PowerShell for better Git experience.)

2. Navigate to your desired parent folder:  
   ```powershell
   cd C:\Projects
   ```
3. Clone the repository:
     ``` PowerShell
     git clone https://github.com/BonganiChauke/Backend-Challenge.git
     ```
4. Enter the project folder:
``` Powershell
  cd Backend-Challenge
```

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

5. Set the startup project:  
   - In **Solution Explorer**, right-click the project named **Backend Challenge**  
   - Select **Set as Startup Project**  

### 6. Prepare the Database and Run SQL Scripts
- The repository includes `SQLQuery.sql`, which contains the database creation scripts, table definitions, and test data inserts. Follow these steps to set up your local database.

### A. Create a Local SQL Server Database (Using SSMS)

1. Open **SQL Server Management Studio (SSMS)** and connect to your local SQL Server instance:  
   - Examples:  
     - `(localdb)\MSSQLLocalDB` (LocalDB)  
     - `.\SQLEXPRESS` (Express named instance)  
     - `localhost` or `.` (default instance)

2. In **Object Explorer**, right-click **Databases** → **New Database…**

3. In the dialog:  
   - Database name: `DB_API` (or any name you prefer, e.g., `IssueTrackerDb`)  
   - Leave other settings as default  
   - Click **OK**

### B. Run SQL Scripts (`SQLQuery.sql`)

There are two main ways to execute the script.

#### Method 1: SSMS Graphical Execution (Recommended)

1. In SSMS, make sure you're still connected to your server.

2. Open the script file:  
   - Go to **File** → **Open** → **File…**  
   - Navigate to the repository folder and select `SQLQuery.sql`  
   - Click **Open**

3. Ensure the correct database is selected:  
   - In the toolbar, use the dropdown next to the Execute button to select `DB_API` (or your chosen database name)

4. Execute the script:  
   - Press **F5**, or click the **Execute** button (lightning icon)  
   - Wait for the “Command(s) completed successfully” message in the Messages pane

#### Method 2: Command Line with `sqlcmd` (Optional)

If you prefer the terminal:

1. Open **Command Prompt** or **PowerShell** as Administrator.

2. Run one of the following commands (adjust paths and database name):

   - For default/local instance:
     ```cmd
      -S localhost -d BackendChallengeDB -i "C:\Projects\Backend-Challenge\SQLQuery.sql"
     ```
### Confirm Schema and Test Data

1. In SSMS **Object Explorer**:

   - Expand **Databases** → **BackendChallengeDB** → **Tables**  
   - Verify that the expected tables exist (e.g., `Issues`, and any lookup or supporting tables such as users, priorities, statuses, etc., depending on the script)

2. Run a quick test query to confirm data was inserted:

   - Open a new query window in SSMS (ensure it is connected to the `DB_API` database — check the database dropdown in the toolbar)  
   - Paste and execute the following SQL:

     ```sql
     SELECT * FROM Issues;
     ```

### 5. Verify API Endpoints

Once the project is running and the database is set up, test that the API endpoints are working correctly.  
The repository includes a file named `Backend Challenge.http` (an HTTP request file) that you can use directly in Visual Studio.

### Using the Built-in HTTP File (Recommended in Visual Studio)

1. In **Solution Explorer**, locate and double-click the file:  
   `Backend Challenge.http`  
   (It’s usually in the root of the project or in a `tests`/`docs` folder.)

2. Visual Studio’s built-in **REST Client** will open the file with clickable "Send Request" links next to each request.

3. Make sure the API is running:  
   - Press **F5** to start the project (or use the green **Start** button)  
   - Wait until Swagger or the browser opens (confirm the server is listening on http://localhost:5123 or https://localhost:7123)

4. In the `.http` file, click **Send Request** next to each example to test:  
   - The requests should execute against your running API  
   - Check the response pane for status codes (200 OK, 201 Created, etc.) and JSON results

   This file typically includes pre-configured requests for all CRUD operations on the **Issues** resource.

#### Typical Endpoints to Verify

These are the standard RESTful routes you should see working (exact paths depend on the `IssuesController.cs` implementation):

- **GET** `/api/issues`  
  → Retrieve all issues (list)

- **GET** `/api/issues/{id}`  
  → Retrieve a single issue by ID  
  Example: `/api/issues/1`

- **POST** `/api/issues`  
  → Create a new issue  
  (Send a JSON body with properties like title, description, status, priority, etc.)

- **PUT** `/api/issues/{id}`  
  → Update an existing issue  
  (Send updated JSON body)

- **DELETE** `/api/issues/{id}`  
  → Delete an issue by ID

#### Alternative: Test with Postman or Browser/Swagger

- If the `.http` file is missing or you prefer another tool:  
  - Open **Swagger UI** (usually auto-launched at `https://localhost:7123/swagger` or `http://localhost:5123/swagger`)  
  - Use the interactive interface to try each endpoint directly (expand → Try it out → Execute)

- Or import the `.http` file into **Postman** (Postman supports HTTP file import via "Import" → "Raw text" or file upload)

##### What to Check After Each Request

- **200 OK** or **201 Created** → success  
- **404 Not Found** → ID doesn’t exist (normal for GET/DELETE on missing items)  
- **400 Bad Request** → invalid input (check JSON format/body)  
- **500 Internal Server Error** → check Visual Studio Output window or console for exceptions (common: DB connection issues)
     
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



