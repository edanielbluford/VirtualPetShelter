﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Volunteer: Employee
    {
        public int VolunteerHoursWorked { get; set; }
        public string VolunteerSource { get; set; }

        public Volunteer()
        {
            //default ctor
        }

        public Volunteer(string name, int employeeID, string employeeType, string employeeStartDate, int volunteerHoursWorked, string volunteerSource)
        {
            
            this.Name = name;
            this.EmployeeID = employeeID;
            this.EmployeeType = employeeType;
            this.EmployeeStartDate = employeeStartDate;
            this.VolunteerHoursWorked = volunteerHoursWorked;
            this.VolunteerSource = volunteerSource;
        }

        public override void ManageMischeif()
        {
            throw new NotImplementedException();
        }

        public override void OrderFood()
        {
            throw new NotImplementedException();
        }

        public void FeedPets(VirtualPetShelter name)
        {

            foreach (var item in name.PetRoster)
            {
                item.Feed();
            }

        }

        public void Water(VirtualPetShelter name)
        {
            foreach (var item in name.PetRoster)
            {
                item.Water();
            }
        }
    }
}
