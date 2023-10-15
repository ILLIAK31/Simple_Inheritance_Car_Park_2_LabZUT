using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3_Illia_Karmazin_
{
    internal class CarPetrolElectricity : ICarable , ICarPetrolable , ICarElectricity
    {
        private bool Refuel_status_petrol = false;
        private bool Refuel_status_electricity = false;
        private bool Engine_status = false;
        public void Run()
        {
            if (Engine_status)
            {
                Console.WriteLine("The car is already started\n");
            }
            else
            {
                Console.WriteLine("Start the car\n");
                Engine_status = true;
            }
        }
        public void Turn_Off()
        {
            if (Engine_status)
            {
                Console.WriteLine("Turn off the engine\n");
                Engine_status = false;
            }
            else
            {
                Console.WriteLine("Engine is turned off\n");
            }
        }
        public void Refuel()
        {
            if (Refuel_status_petrol && Refuel_status_electricity)
            {
                Console.WriteLine("Car already refueled petrol and electricity\n");
            }
            else
            {
                if (Refuel_status_petrol == false && Refuel_status_electricity == false)
                {
                    Console.WriteLine("Refuels petrol and electricity\n");
                    Refuel_status_petrol = true;
                    Refuel_status_electricity = true;
                }
                else if(!Refuel_status_petrol)
                {
                    Console.WriteLine("Refuels petrol\n");
                    Refuel_status_petrol = true;
                }
                else
                {
                    Console.WriteLine("Refuels electricity\n");
                    Refuel_status_electricity = true;
                }
            }
        }
        public void Drive()
        {
            if (Engine_status)
            {
                if (Refuel_status_petrol || Refuel_status_electricity)
                {
                    if (Refuel_status_petrol)
                    {
                        Console.WriteLine("I'm driving on petrol\n");
                        Refuel_status_petrol = false;
                    }
                    else
                    {
                        Console.WriteLine("I'm driving on electricity\n");
                        Refuel_status_electricity = false;
                    }
                }
                else
                {
                    Console.WriteLine("None petrol and electricity refuel\n");
                }
            }
            else
            {
                Console.WriteLine("Car is not running\n");
            }
        }
    }
}
