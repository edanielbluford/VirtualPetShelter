using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Manager: Employee
    {
        public string PromotionDate { get; set; }
        public string FormerPosition { get; set; }



        public Manager()
        {
            //default constructor
        }

        public Manager(string promotionDate, string formerPosition, string name, int employeeID, string employeeType, string employeeStartDate)
        {
            this.PromotionDate = promotionDate;
            this.FormerPosition = formerPosition;
            this.Name = name;
            this.EmployeeID = employeeID;
            this.EmployeeType = employeeType;
            this.EmployeeStartDate = employeeStartDate;
        }

       //public void Adopt(VirtualPetShelter name)
       // {
       //     name.PetRoster.Remove(MagicalBeast);
       // }  Pete I had some trouble with this one.

        public override void ManageMischeif()
        {
            throw new NotImplementedException();
        }

        public override void OrderFood()
        {
            throw new NotImplementedException();
        }
    }
}
