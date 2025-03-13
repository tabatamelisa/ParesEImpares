using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesEImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Validar si un número es oar o impar
            //Tabata Vernaza
            int numero;
            do
            {
                Console.Write("Digita un número entero: "); //el usuario debe ingresar el número
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número ingresado es par.");
                }
                else
                {
                    Console.WriteLine("El número ingresado es impar.");
                }
            } while (true); //Se repite el prgrama
        }
    }
}
