using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCs;

namespace DemoCs
{
   class Program
   {
      static void Main(string[] args)
      {
         string divisor = "----------------------------------------------------------";

         Console.WriteLine(" creando marcas...");
         Marca marca1 = new Marca("Samsung");
         Marca marca2 = new Marca("Motorola");
         Marca marca3 = new Marca("IPhone");

         Console.WriteLine(marca1);
         Console.WriteLine(marca2);
         Console.WriteLine(marca3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando modelos...");
         Modelo modelo1 = new Modelo("Z Flip 6", marca1);
         Modelo modelo2 = new Modelo("Razr 50 Ultra", marca2);
         Modelo modelo3 = new Modelo("15", marca3);

         Console.WriteLine(modelo1);
         Console.WriteLine(modelo2);
         Console.WriteLine(modelo3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando equipos... ");
         Equipo equipo1 = new Equipo(modelo1, "123");
         Equipo equipo2 = new Equipo(modelo2, "124");
         Equipo equipo3 = new Equipo(modelo3, "125");

         Console.WriteLine(equipo1);
         Console.WriteLine(equipo2);
         Console.WriteLine(equipo3);
         
         Console.WriteLine(divisor);
         Console.WriteLine(" creando lineas...");
         Linea linea1 = new Linea(376, 469853, equipo1);
         Linea linea2 = new Linea(376, 568432, equipo2);
         Linea linea3 = new Linea(376, 436952, equipo3);

         linea2.Suspender();
         linea3.Suspender();
         linea3.Reactivar();

         Console.WriteLine(linea1);
         Console.WriteLine(linea2);
         Console.WriteLine(linea3);

         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }
   }
}
