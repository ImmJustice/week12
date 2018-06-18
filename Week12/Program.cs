using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using week12classLib;
using System.Threading.Tasks;

namespace Week12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1");

            var task = Class1.FindPrime(250000);
            var task1 = Class1.FindPrime(400000);

            Console.WriteLine("2");

            Console.WriteLine(task.Result);
            Console.WriteLine(task1.Result);
            Console.ReadKey();
        }




    }
}
