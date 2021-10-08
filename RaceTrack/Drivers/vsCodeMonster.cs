using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class vsCodeMonster : Driver
    {
        public vsCodeMonster(RaceCar car) : base(car)
        {
            Name = "The vs-Code Monster";
            SkillLevel = 10;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
