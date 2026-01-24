# Library Management System

ITI Full OOP project using C# – Console Application.

## Overview
This project simulates a simple library management system. Admin can:
- Add books and members
- Make users Borrow and return books
- View borrowed books and available books
- View List of Members 

The system uses Object-Oriented Programming principles to manage data in memory.

## Features
- **Book Management**: Add and track books with ID, Title, Author, and Availability.
- **Member Management**: Add members and track their borrowed books.
- **Borrow/Return**: Members can borrow books if available and return them with limitations to borrowed books
- **Console Interface**: Simple console-based user interaction.

## Technologies
- C# (OOP)
- .NET9 Console Application
- Visual Studio Solution

## Project Structure
- `Book.cs` – Defines the Book class and its properties.
- `Member.cs` – Defines the Member class and manages borrowed books.
- `Library.cs` – Manages collections of books and members.
- `Program.cs` – Main entry point with user interface logic.
- `.sln` / `.csproj` – Visual Studio solution/project files.

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/NdaYoussef/Library-Managment-System.git
