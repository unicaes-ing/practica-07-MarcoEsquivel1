using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    class ejercicio4
    {
        //Marco René Esquivel Juárez
        //11-sep-2019
        public void ejer4()
        {
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("Ingrese los valores de la fila {0}", i + 1);
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------------");
            transpuesta(matriz);
            Console.ReadKey();
        }

        static void transpuesta(int[,] trans)
        {
            for (int i = 0; i < trans.GetLength(0); i++)
            {
                for (int j = 0; j < trans.GetLength(1); j++)
                {
                    Console.Write(trans[j,i]+" ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
