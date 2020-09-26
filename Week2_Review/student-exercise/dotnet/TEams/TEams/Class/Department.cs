using System;
using System.Collections.Generic;
using System.Text;

namespace TEams.Class
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public Department(int departmentId, string name)
        {
            Name = name;
            DepartmentId = departmentId;

        }
    }
}
