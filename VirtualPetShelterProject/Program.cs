using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOn = true;
            string[] employeeArray = new string[] { "1. Shelter Manager", "2. Shelter Volunteer" };
            

            while(gameOn == true)
            {

                int employeeValue = 0;

                Console.WriteLine("Welcome to the Magic Pet Shelter! What kind of employee are you?");
                for (int i = 0; i < employeeArray.Length; i++)
                {
                    Console.WriteLine(employeeArray[i]);
                }
                employeeValue = int.Parse(Console.ReadLine());

                switch (employeeValue)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break;

                }
                
            }
        }
    }
}
