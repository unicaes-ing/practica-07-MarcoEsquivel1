using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    class ejercicio2
    {
        //Marco René Esquivel Juárez
        //11-sep-2019
        public void ejer2()
        {
            int cant, pares = 0, impares = 0;
            bool isInt;

            do
            {
                Console.WriteLine("Ingrese la cantidad de números que desea ingresar");
                isInt = int.TryParse(Console.ReadLine(), out cant);
            } while (isInt == false || cant < 0);

            int[] numeros = new int[cant];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                {
                    pares++;
                }
                else impares++;
            }
            Console.Clear();
            Console.WriteLine("Cantidad de numeros pares: "+ pares);
            Console.WriteLine("Cantidad de numeros impares: "+ impares);
            Console.ReadKey();
        }
    }
}
