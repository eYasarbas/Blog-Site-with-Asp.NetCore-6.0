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

The project uses a 5-tier architecture:

1. Presentation Layer 
The backend codes on the controller side are located in this section. In this project, the presentation layer was created using ASP.NET Core MVC.

2. Core Layer Contains the basic logic and functionality of the application, such as shared data structures and algorithms.

3. Business Logic Layer Validations are controlled in this layer. For example, it must be max 50 characters. 

4. Data Access Layer 
In this layer, infrastructure is prepared for database crud operations. For example, Creat-Read-Update-Delete operations are prepared.

5. Demo Layer Contains code and data used for demonstration purposes such as sample data and sample code.

Each layer is separated into its own directory, making it easier to maintain and update individual components without affecting the rest of the application. This modular structure also promotes maintainability and scalability, as the code can be easily separated into smaller, more manageable components.
