using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3_Illia_Karmazin_
{
    internal class CarPetrol : ICarPetrolable
    {
        private bool Refuel_status = false;
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
                Engine_status = true ;
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
        public void Drive() 
        {
            if (Engine_status)
            {
                if (Refuel_status)
                {
                    Console.WriteLine("I'm driving on " + car_type + "\n");
                    Refuel_status = (Refuel_status) ? false : true;
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
        public void Refuel()
        {
            Refuel_petrol();
        }
        public void Refuel_petrol()
        {
            if (Refuel_status)
            {
                Console.WriteLine("Car already refueled petrol\n");
            }
            else
            {
                car_type = "petrol";
                Console.WriteLine("Refuels petrol\n");
                Refuel_status = true;
            }
        }

    }
}
