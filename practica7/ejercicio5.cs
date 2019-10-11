using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    class ejercicio5
    {
        //Marco René Esquivel Juárez
        //11-sep-2019
        public void ejer5()
        {
            int[,] m1 = new int[3, 3];
            int[,] m2 = new int[3, 3];
            Console.WriteLine("Matriz 1");
            for (int i = 0; i < m1.GetLength(0) ; i++)
            {
                Console.WriteLine("Ingrese los valores para la fila {0}", i+1);
                for (int j = 0; j < m1.GetLength(1) ; j++)
                {
                    m1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz 2");
            for (int i = 0; i < m2.GetLength(0); i++)
            {
                Console.WriteLine("Ingrese los valores para la fila {0}", i + 1);
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    m2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            suma(m1, m2);
            Console.ReadLine();
        }

        static void suma(int[,] m1, int[,] m2)
        {
            int[,] sumar = new int[3, 3];
            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    sumar[i, j] = m1[i, j] + m2[i, j];
                    Console.Write(sumar[i,j] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
