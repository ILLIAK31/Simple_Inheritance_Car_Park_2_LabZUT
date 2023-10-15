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
        private string car_type;
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
            if (Refuel_status_petrol || Refuel_status_electricity)
            {
                Console.WriteLine("Car already refueled petrol-electricity\n");
            }
            else
            {
                car_type = "petrol-electricity";
                Console.WriteLine("Refuels petrol and electricity\n");
                Refuel_status_petrol = true;
                Refuel_status_electricity = true;
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
                    Console.WriteLine("None " + car_type + " refuel\n");
                }
            }
            else
            {
                Console.WriteLine("Car is not running\n");
            }
        }
    }
}
