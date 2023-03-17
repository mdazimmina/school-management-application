School Management Application
This is a web application are ongoing for managing schools, including student enrollment, attendance tracking, and academic performance monitoring. The application has both a backend API built with .NET Core 6 and Entity Framework (EF) Code First, and a client-side interface built with Angular.

Features
CRUD operations
RESTful API endpoints for data access
Stored procedures for database operations

Technologies
.NET Core 6
Entity Framework Code First
Angular
Bootstrap
SQL Server


Getting Started
To get started with the application, follow these steps:

1. Clone this repository to your local machine.
2. Install the required dependencies by running the following command in the SchoolManagement.API root directory:
	 dotnet restore
3. For database configuration execute the following command:
	update-database
4. Now run store_procedure.sql file in Sql server management studio.
5. Build the backend API by running the following command:
   dotnet build SchoolManagement.API.csproj
6. Run the backend API by running the following command:
	dotnet run --project SchoolManagement.API.csproj or run from visual studio. 

For Client Side: 
1. Open a new terminal window and navigate to the client-side directory:
 	cd SchoolManagement.UI
2. Install the required dependencies for the client-side application:
   npm install
3. Check client site base url in app/component/services/student.service.ts file  to server site base url. Now the port 5035 is written.
4. Run the client-side application:
	ng serve
5. Open your web browser and navigate to http://localhost:4200/ to access the client-side application.


API Endpoints
The backend API provides the following endpoints for data access:
GET /api/students: Retrieve a list of all students.
GET /api/students/{id}: Retrieve a specific student by ID.
POST /api/students: Create a new student.
PUT /api/students/{id}: Update an existing student.
DELETE /api/students/{id}: Delete a student by ID.

