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
         Product producto1 = new Product("yerba", "yer123");
         Product producto2 = new Product("arroz", "arr123");
         Product producto3 = new Product("harina", "har123");

         Console.WriteLine(" productos: ");
         Console.WriteLine(producto1.ToString());
         Console.WriteLine(producto2.ToString());
         Console.WriteLine(producto3.ToString());

         Device device1 = new Device();
         Device device2 = new Device();
         Device device3 = new Device();

         // device revisar como pasar datetime en un constructor
         device1.Sku = "yer123";
         device1.EntryDate = new DateTime(2024, 11, 21);
         device1.SaleDate = new DateTime(2024, 12, 23);
         device2.Sku = "arr123";
         device2.EntryDate = new DateTime(2024, 11, 30);
         device2.SaleDate = new DateTime(2024, 10, 5);
         // saledate < entrydate inicia con mindate 
         device3.Sku = "har123";
         device3.EntryDate = new DateTime(2024, 12, 6);
         device3.SaleDate = new DateTime(2024, 12, 6);

         Console.WriteLine("\n devices: ");
         Console.WriteLine(device1.ToString());
         Console.WriteLine(device2.ToString());
         Console.WriteLine(device3.ToString());

         device2.SaleDate = new DateTime(2024, 12, 5);
         Console.WriteLine(device2.ToString());

         Branch rama1 = new Branch("California", "Posadas");
         Branch rama2 = new Branch("La Anonima", "Santa Cruz");
         Branch rama3 = new Branch("Disco", "CABA");

         Console.WriteLine("\n ramas: ");
         Console.WriteLine(rama1.ToString());
         Console.WriteLine(rama2.ToString());
         Console.WriteLine(rama3.ToString());

         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }
   }
}
