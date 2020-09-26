using System;
using System.Collections.Generic;
using TEams.Class;

namespace TEams
{
    class Program
    {
        public static List<Department> departments = new List<Department>();
        public static List<Employee> employees = new List<Employee>();
        public static Dictionary<string,Project> projects = new Dictionary<string, Project>();
        static void Main(string[] args)
        {
            // create some departments
            CreateDepartments();

            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!

            // print all employees
            PrintEmployees();

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();

        }
        /**
         * Create departments and add them to the collection of departments
         */
        private static void CreateDepartments()
        {
            departments.Add(new Department(001, "Marketing"));
            departments.Add(new Department(002, "Sales"));
            departments.Add(new Department(003, "Engineering"));
        }

        /**
         * Print out each department in the collection.
         */
        private static void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");

        
            foreach (Department departmentObject in departments)
            {

                Console.WriteLine(departmentObject.Name);
            }
        }
        /**
         * Create employees and add them to the collection of employees
         */
        private static void CreateEmployees()
        {
            Employee employee = new Employee();
            employee.EmployeeId = 001;
            employee.FirstName = "Dean";
            employee.LastName = "Johnson";
            employee.Email = "djohnson@teams.com";
            employee.Salary = 60000;
            employee.Department = departments[2];
            employee.HireDate = "08/21/2020";
            employees.Add(employee);

            employees.Add(new Employee(002, "Angie", "Smith", "asmith@teams.com", departments[2], "08/21/2020"));
            employees.Add(new Employee(003, "Margaret", "Thompson", "mthompson@teams.com", departments[0], "08/21/2020"));
            employees[1].Salary = (employees[1].Salary * 10) / 100 + employees[1].Salary;
        }
        /**
         * Print out each employee in the collection.
         */
        private static void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");

            foreach (Employee employeeName in employees)
            {

                Console.WriteLine(employeeName.FullName + " " +"(" + employeeName.Salary+")" + " " + employeeName.Department.Name);
            }
        }

        /**
         * Create the 'TEams' project.
         */
        private static void CreateTeamsProject()
        {
                Project projectss = new Project("TEams", "Project Management Software", "10/10/2020", "11/10/2020");

                foreach (Employee employee in employees)
                {
                    if (employee.Department.Name == "Engineering")
                    {
                        projectss.TeamMembers.Add(employee);
                        projects[projectss.Name] = projectss;
                    }
                }
            }   
    /**
     * Create the 'Marketing Landing Page' project.
     */
    private static void CreateLandingPageProject()
    {
        Project projectsss = new Project("Marketing Landing Page", "Lead Capture Landing Page for Marketing", "10/10/2020", "10/17/2020");

        foreach (Employee employee in employees)
        {
            if (employee.Department.Name == "Marketing")
            {
                projectsss.TeamMembers.Add(employee);
                projects[projectsss.Name] = projectsss;
            }
        }
    }
        /**
         * Print out each project in the collection.
         */
        private static void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");

            foreach(KeyValuePair<string, Project> newDic in projects) { 
             
            Console.WriteLine(newDic.Key +": " + projects[newDic.Key].TeamMembers.Count);
            }
        }
    }
}
