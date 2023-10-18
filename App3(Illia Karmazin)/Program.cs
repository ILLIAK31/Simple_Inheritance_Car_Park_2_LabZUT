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
            ICarPetrolable car_petrol_petrolgas = new CarPetrolGas();
            ICarPetrolable car_petrol_petrolelectricity = new CarPetrolElectricity();

            car_petrol_petrolgas.Refuel_petrol();
            Test_Drive(car_petrol_petrolgas);

            car_petrol_petrolelectricity.Refuel_petrol();
            Test_Drive(car_petrol_petrolelectricity);
            
            ICarable car_car_petrolgas = new CarPetrolGas();
            ICarable car_car_petrolelectricity = new CarPetrolElectricity();

            car_car_petrolgas.Refuel();
            Test_Drive(car_car_petrolgas);

            car_car_petrolelectricity.Refuel();
            Test_Drive(car_car_petrolelectricity);            
        }
    }
}
