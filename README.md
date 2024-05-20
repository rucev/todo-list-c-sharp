# C# To-Do List Console Application
This is a simple console-based To-Do List application written in C#. The application allows users to manage a list of tasks through a text-based interface. Users can view all tasks, add new tasks, remove existing tasks, and exit the application.

## Features
- View All Tasks: Display all the tasks currently in the to-do list.
- Add a Task: Add a new task to the to-do list.
- Remove a Task: Remove an existing task from the to-do list by selecting its number.
- Exit: Exit the application.

## Requirements
 - [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

## How to Use
**1. Clone the Repository:**
```sh
git clone https://github.com/rucev/todo-list-c-sharp
```
```sh
cd todo-list-c-sharp
```

**2. Build the Project:**
```sh
cd app
```
```sh
dotnet build
```

**3. Run the project:**
```sh
dotnet run
```

**4. Interact with the Application:**

Follow the on-screen instructions to manage your to-do list.

## Detailed Instructions
- **See All TODOs:** Press S or s to view all tasks.
  - If the list is empty, you will see "Nothing to do."
- **Add a TODO:** Press A or a to add a new task.
  - When prompted, type in the task and press Enter.
  - If you leave the input empty and press Enter, you will see "Invalid Input!"
- **Remove a TODO:** Press R or r to remove a task.
  - You will see a list of all tasks with numbers.
  - Type the number of the task you want to remove and press Enter.
  - If the input is invalid, you will be prompted to enter a valid option.
- **Exit the Application:** Press E or e to exit.
  - You will see "Bye!" and the application will close.

## Code Overview
- The application uses a List<string> to store the to-do items.
- The main loop displays options and handles user input for different operations.
- Methods:
  - SeeAll(): Displays all tasks or a message if the list is empty.
  - AddTodo(): Prompts the user to add a task to the list.
  - RemoveTodo(): Allows the user to remove a task by its number.

## Example
```
Hello!
[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
A
What do you need to do?
Buy groceries
Todo added to the list!


[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
S
[1] Buy groceries


[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
R
Select todo to delete:
[1] Buy groceries
1
Updated list:
Nothing to do.


[S]ee all TODOs
[A]dd a TODO
[R]emove a TODO
[E]xit
E
Bye!
```
