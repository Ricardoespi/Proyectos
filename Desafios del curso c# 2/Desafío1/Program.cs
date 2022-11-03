using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Codigos de operador.
            //1 Movistar
            //2 Digitel
            //3 Movilnet
            Console.WriteLine("ingrese su marca, enter, y luego modelo: ");
            Telefono t1 = new Telefono(Console.ReadLine(), Console.ReadLine());
            Telefono[] telefonos = new Telefono[4];
            Console.WriteLine("Ingrese su número telefónico");
            t1.NumeroTelefónico = Console.ReadLine();
            if (t1.NumeroTelefónico.Length != 11)
                t1.NumeroTelefónico = "ERROR";

            if (t1.NumeroTelefónico.StartsWith("0414") || t1.NumeroTelefónico.StartsWith("0424"))
                t1.CodigoOperador = 1;
            else if (t1.NumeroTelefónico.StartsWith("0412"))
                t1.CodigoOperador = 2;
            else if (t1.NumeroTelefónico.StartsWith("0416") || t1.NumeroTelefónico.StartsWith("0426"))
                t1.CodigoOperador = 3;
            else
                t1.CodigoOperador = 0;
            Console.WriteLine("Los datos del teléfono son: " + t1.Marca + " " + t1.Modelo + ".");
            Console.WriteLine("Su número de telefono es: " + t1.NumeroTelefónico);
            Console.Write("Su codigo de operador es " + t1.CodigoOperador + " y su operador es ");
            
            if (t1.CodigoOperador == 1)
                Console.WriteLine("Movistar");
            else if (t1.CodigoOperador == 2)
                Console.WriteLine("Digitel");
            else if (t1.CodigoOperador == 3)
                Console.WriteLine("Movilnet");
            else
                Console.WriteLine("ERROR");
            Console.WriteLine("Ingrese a quien quiere llamar: ");
            Console.WriteLine(t1.Llamar(Console.ReadLine()));

            Console.ReadKey();
        }
    }
}
