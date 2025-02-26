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
         Console.WriteLine(" creando personas...");
         Persona persona1 = new Persona(35268195, "Juan Perez");
         Persona persona2 = new Persona(30159482, "Mariana Lopez");
         try
         {
            Persona persona3 = new Persona(30159, "Maria Juarez");
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error: " + e.Message);
         }
         try
         {
            Persona persona3 = new Persona(30135486, "");
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error: " + e.Message);
         }
         Console.WriteLine("\n mostrando personas cargadas:");
         Console.WriteLine(persona1);
         Console.WriteLine(persona2);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando tickets...");
         Ticket ticket1 = new Ticket(persona1, 10000);
         Ticket ticket2 = new Ticket(persona1, 15000);
         Ticket ticket3 = new Ticket(persona2, 10000);
         try
         {
            Ticket ticket4 = new Ticket(persona2, -10000);
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error: " + e.Message);
         }
         Console.WriteLine("\n mostrando tickets cargados");
         Console.WriteLine(ticket1);
         Console.WriteLine(ticket2);
         Console.WriteLine(ticket3);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando paquetes...");
         Paquete paquete1 = new Paquete("ida y vuelta rosario", new DateTime(2025, 02, 24), new DateTime(2025, 03, 5));
         Paquete paquete2 = new Paquete("ida y vuelta cordoba", new DateTime(2025, 03, 8), new DateTime(2025, 03, 10));
         try
         {
            Paquete paquete3 = new Paquete("ida y vuelta buenos aires", new DateTime(2025, 02, 8), new DateTime(2025, 02, 10));
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error: " + e.Message);
         }
         try
         {
            Paquete paquete3 = new Paquete("ida y vuelta buenos aires", new DateTime(2025, 02, 25), new DateTime(2025, 02, 20));
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error: " + e.Message);
         }
         try
         {
            Paquete paquete3 = new Paquete("", new DateTime(2025, 02, 28), new DateTime(2025, 03, 10));
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error: " + e.Message);
         }
         Console.WriteLine("\n mostrando paquetes cargados");
         Console.WriteLine(paquete1);
         Console.WriteLine(paquete2);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando tickets en los paquetes...");
         paquete1.AddTicket(ticket1);
         paquete1.AddTicket(ticket2);
         paquete2.AddTicket(ticket2);
         paquete2.AddTicket(ticket3);
         try
         {
            paquete2.AddTicket(ticket3);
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error: " + e.Message);
         }
         Console.WriteLine("\n mostrando tickets cargados");
         MostrarTickets(paquete1);
         Console.WriteLine();
         MostrarTickets(paquete2);
         Console.WriteLine("\n eliminando tickets erroneos...");
         paquete2.RemoveTicket(ticket2);
         Console.WriteLine("\n mostrando paquetes cargados");
         MostrarTickets(paquete1);
         Console.WriteLine();
         MostrarTickets(paquete2);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando cliente...");
         Persona cliente1 = new Cliente(35268195, "Juan Perez", "26-35268195-6");
         Console.WriteLine(cliente1);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando venta...");
         Venta venta1 = new Venta((Cliente) cliente1, new DateTime(2025, 2, 23));
         Console.WriteLine(venta1);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando paquete en la venta...");
         venta1.AddPaquete(paquete1);
         try
         {
            venta1.AddPaquete(paquete1);
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error: " + e.Message);
         }
         Console.WriteLine();
         MostrarPaquetes(venta1);
         Console.WriteLine(" el cliente es pasajero de un paquete: " + venta1.IsClientePasajero());
                  
         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarTickets(Paquete paquete)
      {
         Console.WriteLine($" mostrando tickets del paquete {paquete}");
         foreach (var ticket in paquete.GetTickets())
            Console.WriteLine(" - " + ticket);
      }

      private static void MostrarPaquetes(Venta venta)
      {
         Console.WriteLine($" mostrando paquetes de la venta {venta}");
         foreach (var ticket in venta.GetPaquetes())
            Console.WriteLine(" - " + ticket);
      }
   }
}
