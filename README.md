# ASP.NET Core School CMS

This project is a CMS for a school, managing Students, Teachers, and Courses.

The MVP includes CRUD functionality for the school database, along with API endpoints, views, and dynamic routing.

## Main Components

### 1. Database Connection

SchoolDbContext.cs establishes the connection to the SQL Server.

### 2. API Controllers

Web API Controllers such as TeacherAPIController.cs, SchoolAPIController.cs, and CourseAPIController.cs provide endpoints for data extraction and manipulation.

### 3. MVC Controllers

MVC Controllers handle routing to dynamic pages.

### 4. Models

Model classes define the structure of the entities used.

### 5. Views

#### Example (TeacherPage Folder)

- **List**: all teachers.
- **Show**: a specific teacher.
- **New**: form for a new teacher.
- **Create**: adds a new teacher to the database.
- **ConfirmDelete**: confirms deletion of a record.
- **Delete**: removes a teacher from the database.
- **Edit**: a form to edit teacher information.
- **Update**: update a teacher.

## Features

### API Endpoints

- **GET /api/teacher/ListTeachers**: all teachers.
- **GET /api/teachers/GiveTeacherInfo/{TeacherId}**: a single teacher by ID.
- **POST /api/teacher/AddTeacher**: new teacher.
- **DELETE /api/teacher/DeleteTeacher/{TeacherId}**: removes a teacher by ID.
- **PUT /api/teacher/UpdateTeacher/{TeacherId}**: updates a teacher (request body: `{Teacher}`).

