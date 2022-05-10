using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! How many wheels would you like? 2 or 4?");

            int tireCount = int.Parse(Console.ReadLine());

            var answer = VehicleFactory.GetVehicle(tireCount);

            answer.Drive();



        }
    }
}
