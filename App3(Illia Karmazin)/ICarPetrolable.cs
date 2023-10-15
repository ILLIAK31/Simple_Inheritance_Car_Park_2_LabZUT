using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3_Illia_Karmazin_
{
    interface ICarPetrolable : ICarable
    {
        void Run();
        void Turn_Off();
        void Refuel();
        void Drive();
    }
}
