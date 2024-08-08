using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string jsonFilePath = @"./missiles.json";
                string jsonContent = ReadJson.ReadJsonFile(jsonFilePath);

                MissileManager missileManager = new MissileManager();
                missileManager.LoadMissilesFromJson(jsonContent);

                Console.WriteLine("All Missiles:");
                missileManager.DisplayAllMissiles();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
