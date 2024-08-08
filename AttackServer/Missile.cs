using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    internal class Missile
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Mass { get; set; }
        public string Origin { get; set; }
        public double Angle { get; set; }
        public int damage {  get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Speed: {Speed}, Mass: {Mass}, Origin: {Origin}, Angle: {Angle}";
        }

    }

}

