# Home-Appliance-Rental-System

This is the Home Appliance Rental System project for NCC Level 4 Diploma in Computing School Project.

## Prerequisites

Before you begin, ensure you have the following prerequisites installed on your local machine:

- .NET SDK (Software Development Kit)

- MSSQL Server

- Visual Studio

## Getting Started

Follow these steps to set up the project locally:

1. Clone the Repository:

```
git clone git@github.com:ThaeNandarSeint/Home-Appliance-Rental-System.git
```

2. Navigate to the Project Directory:

```
Open it in Visual Studio by selecting File > Open > Project/Solution and locating the .sln file.
```

3. Install Dependencies:

```
dotnet restore 

(In Visual Studio, dependencies may restore automatically. Otherwise, right-click the solution and select Restore NuGet Packages.)
```

4. Set Up a Database in Microsoft SQL Server

```
Open Microsoft SQL Server Management Studio (MSSQL) and connect to your local SQL Server instance.

Right-click on Databases and choose New Database… to create a new database.

Give the database name (e.g., HomeApplianceRental) and click OK.
```

5. Build the Project:

```
dotnet build

(In Visual Studio, go to Build > Build Solution.)
```

6. Run the Project:

```
dotnet run

(In Visual Studio, press F5 to start debugging, or Ctrl + F5 to run without debugging.)
```