using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_MAY_MEN_FUNC_VEC
{
    class Program
    {
        static int[] notas;
        static void Main(string[] args)
        {
            IngresarDatos();
            string opcion;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Ingrese una opción");
                Console.WriteLine("[1]: Mostrar el vector");
                Console.WriteLine("[2]: Calcular el mayor");
                Console.WriteLine("[3]: Calcular el menor");
                Console.WriteLine("[4]: Cerrar");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": MostrarDatos(); break;
                    case "2": Mayor(); break;
                    case "3": Menor(); break;
                    case "4": Environment.Exit(1) ; break;
                    default: Console.WriteLine("Opción no válida"); break;
                }
            } while (opcion=="1" || opcion == "2" || opcion == "3");


            Console.ReadKey();
        }

        public static void Menor()
        {
            int men = notas[0];
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] < men)
                    men = notas[i];
            }
            Console.WriteLine("Menor=" + men);
        }

        public static void Mayor()
        {
            int may=notas[0];
            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] > may)
                    may = notas[i];
            }
            Console.WriteLine("Mayor=" + may);
        }

        public static void MostrarDatos()
        {
            for (int i = 0; i < notas.Length; i++)
                Console.WriteLine(notas[i] + " ");
        }

        public static void IngresarDatos()
        {
            Console.WriteLine("Cantidad: ");
            int cant = int.Parse(Console.ReadLine());

            notas = new int[cant];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota {0}:",i+1);
                notas[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
