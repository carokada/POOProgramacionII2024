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
         User usuario1 = new User("Carlos Benitez", "7239568");
         User usuario2 = new User("Ramona Gutierrez", "30158746");
         User usuario3 = new User("Marta Gomez", "24136652");

         Console.WriteLine(" usuarios: ");
         Console.WriteLine(usuario1.ToString());
         Console.WriteLine(usuario2.ToString());
         Console.WriteLine(usuario3.ToString());

         Line linea1 = new Line("376", "469583");
         Line linea2 = new Line("376", "48632594");
         Line linea3 = new Line("376", "44368576");

         Console.WriteLine("\n lineas: ");
         Console.WriteLine(linea1.ToString());
         Console.WriteLine(linea2.ToString());
         Console.WriteLine(linea3.ToString());

         Call llamada1 = new Call(new DateTime(2024, 08, 12), "376-48632594", 83);
         Call llamada2 = new Call(new DateTime(2024, 10, 12), "376-44368576", 150);
         Call llamada3 = new Call(new DateTime(2024, 12, 12), "376-46958312", 240);

         Console.WriteLine("\n llamadas: ");
         Console.WriteLine(llamada1.ToString());
         Console.WriteLine(llamada2.ToString());
         Console.WriteLine(llamada3.ToString());

         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }
   }
}
