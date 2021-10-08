using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class MonsterTruck : RaceCar
    { 
        public MonsterTruck()
        {
            Name = "Monster Truck";
            TopSpeed = 99;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} emerges from a cloud of smoke");
        }
    }
}
