using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Tesla : RaceCar
    {
        public Tesla()
        {
            Name = "Tesla Model S";
            TopSpeed = 110;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is electrified and fully charged!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} refuses to drop Tesla stock prices by slowing!");
            base.Brake();
        }


    }
}
