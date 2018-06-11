using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class VirtualPetShelter
    {

        
       
        private List<MagicalBeast> petRoster = new List<MagicalBeast>() {
         new MagicalBeast("Thomas", "Griffin",0,0,40, "Snakes", 0, 40, 0, 40, 40, 0, 50, 0, 0)
        ,new MagicalBeast("Maxim", "Sphinx",0,0,40, "Riddles", 0, 40, 0, 40, 40, 0, 50, 0, 0),
        new MagicalBeast("Jeffery", "Manticore",0,0,40, "Criminals", 0, 40, 0, 40, 40, 0, 50, 0, 0)};
    
    
        private List<Employee> employees = new List<Employee>() {
        new Volunteer("Joseph",200,"Volunteer","08/17/2017",20,"Volunteer Inc"),
        new Manager("2/10/2010", "Volunteer", "Karen", 0020, "Manager", "02/06/2008")};

        

        public List<Employee> Employees { get => employees; set => employees = value; }
        public List<MagicalBeast> PetRoster { get => petRoster; set => petRoster = value; }


        public VirtualPetShelter()
        {
            //default ctor
        }







        public List<MagicalBeast> GetList()
        {
            return this.PetRoster;
        }
       
    }
}
