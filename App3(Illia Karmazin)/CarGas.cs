using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3_Illia_Karmazin_
{
    internal class CarGas : ICarGasable
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
            Refuel_gas();
        }
        public void Refuel_gas()
        {
            if (Refuel_status)
            {
                Console.WriteLine("Car already refueled gas\n");
            }
            else
            {
                car_type = "gas";
                Console.WriteLine("Refuels gas\n");
                Refuel_status = true;
            }
        }
    }
}
