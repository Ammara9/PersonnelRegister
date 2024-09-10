## Personnel Register Console Application

### General Overview

This C# console application, **Personnel Register**, allows small businesses to manage and track employee information such as names and salaries. The program is simple yet scalable, offering the ability to add employees and display all registered employees.

### Purpose of the Two Classes

The program is built using two classes:
1. **Employee**
2. **PersonnelRegister**

#### Why Two Classes?

- **Separation of Concerns**: 
    - The **Employee** class represents a single employee with their personal details, which ensures that employee-specific attributes and behaviors are encapsulated within a single class.
    - The **PersonnelRegister** class is responsible for managing multiple employees, providing functionality to add and list them. This approach adheres to the principle of separating responsibilities, making the code modular and easier to maintain.

### Classes and Attributes

#### 1. **Employee Class**
- **Attributes**:
    - `Name`: Stores the employee's name. We use the `string` type as names are textual data.
    - `Salary`: Stores the employee's salary. We use the `decimal` type to represent financial values, which is more precise for currency-related data than `float` or `double`.

- **Methods**:
    - **Constructor**: Initializes the employee with their name and salary.
    - **ToString()**: A built-in method overridden to return a formatted string displaying the employee's name and salary.

#### 2. **PersonnelRegister Class**
- **Attributes**:
    - `_employees`: A private list of `Employee` objects that stores all the registered employees. We use `List<Employee>` as it provides efficient storage and management of multiple employees.

- **Methods**:
    - **AddEmployee(string name, decimal salary)**: Creates a new `Employee` object and adds it to the list. It also outputs a success message when an employee is successfully added.
    - **PrintEmployeeList()**: Loops through the list of employees and prints each employee's information. If no employees are present, it displays a message informing the user that the register is empty.

### Why These Attributes?

- **Name and Salary** are fundamental pieces of information for any employee in a basic register system.
- The decision to make `Name` and `Salary` **private set** properties ensures that once an employee is created, their information cannot be modified externally, which helps prevent unintended changes.

### Program Functionality

The program provides a simple **menu-driven interface** where users can:
1. Add a new employee by entering their name and salary.
2. Print the list of registered employees.
3. Exit the program.

The main loop allows users to perform multiple operations without restarting the application, and proper input validation ensures that the user enters correct data formats (e.g., ensuring the salary is a valid number).

### Nullable Disable Directive

At the start of the program, we used `#nullable disable` to disable nullable reference types. This prevents the compiler from showing warnings about potential null values for reference types like strings. While using nullable reference types is a good practice, we kept them disabled here to make the program simple for a small project.

### Future Expansion

This structure is flexible enough to allow for future expansion. If additional features are required (like updating employee information, removing employees, or persisting data), they can be easily added without modifying the core logic. The use of classes and encapsulation allows easy scalability.

### Conclusion

This program is designed to meet the basic requirements of a small business for managing staff data. It is robust, easy to use, and can be extended with minimal changes to its existing structure.

---

