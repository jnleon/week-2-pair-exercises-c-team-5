using System;
using System.Collections.Generic;
using System.Text;

namespace TEams.Class
{
    public class Employee
    {
    public long EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public double Salary { get; set; }
    public Department Department { get; set; }  
    public string HireDate { get; set; }
    public string FullName { 
            get
            {
                return LastName + ", " + FirstName;
         }
     }
    
    public const double STARTINGSALARY = 60000;

    public Employee(long employeeID, string firstName, string lastName, string email, Department department, string hireDate)
        {
            EmployeeId = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Department = department;
            HireDate = hireDate;
            Salary = STARTINGSALARY;
        }
        public Employee()
        {

        }
        
    public void RaiseSalary(double percent)
        {
            Salary += percent + (percent* Salary);

        }


        }
    }
