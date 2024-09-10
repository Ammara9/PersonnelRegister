#nullable disable // Disables nullable reference types, allowing potential nulls without warnings
using System; // Provides basic system functionality like input/output
using System.Collections.Generic; // Provides the List collection for storing employees
using System.Globalization; // Import the namespace for culture-related information


namespace PersonnelRegister // Declares the namespace for the program
{
    // Class to represent an individual Employee
    public class Employee // Defines the Employee class
    {
        public string Name { get; private set; } // Public property to hold employee's name, read-only outside the class
        public decimal Salary { get; private set; } // Public property to hold employee's salary, read-only outside the class

        // Constructor to initialize the Employee object with name and salary
        public Employee(string name, decimal salary) 
        {
            Name = name; // Sets the Name property
            Salary = salary; // Sets the Salary property
        }

        // Override of ToString method to format employee information when printed
        public override string ToString() 
        {
            return $"Name: {Name}, Salary: {Salary.ToString("C", new CultureInfo("sv-SE"))}"; // Formats the name and salary with currency format
        }
    }

    // Class to manage the employee register
    public class PersonnelRegister // Defines the PersonnelRegister class
    {
        private List<Employee> employees; // Private list to hold the employees in the register

        // Constructor to initialize the employee list
        public PersonnelRegister() 
        {
            employees = new List<Employee>(); // Initializes the _employees list as an empty list
        }

        // Method to add a new employee to the register
        public void AddEmployee(string name, decimal salary) 
        {
            var newEmployee = new Employee(name, salary); // Creates a new Employee object
            employees.Add(newEmployee); // Adds the new employee to the _employees list
            Console.WriteLine("Employee added successfully."); // Outputs a success message
        }

        // Method to print the list of all employees
        public void PrintEmployeeList() 
        {
            if (employees.Count == 0) // Checks if the employee list is empty
            {
                Console.WriteLine("No employees in the register."); // Outputs message if there are no employees
            }
            else // If there are employees in the register
            {
                Console.WriteLine("Staff Register:"); // Outputs header for employee list
                foreach (var employee in employees) // Loops through each employee in the list
                {
                    Console.WriteLine(employee.ToString()); // Prints the employee's details
                }
            }
        }
    }

    // Main Program
    class Program // Main class that contains the entry point of the application
    {
        static void Main(string[] args) // Entry point of the program
        {
            PersonnelRegister register = new PersonnelRegister(); // Creates a new instance of PersonnelRegister
            bool running = true; // Boolean to keep the program running in a loop

            while (running) // Main loop to keep the menu running
            {
                Console.WriteLine("Staff Register Menu:"); // Outputs the menu header
                Console.WriteLine("1. Add Employee"); // Option to add a new employee
                Console.WriteLine("2. Print Employee List"); // Option to print the employee list
                Console.WriteLine("3. Exit"); // Option to exit the program
                Console.Write("Choose an option: "); // Prompt to select a menu option
                string input = Console.ReadLine(); // Reads the user input from the console

                switch (input) // Switch statement to handle menu options
                {
                    case "1": // Case for adding an employee
                        Console.Write("Enter Employee Name: "); // Prompts the user for the employee's name
                        string name = Console.ReadLine(); // Reads the employee's name

                        Console.Write("Enter Employee Salary: "); // Prompts the user for the employee's salary
                        if (decimal.TryParse(Console.ReadLine(), out decimal salary)) // Tries to parse the salary input
                        {
                            register.AddEmployee(name, salary); // Calls the method to add an employee
                        }
                        else // If salary input is not valid
                        {
                            Console.WriteLine("Invalid salary input. Please enter a valid number."); // Outputs error message
                        }
                        break;

                    case "2": // Case for printing the employee list
                        register.PrintEmployeeList(); // Calls the method to print all employees
                        break;

                    case "3": // Case for exiting the program
                        running = false; // Sets running to false, exiting the loop
                        Console.WriteLine("Exiting..."); // Outputs exit message
                        break;

                    default: // Default case for invalid menu options
                        Console.WriteLine("Invalid option, please try again."); // Outputs error message for invalid input
                        break;
                }
            }
        }
    }
}

