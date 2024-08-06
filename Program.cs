using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AttackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {


            

            Task<string> TaskA = GetDataFromServiceAAsync();
            Task<string> TaskB = GetDataFromServiceBAsync();

            await Task.WhenAll(TaskA, TaskB);


            Console.WriteLine($"Task A result: {TaskA.Result}");
            Console.WriteLine($"Task B result: {TaskB.Result}");
        }
        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Recivde Data";
        }

        public static async Task<string> ReadFileAsync(string filePath)
        {
            string result = await Task.Run(
                () => File.ReadAllText(filePath)
                );
            return result;

        }

        public static async Task<string> GetDataFromServiceAAsync()
        {
            await Task.Delay(1000);
            return "Data from Service A";
        }


        public static async Task<string> GetDataFromServiceBAsync()
        {
            await Task.Delay(2000);
            return "Data from Service B";
        }
    }
}
