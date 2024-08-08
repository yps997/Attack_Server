using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace AttackServer
{
    internal class MissileManager
    {
        private List<Missile> missiles;

        public MissileManager()
        {
            missiles = new List<Missile>();
        }

        public void LoadMissilesFromJson(string jsonContent)
        {
            missiles = JsonConvert.DeserializeObject<List<Missile>>(jsonContent);
        }

        public void DisplayAllMissiles()
        {
            foreach (var missile in missiles)
            {
                Console.WriteLine(missile);
            }
        }
    }
}
