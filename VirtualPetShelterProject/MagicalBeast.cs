using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class MagicalBeast : VirtualPet
    {
        private string diet;
        
        public string Diet
        {
            get { return this.diet; }
            set { this.diet = value; }
        }

        public MagicalBeast()
        {
            //Default Constructor
        }

        public MagicalBeast(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public MagicalBeast(string name, string description, int hunger, int thirst, int thirstMax, string diet, int hungerMax, int boredom, int boredomMax, int tired, int tiredMax, int neglect, int neglectMax, int mischief, int sickness) //Loaded Constructor
            {
                this.Name = name;
                this.Description = description;
                this.Diet = diet;
                this.Hunger = hunger;
                this.HungerMax = hungerMax;
                this.Thirst = thirst;
                this.ThirstMax = thirstMax;
                this.Boredom = boredom;
                this.BoredomMax = boredomMax;
                this.Tired = tired;
                this.TiredMax = tiredMax;
                this.Neglect = neglect;
                this.NeglectMax = neglectMax;
                this.Mischief = mischief;
                this.Sickness = Sickness;

            }
    }
}
