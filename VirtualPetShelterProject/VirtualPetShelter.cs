using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class VirtualPetShelter
    {
        public List<Employee> EmployeeRoster { get; set; }
        public List<VirtualPet> PetRoster { get; set; }



        public VirtualPetShelter(List<Employee> employeeRoster, List<VirtualPet> petRoster)
        {
            this.EmployeeRoster = employeeRoster;
            this.PetRoster = petRoster;
        }

        public void AddEmployee()
        {
            //List<T>.Add(new Manager());
        }
    }
}
