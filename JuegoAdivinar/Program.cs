using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinarNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int numeroSecreto = GenerarNumero(1, 999);
                int intentos = 1;

                Console.WriteLine("-----------------------------");
                Console.Write("Adivina un numero entre 1 y 999\n");
                Console.WriteLine("Pulse 0 si desea salir");
                Console.WriteLine("-----------------------------");
                while (true)
                {
                    Console.Write("Introduce un numero entre 1 y 999\n");
                    int intentoUsuario = Convert.ToInt32(Console.ReadLine());
                    if (intentoUsuario == 0)
                        return;
                    else if (intentoUsuario < numeroSecreto)
                    {
                        Console.WriteLine("Su numero es menor");
                        ++intentos;
                        continue;
                    }
                    else if (intentoUsuario > numeroSecreto)
                    {
                        Console.WriteLine("Su numero es mayor");
                        ++intentos;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("GANASTE!!!!!!!!");
                        Console.WriteLine("El numero secreto era {0}!",numeroSecreto);
                        Console.WriteLine("Te tomo {0} {1}.\n", intentos, intentos == 1 ? "intento" : "intentos");
                        Console.WriteLine("-----------------------------");
                        break;
                    }
                }
            }

        }
        //Metodo para generar numeros aleatorios
        static int GenerarNumero(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}

