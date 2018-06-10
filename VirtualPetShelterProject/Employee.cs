using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
     abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeStartDate { get; set; }

        public Employee()
        {
            //default ctor
        }

        public Employee(string name, int employeeID, string employeeType, string employeeStartDate)
        {
            this.Name = name;
            this.EmployeeID = employeeID;
            this.EmployeeType = employeeType;
            this.EmployeeStartDate = employeeStartDate;
        }




    }
}
