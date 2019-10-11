using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    class ejercicio6
    {
        //Marco René Esquivel Juárez
        //11-sep-2019
        public void ejer6()
        {
            int[,] m = new int[6, 6];
            Random ran = new Random();
            int n = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    n = ran.Next(10, 100);
                    while (verfica(m, n) == false)
                    {
                        n = ran.Next(10, 100);
                    }
                    m[i, j] = n;
                }
            }
            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("   " + m[i, j]);
                }

                Console.WriteLine(" ");
            }
            
            Console.WriteLine("Presione <ENTER> para continuar");
            Console.ReadKey();

        }
        
        static bool verfica(int[,] m, int n)
        {
            bool x = true;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (n == m[i, j])
                    {
                        x = false;
                    }
                    else
                    {
                        x = true;
                    }
                }
            }
            return x;
        }
    }
}
