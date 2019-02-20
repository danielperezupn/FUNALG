using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Hola Mundo 2");
            Console.WriteLine("Hola Mundo 3");
            Console.WriteLine("ingresa dos nùmeros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("LA SUMA ES {0}: ", a + b);
            Console.ReadKey();
        }
    }
}
