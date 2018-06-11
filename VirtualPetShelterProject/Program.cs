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
            VirtualPetShelter grovewood = new VirtualPetShelter();
            Manager karen = new Manager("2/10/2010", "Volunteer", "Karen", 0020, "Manager", "02/06/2008");
            Volunteer joseph = new Volunteer("Joseph", 200, "Volunteer", "08/17/2017", 20, "Volunteer Inc");
       


            bool gameOn = true;
            string[] employeeArray = new string[] { "1. Shelter Manager", "2. Shelter Volunteer" };
            string[] managerChoiceArray = new string[] { "1. Feed", "2. Give Water", "3.Play", "4. Adopt", "5. Take to doctor", "6. Lay down for a Nap", "7. Exit" };
            

            while(gameOn == true)
            {

                int employeeValue = 0;

                Console.WriteLine("Welcome to the Grovewood Magical Shelter! What kind of employee are you?");
                for (int i = 0; i < employeeArray.Length; i++)
                {
                    Console.WriteLine(employeeArray[i]);
                }
                employeeValue = int.Parse(Console.ReadLine());

                switch (employeeValue)
                {
                    case 1:
                        bool managerMode = true;
                        while (managerMode == true)
                        {
                            Console.WriteLine("Good Morning {0}", karen.Name);
                            karen.ShopTimer(grovewood);
                            Console.WriteLine("This is the Status of Your pets");
                            foreach (var item in grovewood.PetRoster)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Name: {0}", item.Name);
                                Console.WriteLine("Hunger: {0}", item.Hunger);
                                Console.WriteLine("Boredom: {0}", item.Boredom);
                                Console.WriteLine("Tiredness: {0}", item.Tired);
                                Console.WriteLine("Sickness: {0}", item.Sickness);
                                Console.WriteLine("");
                            }

                            Console.WriteLine("What would you like to do today?");
                            for (int i = 0; i < managerChoiceArray.Length; i++)
                            {
                                Console.WriteLine(managerChoiceArray[i]);
                            }
                            int managerChoice = int.Parse(Console.ReadLine());
                            switch (managerChoice)
                            {
                                case 1:
                                    karen.FeedPets(grovewood);
                                    foreach (var item in grovewood.PetRoster)
                                    {
                                        Console.WriteLine("You fed {0} their favorite meal! {1}!", item.Name, item.Diet);
                                    }
                                    break;
                                case 2:
                                    karen.Water(grovewood);
                                    break;
                                case 3:
                                    karen.Play(grovewood);
                                    break;
                                case 4: karen.Adopt();
                                    break;
                                case 5: karen.DoctorVisit(grovewood);
                                    break;
                                case 6:karen.Sleep(grovewood);
                                    break;
                                case 7: managerMode = false;
                                    break;
                                default:
                                    Console.WriteLine("I'm sorry, you entered an unknown choice, please try again.");
                                    break;
                            }

                        }
                        break;
                    case 2:
                        bool volunteerMode = true;
                        while (volunteerMode == true)
                        {
                            Console.WriteLine("Good Morning {0}", joseph.Name);
                            karen.ShopTimer(grovewood);
                            Console.WriteLine("This is the Status of Your pets");
                            foreach (var item in grovewood.PetRoster)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Name: {0}", item.Name);
                                Console.WriteLine("Hunger: {0}", item.Hunger);
                                Console.WriteLine("Boredom: {0}", item.Boredom);
                                Console.WriteLine("Tiredness: {0}", item.Tired);
                                Console.WriteLine("Sickness: {0}", item.Sickness);
                                Console.WriteLine("");
                            }

                            Console.WriteLine("What would you like to do today?");
                            for (int i = 0; i < managerChoiceArray.Length; i++)
                            {
                                Console.WriteLine(managerChoiceArray[i]);
                            }
                            int managerChoice = int.Parse(Console.ReadLine());
                            switch (managerChoice)
                            {
                                case 1:
                                    joseph.FeedPets(grovewood);
                                    foreach (var item in grovewood.PetRoster)
                                    {
                                        Console.WriteLine("You fed {0} their favorite meal! {1}!", item.Name, item.Diet);
                                    }
                                    break;
                                case 2:
                                    joseph.Water(grovewood);
                                    break;
                                case 3:
                                    joseph.Play(grovewood);
                                    break;
                                case 4:
                                    karen.Adopt();
                                    break;
                                case 5:
                                    joseph.DoctorVisit(grovewood);
                                    break;
                                case 6:
                                    joseph.Sleep(grovewood);
                                    break;
                                case 7:
                                    managerMode = false;
                                    break;
                                default:
                                    Console.WriteLine("I'm sorry, you entered an unknown choice, please try again.");
                                    break;
                            }

                        }
                        break;
                    default:
                        break;

                }
                
            }
        }
    }
}
