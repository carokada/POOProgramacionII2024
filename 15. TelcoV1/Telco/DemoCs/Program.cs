using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitidadesCs;

namespace DemoCs
{
   class Program
   {
      static void Main(string[] args)
      {
         Marca marca1 = new Marca("Samsung");
         Marca marca2 = new Marca("Motorola");
         Marca marca3 = new Marca("IPhone");

         Console.WriteLine(" marcas: ");
         Console.WriteLine(marca1.ToString());
         Console.WriteLine(marca2.ToString());
         Console.WriteLine(marca3.ToString());

         Modelo modelo1 = new Modelo("Z Flip 5");
         Modelo modelo2 = new Modelo("Razr 50 Ultra");
         Modelo modelo3 = new Modelo("15");

         Console.WriteLine("\n modelos: ");
         Console.WriteLine(modelo1.ToString());
         Console.WriteLine(modelo2.ToString());
         Console.WriteLine(modelo3.ToString());

         Linea linea1 = new Linea(376, 4406092);
         Linea linea2 = new Linea(376, 4459856);
         Linea linea3 = new Linea(376, 4943826);

         Console.WriteLine("\n lineas: ");
         Console.WriteLine(linea1.ToString());
         Console.WriteLine(linea2.ToString());
         Console.WriteLine(linea3.ToString());

         linea2.suspender();
         linea3.suspender();
         linea3.reactivar();

         Console.WriteLine("\n lineas (despues de suspension y reactivacion): ");
         Console.WriteLine(linea1.ToString());
         Console.WriteLine(linea2.ToString());
         Console.WriteLine(linea3.ToString());

         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }
   }
}
