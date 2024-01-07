# Employee Role Assignment

This C# program demonstrates a simple employee role assignment system. It defines classes for `Employee`, `Role`, and includes a `JobAssignment` program that creates an employee, assigns roles, and displays the employee's information with associated roles.

## Usage

To run the program, simply execute the `JobAssignment.Main` method.

```csharp
class JobAssignment
{
    public static void Main()
    {
        // Code for creating Employee and assigning Roles
        // ...

        // Display employee information with roles
        // ...
    }
}
```

## Table Schema

This section outlines the table schema for the `Employee` and `Role` entities, providing a structured representation of the database design.

### Employee Table Schema:

| Column Name | Data Type | Description |
|-------------|-----------|-------------|
| EmployeeId  | INT       | Primary Key |
| FirstName   | VARCHAR   |             |
| LastName    | VARCHAR   |             |
| Salary      | DECIMAL   |             |

### Role Table Schema:

| Column Name      | Data Type  | Description           |
|------------------|------------|-----------------------|
| EmployeeId       | INT        | Foreign Key (References Employee.EmployeeId) |
| RoleDescription  | VARCHAR    |                       |
| StartDate        | DATETIME   |                       |
| EndDate          | DATETIME   | Nullable              |









