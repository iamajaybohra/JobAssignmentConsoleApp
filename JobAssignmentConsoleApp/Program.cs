using System;
using System.Collections.Generic;

// Define the Employee class
class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Salary { get; set; }
    public List<Role> Roles { get; set; } = new List<Role>(); // Collection to store employee roles
}

// Define the Role class
class Role
{
    public int EmployeeId { get; set; } // Reference to the employee
    public string RoleDescription { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; } // Nullable DateTime for EndDate
}

// Define the main class for job assignment
class JobAssignment
{
    public static void Main()
    {
        // Create an employee object
        Employee emp = new Employee
        {
            EmployeeId = 1,
            FirstName = "Vijay",
            LastName = "Jain",
            Salary = 1200000
        };

        // Create roles for the employee
        Role role1 = new Role
        {
            EmployeeId = emp.EmployeeId,
            RoleDescription = "SDE1",
            StartDate = DateTime.Parse("2022-07-01"),
            EndDate = DateTime.Parse("2023-07-04")
        };

        Role role2 = new Role
        {
            EmployeeId = emp.EmployeeId,
            RoleDescription = "SDE2",
            StartDate = DateTime.Parse("2022-07-05"),
            EndDate = null
        };

        // Add roles to the employee
        emp.Roles.Add(role1);
        emp.Roles.Add(role2);

        // Display employee information along with roles
        Console.WriteLine("Employee Description with its Roles");
        Console.WriteLine($"Employee Name :: {emp.FirstName} {emp.LastName}");
        foreach (Role role in emp.Roles)
        {
            Console.WriteLine($"- {role.RoleDescription}, Start Date: {role.StartDate}, End Date: {role.EndDate ?? DateTime.Now}");
        }
    }
}
