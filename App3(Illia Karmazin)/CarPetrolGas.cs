using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3_Illia_Karmazin_
{
    internal class CarPetrolGas : ICarable , ICarPetrolable , ICarGasable 
    {
        private bool Refuel_status_petrol = false;
        private bool Refuel_status_gas = false;
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
            if (Refuel_status_petrol && Refuel_status_gas)
            {
                Console.WriteLine("Car already refueled petrol and gas\n");
            }
            else
            {
                if (Refuel_status_petrol == false && Refuel_status_gas == false)
                {
                    Console.WriteLine("Refuels petrol and gas\n");
                    Refuel_status_petrol = true;
                    Refuel_status_gas = true;
                }
                else if (!Refuel_status_petrol)
                {
                    Console.WriteLine("Refuels petrol\n");
                    Refuel_status_petrol = true;
                }
                else
                {
                    Console.WriteLine("Refuels gas\n");
                    Refuel_status_gas = true;
                }
            }
        }
        public void Drive()
        {
            if (Engine_status)
            {
                if (Refuel_status_petrol || Refuel_status_gas)
                {
                    if (Refuel_status_petrol)
                    {
                        Console.WriteLine("I'm driving on petrol\n");
                        Refuel_status_petrol = false;
                    }
                    else
                    {
                        Console.WriteLine("I'm driving on gas\n");
                        Refuel_status_gas = false;
                    }
                }
                else
                {
                    Console.WriteLine("None petrol and gas refuel\n");
                }
            }
            else
            {
                Console.WriteLine("Car is not running\n");
            }
        }
    }
}
