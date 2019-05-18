using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Utiles;



namespace Logica_Difusa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserte la velocidad");
            var a = Console.ReadLine();
            Console.WriteLine("Inserte el peso");
            var b = Console.ReadLine();
            Console.WriteLine( "Inserte el coeficiente de Rosamiento");
            var c = Console.ReadLine();

           var resp = Class1.Init(int.Parse(a), int.Parse(b), int.Parse(c));

            Console.WriteLine(resp);

           
           /* var a = Class1.Velocidad.lento;
            var l = a.ToString();
            Console.WriteLine(a.GetType());
            var x = (1, "leo");
            Console.WriteLine(x.GetType());

            double coefi = Utiles.Class1.Trapezoidal(10, 0, 40, 70, 90);
            Console.WriteLine(coefi);*/



            
        }
    }
}
