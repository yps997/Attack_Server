using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackServer
{
    internal class ReadJson
    {
        //static string filePath = File.ReadAllText(@"./missiles.json");

        public static string ReadJsonFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"The file {filePath} was not found.");
            }
            return File.ReadAllText(filePath);
        }


    }
}
