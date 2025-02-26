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
         Propietario persona1 = new Persona("Jorge Benitez", "25169752");
         Propietario persona2 = new Persona("Marta Torres", "33169725");
         try
         {
            Propietario persona3 = new Persona("", "26157439");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Propietario persona3 = new Persona("Valeria Gomez", "1264");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }

         Console.WriteLine("\n mostrando personas cargadas:");
         Console.WriteLine(persona1);
         Console.WriteLine(persona2);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando empresas...");
         Propietario empresa1 = new Empresa("California", "1234567891234");
         Propietario empresa2 = new Empresa("Todo Frio", "1234567891235");
         try
         {
            Propietario empresa3 = new Empresa("Super del Pollo", "123456789");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }

         Console.WriteLine("\n mostrando empresas cargadas:");
         Console.WriteLine(empresa1);
         Console.WriteLine(empresa2);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando vehiculos");
         Vehiculo auto1 = new Vehiculo("bbw182");
         Vehiculo auto2 = new Vehiculo("pscf5267");
         try
         {
            Vehiculo auto3 = new Vehiculo("hdoc165");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }

         Console.WriteLine("\n mostrando vehiculos cargados:");
         Console.WriteLine(auto1);
         Console.WriteLine(auto2);

         Console.WriteLine(divisor);
         Console.WriteLine("\n asignando propietarios...");
         auto1.propietario = persona2;
         auto2.propietario = empresa1;

         Console.WriteLine("\n mostrando vehiculos cargados:");
         Console.WriteLine(auto1);
         Console.WriteLine(auto2);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando multas...");
         Multa multa1 = new Multa(auto1, new DateTime(2025, 2, 15), 15, 69);
         Multa multa2 = new Multa(auto1, new DateTime(2025, 1, 6), -33, 98);
         Multa multa3 = new Multa(auto2, new DateTime(2025, 1, 23), 90, -180, 3);
         Multa multa4 = new Multa(auto2, new DateTime(2025, 2, 20), 16, 120, 1);
         try
         {
            Multa multa5 = new Multa(auto2, new DateTime(2025, 2, 25), 48, 93);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Multa multa5 = new Multa(auto2, new DateTime(2025, 2, 18), -148, 93);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Multa multa5 = new Multa(auto2, new DateTime(2025, 2, 25), 48, 183);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }

         Console.WriteLine("\n mostrando multas cargadas:");
         Console.WriteLine(multa1);
         Console.WriteLine(multa2);
         Console.WriteLine(multa3);
         Console.WriteLine(multa4);

         Console.WriteLine(" estableciendo monto por unidad...");
         multa1.MontoUnidad = 15000;
         multa2.MontoUnidad = 10000;
         multa3.MontoUnidad = 6000;
         multa4.MontoUnidad = 20000;

         Console.WriteLine("\n mostrando multas cargadas:");
         Console.WriteLine(multa1);
         Console.WriteLine(multa2);
         Console.WriteLine(multa3);
         Console.WriteLine(multa4);

         Console.WriteLine(divisor);
         Console.WriteLine(" multas por propietario: ");
         //MostrarMultas(persona1);
         //MostrarMultas(persona2);
         //MostrarMultas(empresa1);
         //MostrarMultas(persona2);
         Console.WriteLine("\n multas por vehiculo: ");
         MostrarMultas(auto1);
         MostrarMultas(auto2);

         Console.WriteLine();
         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarMultas(Propietario propietario)
      {
         Console.WriteLine($" multas del propietario {propietario}:");
         foreach (var multa in propietario.GetMultas())
            Console.WriteLine(" - " + multa);
      }

      private static void MostrarMultas(Vehiculo vehiculo)
      {
         Console.WriteLine($" multas del vehiculo {vehiculo}:");
         foreach (var multa in vehiculo.GetMultas())
            Console.WriteLine(" - " + multa);
      }
   }
}

         //try
         //{
            
         //}
         //catch (Exception e)
         //{
         //   Console.WriteLine($" !! error: {e.Message}");
         //}
