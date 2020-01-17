using System;
using System.Collections.Generic;
using Lib1;
using Lib2;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStuff().Wait();
            Console.ReadKey();
        }

        static async Task DoStuff()
        {
            var lib1 = new Lib1Service();
            var lib2 = new Lib2Service();

            var people = await lib1.GetPeople();
            Console.WriteLine("People");
            Console.WriteLine("------");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();

            var airlines = await lib2.GetAirlines();
            Console.WriteLine("Airlines");
            Console.WriteLine("--------");
            foreach (var airline in airlines)
            {
                Console.WriteLine($"{airline.Name}");
            }
        }
    }
}
