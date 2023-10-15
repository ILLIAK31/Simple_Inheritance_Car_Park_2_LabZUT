using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3_Illia_Karmazin_
{
    internal class Program
    {
        static void Test_Drive(ICarable car)
        {
            Console.WriteLine("Test drive starting :");
            car.Refuel();
            car.Refuel();
            car.Drive();
            car.Run();
            car.Run();
            car.Drive();
            car.Drive();
            car.Turn_Off();
            car.Turn_Off();
            Console.WriteLine("Test drive end !\n");
        }
        static void Main(string[] args)
        {
            CarPetrolGas car_petrolgas = new CarPetrolGas();
            CarPetrolElectricity car_petrolelectricity = new CarPetrolElectricity();

            ICarPetrolable car_petrol_petrolgas = (ICarPetrolable)car_petrolgas;
            //car_petrol_petrolgas.Refuel();
            Test_Drive(car_petrol_petrolgas);

            ICarable car_car_petrolgas = (ICarable)car_petrol_petrolgas;
            //car_car_petrolgas.Refuel();
            Test_Drive(car_car_petrolgas);

            
            ICarPetrolable car_petrol_petrolelectricity = (ICarPetrolable)car_petrolelectricity;
            //car_petrol_petrolelectricity.Refuel();
            Test_Drive(car_petrol_petrolelectricity);

            ICarable car_car_petrolelectricity = (ICarable)car_petrol_petrolelectricity;
            //car_car_petrolelectricity.Refuel();
            Test_Drive(car_car_petrolelectricity);
        }
    }
}
