using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    class ejercicio1
    {
        //Marco René Esquivel Juárez
        //11-sep-2019
        public void ejer1()
        {

            int cant, mayores = 0, menores = 0;
            bool isInt;
            do
            {
                Console.WriteLine("Ingrese la cantidad de edades que desea ingresar");
                isInt = int.TryParse(Console.ReadLine(), out cant);
            } while (isInt == false || cant < 0);

            int[] edad = new int[cant];

            for (int i = 0; i < edad.Length; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona {0}", i + 1);
                edad[i] = Convert.ToInt32(Console.ReadLine());
                if (edad[i] > 17)
                {
                    mayores++;
                }
                else menores++;
            }
            Console.Clear();
            Console.WriteLine("Mayores de edad: " + mayores);
            Console.WriteLine("Menores de edad: " + menores);
            Console.ReadKey();
        }
    }
}
