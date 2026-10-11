<div align="center">

# 🏥 Smart Care

### Hospital Management System

**A C# Windows Forms desktop application for organizing hospital staff information and exploring day-to-day hospital management workflows.**

[![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.7.2-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)
[![Windows Forms](https://img.shields.io/badge/Windows_Forms-Desktop-0078D4?style=flat-square)](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/)
[![SQL Server](https://img.shields.io/badge/SQL_Server-Database-CC2927?style=flat-square)](https://www.microsoft.com/en-us/sql-server)

[Overview](#-project-overview) • [Features](#-key-features) • [Installation](#-run-locally) • [Links](#-project-links)

</div>

---

## 📖 Project Overview

**Smart Care** is a Windows-based **Hospital Management System** built with **C#**, **Windows Forms**, **.NET Framework 4.7.2**, and **Microsoft SQL Server**. It provides role-specific screens for administrators, doctors, and nurses, along with interfaces for managing doctor and employee information. The project demonstrates desktop UI development and database-connected CRUD operations in a healthcare administration setting.

> **Status:** Educational/development project. Some modules are UI prototypes rather than complete workflows. It is **not production-ready** for real patient data.

## ✨ Key Features

- 🔐 **Role-based login screens** for admin, doctor, and nurse accounts.
- 🧑‍💼 **Admin dashboard** to access hospital management modules.
- 👨‍⚕️ **Doctor management** to add, view, update, delete, and search doctor information.
- 👩‍⚕️ **Doctor profile and portal** screens for viewing doctor details.
- 👩‍⚕️ **Nurse registration and dashboard** with staff-related information.
- 👥 **Employee management** screens for searching and viewing employee records.
- 📅 **Additional UI modules** for appointments, billing/payment, and ambulance services (some functionality is incomplete).

## 🛠️ Main Technologies

| Technology | Usage |
| --- | --- |
| **C#** | Application logic |
| **.NET Framework 4.7.2** | Desktop application runtime |
| **Windows Forms (WinForms)** | Graphical user interface |
| **Microsoft SQL Server** | Database storage |
| **ADO.NET (`System.Data.SqlClient`)** | Database connectivity and queries |
| **Visual Studio** | Building, running, and debugging |

## 📦 Dependencies & Requirements

To build and use Smart Care locally, install:

- **Windows** operating system.
- **Visual Studio** with the **.NET desktop development** workload.
- **.NET Framework 4.7.2 Developer Pack / Targeting Pack** for building the project.
- **Microsoft SQL Server** or **SQL Server Express** for database-backed screens.
- **SQL Server Management Studio (SSMS)** *(optional, recommended)* for database administration.
- **Git** *(optional)* to clone the repository; downloading a ZIP works too.

The `.csproj` references built-in .NET Framework assemblies, including `System`, `System.Core`, `System.Data`, `System.Drawing`, and `System.Windows.Forms`. **No third-party NuGet packages are declared in the current project file**, so there is no separate `npm install` or NuGet package installation step documented for this project.

## 🚀 Run Locally

### Step 1 — Clone the repository

```bash
git clone https://github.com/billalhossain404/Smart-Care.git
cd Smart-Care
```

Or download the project using **Code → Download ZIP** on GitHub.

### Step 2 — Open in Visual Studio

1. Open `Smart-Care.slnx` using a Visual Studio version that supports `.slnx` solutions.
2. If `.slnx` is unsupported in your installed version, open `Smart-Care/Smart-Care.csproj` directly.
3. Verify that the **.NET Framework 4.7.2 targeting pack** is installed.

### Step 3 — Configure the database

1. Install SQL Server / SQL Server Express.
2. Create or restore a **SQL Server database matching the tables and columns used by the source code**.
3. Find the SQL connection strings in the `.cs` files (search for `Data Source=`, `SqlConnection`, or `Initial Catalog=`).
4. Replace the original developer's server/database settings with your own SQL Server instance, database name, and authentication settings.

Example connection string **(illustrative only; adjust it to your setup)**:

```csharp
string connectionString =
    @"Data Source=.\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;TrustServerCertificate=True";
```

> **Important:** The repository does not provide a ready-to-run database setup/migration script. Building the Windows Forms UI is possible with the prerequisites above, but **database-dependent operations need the matching database schema and test records**. Some forms contain different hard-coded connection settings; update each one you use.

### Step 4 — Build and run

1. Set **Smart-Care** as the startup project in Visual Studio.
2. Select **Build → Build Solution**.
3. Press **F5** to start the app (or **Ctrl + F5** to run without debugging).
4. Use the homepage to navigate the available modules. Database-backed logins and records require your local SQL Server setup.

## 🗂️ Project Structure

```text
Smart-Care/
├── Smart-Care.slnx           # Visual Studio solution
├── Smart-Care/
│   ├── Smart-Care.csproj     # .NET Framework / WinForms project
│   ├── Program.cs            # Application entry point
│   ├── Homepage.cs           # Homepage / doctor search
│   ├── Dashboard.cs          # Admin dashboard
│   ├── admin-login.cs        # Admin login
│   ├── doctor-assign.cs      # Doctor management
│   ├── D-Login.cs            # Doctor login
│   ├── Add_Nurse.cs          # Nurse registration
│   ├── Nurse_login.cs        # Nurse login
│   ├── Appointment.cs        # Appointment screen
│   ├── Payment.cs            # Payment screen
│   ├── App.config            # Application configuration
│   └── ...                   # Other forms and resources
```

## 🔗 Project Links

| Link | Details |
| --- | --- |
| **Live Demo** | **Not available** — this is a Windows desktop application, not a deployed website. |
| **Source Code** | [GitHub Repository](https://github.com/billalhossain404/Smart-Care) |
| **Download Project** | [Download ZIP](https://github.com/billalhossain404/Smart-Care/archive/refs/heads/main.zip) |
| **Report Issues** | [GitHub Issues](https://github.com/billalhossain404/Smart-Care/issues) |
| **Developer** | [@billalhossain404](https://github.com/billalhossain404) |

## 🔒 Development Notes

This repository is intended for learning and demonstration. Before considering real-world use, it would need secure password storage, consistent database configuration, authorization checks, validation, testing, and privacy protections.

## 👨‍💻 Author

Developed by **[Billal Hossain](https://github.com/billalhossain404)**.

---

<div align="center">
  <sub>Built with C# • Windows Forms • SQL Server</sub>
  <p>⭐ If this project helps you, consider starring the repository!</p>
</div>
