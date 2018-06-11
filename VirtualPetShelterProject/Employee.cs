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

        public void FeedPets(VirtualPetShelter name )
        {

            foreach (var item in name.PetRoster)
            {
                item.Feed();
            }

        }

        public void Water(VirtualPetShelter name )
        {
            foreach (var item in name.PetRoster)
            {
                item.Water();
            }
        }
        public void Play(VirtualPetShelter name)
        {
            foreach (var item in name.PetRoster)
            {
                item.Play();
            }
        }

        public void Sleep(VirtualPetShelter name)
        {
            foreach (var item in name.PetRoster)
            {
                item.Sleep();
            }
        }
     
        public void DoctorVisit(VirtualPetShelter name)
        {
            foreach (var item in name.PetRoster)
            {
                item.DoctorVisit();
            }
        }
        public void ShopTimer(VirtualPetShelter name)
        {
            foreach (var item in name.PetRoster)
            {
                item.Tick();
            }
        }
        abstract public void ManageMischeif();
        abstract public void OrderFood();
        
    }
}
