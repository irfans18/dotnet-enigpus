# Enigpus Library Inventory System

## Project Overview

The Enigpus Library Inventory System is designed to manage and track the books in the Enigpus library, which includes novels and magazines. This system helps librarians easily add, search, and view all books in the inventory through a user-friendly menu interface. The program adheres to object-oriented programming principles, including abstraction and interface implementation, ensuring a robust and scalable solution.

## Features

- **Abstract Class Implementation:** An abstract class `Book` is used to define the common attributes and methods for all types of books.
- **Inventory Service Interface:** An interface `InventoryService` is created to define the necessary operations for managing the book inventory.
- **CRUD Operations:** The `InventoryServiceImpl` class implements the `InventoryService` interface to provide functionality for adding, searching, updating, and deleting books in the inventory.
- **User Menu:** A simple and intuitive menu interface is provided for users to interact with the system, allowing them to perform various inventory operations.

## Technical Details

### Abstract Class `Book`

- Defines common attributes like code, title, publisher, and year of publication.
- Includes an abstract method `getTitle()` that must be implemented by subclasses.

### Interface `InventoryService`

- `addBook(Book book)`: Adds a book to the inventory.
- `searchBook(String title)`: Searches for a book by its title.
- `getAllBooks()`: Retrieves a list of all books in the inventory.

### Class `InventoryServiceImpl`

- Implements the `InventoryService` interface.
- Provides concrete implementations for `addBook()`, `searchBook()`, `getAllBooks()`, and other necessary methods for inventory management.

### User Menu Interface

- A command-line menu that allows users to:
    - Add a new book (novel or magazine).
    - Search for a book by title.
    - View all books in the inventory.
    - Update or delete existing book entries.

## How to Use

1. **Clone the Repository**: Download or clone the repository from GitHub.
2. **Run the Program**: Compile and run the main class to start the user menu.
3. **Follow the Menu Prompts**: Use the menu to add, search, view, update, or delete books in the inventory.

This project serves as a practical application of abstract classes, interfaces, and basic CRUD operations, providing a valuable tool for library management while demonstrating key software development principles.