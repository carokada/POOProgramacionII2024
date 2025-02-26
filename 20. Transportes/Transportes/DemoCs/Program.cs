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

         Console.WriteLine(divisor);
         Console.WriteLine(" creando pasajeros...");
         Pasajero pasajero1 = new Pasajero("30286516", "Gael Garcia");
         Pasajero pasajero2 = new Pasajero("29384975", "Maribel Verdu");
         Pasajero pasajero3 = new Pasajero("32986542", "Diego Luna");
         try
         {
            Pasajero pasajero4 = new Pasajero("241598237", "Chuy");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Pasajero pasajero4 = new Pasajero("24159823", "");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine("\n pasajeros cargados:");
         Console.WriteLine(pasajero1);
         Console.WriteLine(pasajero2);
         Console.WriteLine(pasajero3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando clientes...");
         Persona cliente1 = new Cliente("29384975", "Maribel Verdu");
         Persona cliente2 = new Cliente("31482254", "Rocio Juarez");
         Persona cliente3 = new Cliente("31225943", "Alex Gularte");
         Console.WriteLine("\n clientes cargados:");
         Console.WriteLine(cliente1);
         Console.WriteLine(cliente2);
         Console.WriteLine(cliente3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando ciudades...");
         Ciudad ciudad1 = new Ciudad("Capital Federal");
         Ciudad ciudad2 = new Ciudad("Cordoba");
         Ciudad ciudad3 = new Ciudad("Bariloche");
         Ciudad ciudad4 = new Ciudad("Ushuaia");
         Ciudad ciudad5 = new Ciudad("Posadas");
         Console.WriteLine("\n ciudades cargadas:");
         Console.WriteLine(ciudad1);
         Console.WriteLine(ciudad2);
         Console.WriteLine(ciudad3);
         Console.WriteLine(ciudad4);
         Console.WriteLine(ciudad5);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando pasajes...");
         Pasaje pasaje1 = new Pasaje(new DateTime(2025, 3, 10), (Pasajero)pasajero1, ciudad4, ciudad1);
         Pasaje pasaje2 = new Pasaje(new DateTime(2025, 3, 15), (Pasajero)pasajero1, ciudad1, ciudad4);
         Pasaje pasaje3 = new Pasaje(new DateTime(2025, 2, 28), (Pasajero)pasajero3, ciudad5, ciudad2);
         Pasaje pasaje4 = new Pasaje(new DateTime(2025, 3, 15), (Pasajero)pasajero3, ciudad2, ciudad5);
         Pasaje pasaje5 = new Pasaje(new DateTime(2025, 3, 3), (Pasajero)pasajero2, ciudad1, ciudad3);
         Pasaje pasaje6 = new Pasaje(new DateTime(2025, 3, 9), (Pasajero)pasajero2, ciudad3, ciudad4);
         Pasaje pasaje7 = new Pasaje(new DateTime(2025, 3, 14), (Pasajero)pasajero2, ciudad4, ciudad1);

         Console.WriteLine(" asignando montos...");
         pasaje1.Monto = 500;
         pasaje2.Monto = 500;
         pasaje3.Monto = 200;
         pasaje4.Monto = 200;
         pasaje5.Monto = 350;
         pasaje6.Monto = 300;
         pasaje7.Monto = 450;

         // equipaje ?? aclarar lo del pesoKg y el 10%, se puede o no se puede setear el peso ?

         Console.WriteLine("\n pasajes cargados:");
         Console.WriteLine(pasaje1 + $" ${pasaje1.monto} + IVA (${pasaje1.CalcularIva()})");
         Console.WriteLine(pasaje2 + $" ${pasaje2.monto} + IVA (${pasaje2.CalcularIva()})");
         Console.WriteLine(pasaje3 + $" ${pasaje3.monto} + IVA (${pasaje3.CalcularIva()})");
         Console.WriteLine(pasaje4 + $" ${pasaje4.monto} + IVA (${pasaje4.CalcularIva()})");
         Console.WriteLine(pasaje5 + $" ${pasaje5.monto} + IVA (${pasaje5.CalcularIva()})");
         Console.WriteLine(pasaje6 + $" ${pasaje6.monto} + IVA (${pasaje6.CalcularIva()})");
         Console.WriteLine(pasaje7 + $" ${pasaje7.monto} + IVA (${pasaje7.CalcularIva()})");

         Console.WriteLine(divisor);
         Console.WriteLine(" creando facturas... ");
         Factura factura1 = new Factura(DateTime.Now, (Cliente)cliente1);
         Factura factura2 = new Factura(DateTime.Now, (Cliente)cliente2);

         Console.WriteLine(" cargando pasajes en facturas...");
         factura1.AddPasaje((Pasaje)pasaje5);
         factura1.AddPasaje((Pasaje)pasaje6);
         factura1.AddPasaje((Pasaje)pasaje7);
         factura2.AddPasaje((Pasaje)pasaje1);
         factura2.AddPasaje((Pasaje)pasaje2);
         factura2.AddPasaje((Pasaje)pasaje3);
         factura2.AddPasaje((Pasaje)pasaje4);

         Console.WriteLine("\n facturas cargadas:");
         Console.WriteLine(factura1);
         Console.WriteLine(factura2);

         Console.WriteLine("\n mostrando pasajes cargados en facturas:");
         MostrarPasajes(factura1);
         MostrarPasajes(factura2);

         Console.WriteLine("\n mostrando pasajes por pasajero:");
         MostrarPasajes((Pasajero)pasajero1);
         MostrarPasajes((Pasajero)pasajero2);
         MostrarPasajes((Pasajero)pasajero3);

         //Console.WriteLine("");
         //Console.WriteLine();
         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarPasajes(Factura factura)
      {
         Console.WriteLine($" pasajes de factura {factura}");
         foreach (var pasaje in factura.GetPasajes())
            Console.WriteLine($" - {pasaje}");
         Console.WriteLine();
      }

      private static void MostrarPasajes(Pasajero pasajero)
      {
         Console.WriteLine($" pasajes de {pasajero.Nombre}");
         foreach (var pasaje in pasajero.GetAllPasajes())
            Console.WriteLine($" - {pasaje}");
         Console.WriteLine();
      }
   }
}
