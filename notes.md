# Notes

# Environment Installation and Config

- Install VS 2022
  - Modify install:
    - Select workload: "ASP.NET and web development" workload
    - Individual components tab, add:
      - .NET:
        - .NET Framework project and item templates
        - [.NET Framework 4.8.1 *]
- Create a new project
  - ASP.NET Web Application (.NET Framework)
  - Choose:
    - C#, Web Form
    - Web Forms
    - Framework: .NET Framework 4.8+
    - [Authentication: Windows]

## Project Anatomy

```text
\Default.aspx (routes):
  *.aspx: UI files
    .\*.aspx.cs: supporting logic files ('behind code')
\Scripts\*.js
  - Bootstrap and JQuery scripts are preinstalled
\Content\*.css
  - Bootstrap css (with map) files herre
\App_Start
  - BundleConfig.cs
  - RouteConfig.cs
```

## Run Dev Server

[IIS Express] button: to build and run the dev web environment
[Refresh] button to the right if the page is already open

```text
The default template includes:
Home Page: \Default.aspx
   About Page: \About.aspx
   ContactPage: \Contact.aspx
```

- Add another page:
  - Rt-click solution: Add | Web Form
    - Design editor: click the Split tab (bottom left of code window)
    - View | Toolbox, General: note you need to be in design mode to see some of the Toolbox items
    - This automatically creates a route: <http://localhost:[port]/formname>
- The .aspx page:
  - CodeBehind="formname.aspx.cs": imports the logic
  - runat="server"

## Designer Mode and Toolbox

Create a simple form with ASP.NET controls (UI designer method: Toolbox: Standard)

## Database

- View | SQL Server Object Explorer
- SQL Server | (localdb)\MSSQLLocalDB | Databases
  - New DB (e.g.) InfoDB
- Add New Table (this creates a sql script that you run)
  - [NewDB]\Tables
    - You can add these attributes:
    - Name: name, Data Type: varchar(50)
    - Name: email, Data Type: varchar(50)
    - Name: password, Data Type: varchar(50)
  - It will generate a T-SQL script for you
- Run the script: Update (button under 'dbo.Table[Design]' pane's tab)
  - Update Database button
- This generates:
  - SQL Server | (localdb)\MSSQLLocalDB | Databases | [NewDB]\Tables\dbo.Table
  - Double click dbo.Table to open it

Configure a connection between the solution and the database

- NOTE: The "Integrated Security=" option is more complicated for SQL Server
- Solution | Web.config

Now you can run and enter new user info: when you click submit the info is added to the database: right click the table, view data

## Client-side validators

Toolbox, Validation

## GridView

Design, ToolBox: Data | GridView

---

## SQL Server

Here is the information you need for the connection string in the \web.config

First find out if the server is the default instance, or else determine its named instance

1. Connect via SMSS, then execute:

   ```sql
   SELECT
       @@SERVERNAME AS ServerName,
       SERVERPROPERTY('InstanceName') AS InstanceName;
   ```

   If InstanceName is NULL then it's the default instance.

   - Default instance: SERVERNAME

   - Named instance: SERVERNAME\INSTANCE

1. Fill in the rest with:

   - Alias: this is a label you want to use to refer to the connection in the ASP.NET code
   - SERVERNAM: Update this with your actual SERVER (or SERVER\INSTANCE) name
   - DATABASE: Update this with your actual Database name
   - Security/Credentials: use either 'Integrated Security', or the database credentials ('User Id' and 'Password')
     (See the following examples)

   For Windows Authentication ('Integrated Security'):

   ```xml
   <connectionStrings>
   <add name="Alias"
         connectionString="Server=SERVERNAME;Initial Catalog=DATABASE;Integrated Security=True;"
         providerName="System.Data.SqlClient"/>
   </connectionStrings>
   ```

   Or use SQL Authentication ('User Id' and 'Password'):

   ```xml
   <connectionStrings>
   <add name="Alias"
         connectionString="Server=SERVERNAME;Initial Catalog=DATABASE;User Id=USER;Password=PASSWORD};"
         providerName="System.Data.SqlClient"/>
   </connectionStrings>
   ```
