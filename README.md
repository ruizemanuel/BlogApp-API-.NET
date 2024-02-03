# .NET Backend for Angular Blog

This project is the .NET backend developed to complement the Angular Blog Project. Here, you will find information about the main features of the backend, how to install, run it, and the necessary configuration.

## Key Features

- **RESTful API:** Developed using ASP.NET, it provides a RESTful API to manage user authentication, blog posts, upload images and other functionalities.

- **Database:** Utilizes a SQL Server database through Entity Framework to store data such as users, blog posts, and other relevant information.

- **JWT Authentication:** Implements JWT authentication to ensure security in interactions with the Angular frontend. Utilizes the JwtBearer and IdentityModel.Tokens libraries for handling JWT tokens.

- **Technologies Used:**
  - **Entity Framework:** The project leverages Entity Framework for database management and querying.

  - **.NET 8:** Developed using .NET 8, taking advantage of the latest features and improvements in the framework.

  - **SQL Server:** The backend is configured to work with SQL Server as the database engine.

## Installation

1. **Download the Project:**
   - Clone or download the project

2. **Install Dependencies:**
   - Open the project in Visual Studio
   - If you don't have Visual Studio installed, you can download it [here](https://visualstudio.microsoft.com/).

3. **Database Configuration:**
	- If you don't have SQL Server installed, you can download it [here](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).
   - Configure the SQL Server connection in appsettings.json or you can leave it as it is.


## Run the Backend

Start Visual Studio and open the BlogApp.API.sln file. Then go to Tools - Nuget Package Manager - Package Manager Console and run this commands to run the corresponding migrations to your local DB:
- `Update-Database -Context "ApplicationDbContext"`
- `Update-Database -Context "AuthDbContext"`
Finally run the app by clicking the "play" button on the toolbar.


## Autor

  

👤 **Ruiz, Jose Emanuel**

  

* GitHub: [ruizemanuel](https://github.com/ruizemanuel)
