using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var roverRove =new RoverRove("3 3 E", "MMRMMRMRRM") ;// new RoverRove("1 2 N", "LMLMLMLMM");
            Console.WriteLine(roverRove.Calculate());
            Console.ReadLine();
        }
    }
}
