using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    class ejercicio3
    {
        //Marco René Esquivel Juárez
        //11-sep-2019
        public void ejer3()
        {
            int equipos, jugadores;
            bool isInt;
            
            do
            {
                Console.WriteLine("Ingrese la cantidad de equipos que desea ingresar");
                isInt = int.TryParse(Console.ReadLine(), out equipos);
            } while (isInt == false || equipos < 0);

            do
            {
                Console.WriteLine("Ingrese la cantidad de jugadores que tienen los equipos");
                isInt = int.TryParse(Console.ReadLine(), out jugadores);
            } while (isInt == false || jugadores < 0);

            string[,] liga = new string[equipos,jugadores+1];
            for (int i = 0; i < liga.GetLength(0); i++)
            {
                Console.WriteLine("Ingrese el nombre del equipo {0}", i+1);
                liga[i,0] = Console.ReadLine();
                for (int j = 1; j < liga.GetLength(1); j++)
                {
                    Console.WriteLine("Ingrese el nombre del jugador "+ j);
                    liga[i, j] = Console.ReadLine();
                }
                Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.Clear();
            Console.WriteLine("LIGA MUNICIPAL");
            for (int i = 0; i < liga.GetLength(0); i++)
            {
                Console.WriteLine("Nombre del equipo: {0}", liga[i,0]);
                Console.WriteLine("Jugadores");
                for (int j = 1; j < liga.GetLength(1); j++)
                {
                    Console.WriteLine("{0}- {1}", j, liga[i,j]);
                }
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
