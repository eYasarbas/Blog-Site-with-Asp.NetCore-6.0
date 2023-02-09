# Introduction

This is a sample project that demonstrates how to build a blog website using Asp.Net Core 6.0 framework. The goal of this project is to provide a starting point for developers who want to learn how to develop a full-featured web application using Asp.Net Core.

## Key Features

The website includes all the essential features that a modern blog site should have.
The website is built using the latest Asp.Net Core 6.0 framework and uses a clean and simple design.
The site includes user authentication and authorization, so only registered users can create, edit, and delete blog posts.
The site uses a database to store the blog posts and user information, and uses Entity Framework Core for data access.

## Getting Started

To get started with this project, you'll need to have the following software installed on your computer: .NET 6.0 SDK
Visual Studio or Visual Studio Code
SQL Server
Once you have the required software installed, you can follow these steps to set up the project:
Clone the repository to your local computer using Git.
Open the solution in Visual Studio or Visual Studio Code.
Restore the NuGet packages by right-clicking on the solution and selecting "Restore NuGet Packages".
Update the connection string in the appsettings.json file to match your SQL Server setup.
Run the application by pressing F5 or by clicking on the "Start" button in Visual Studio.
Conclusion:

This project is a great starting point for developers who want to learn how to develop a full-featured web application using Asp.Net Core. The code is well-organized and easy to understand, making it a great resource for learning how to build a blog website with Asp.Net Core.

# Architecture of the Project

The project uses a 5-layer architecture:

1. Presentation Layer
Responsible for handling user interactions and displaying data to the user. In this project, the presentation layer is built using ASP.NET Core MVC.

2. Core Layer
Contains the core logic and functionality of the application, such as shared data structures and algorithms.

3. Business Logic Layer
Implements the business rules and logic of the application. In this project, the business logic is implemented using C# classes.

4. Data Access Layer
Responsible for interacting with the database to retrieve and store data. In this project, the data access layer uses Entity Framework Core to interact with the SQL Server database.

5. Demo Layer
Contains code and data used for demonstration purposes, such as sample data and example code.

Each layer is separated into its own directory, making it easier to maintain and update individual components without affecting the rest of the application. This modular structure also promotes maintainability and scalability, as the code can be easily separated into smaller, more manageable components.
