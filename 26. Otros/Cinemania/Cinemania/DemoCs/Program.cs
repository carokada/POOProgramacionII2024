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
         Console.WriteLine(" creando actores...");
         Actor actor1 = new Actor("Zendaya", new DateTime(1996, 9, 1));
         Actor actor2 = new Actor("Mike Faist", new DateTime(1992, 1, 5));
         Actor actor3 = new Actor("Josh O'Connor", new DateTime(1990, 5, 20));
         Actor actor4 = new Actor("Timothee Chalamet", new DateTime(1996, 9, 1));
         Actor actor5 = new Actor("Ana Taylor-Joy", new DateTime(1996, 4, 16));
         try
         {
            Ente actor6 = new Actor("T", new DateTime(1996, 4, 16));
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Ente actor6 = new Actor("Tom Hardy", new DateTime(2025, 4, 16));
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine(divisor);
         Console.WriteLine(" actores cargados: ");
         Console.WriteLine(actor1);
         Console.WriteLine(actor2);
         Console.WriteLine(actor3);
         Console.WriteLine(actor4);
         Console.WriteLine(actor5);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando personajes...");
         Personaje personaje1 = new Personaje("Tashi Duncan", actor1, 3000000);
         Personaje personaje2 = new Personaje("Art Donaldson", actor2, 2500000);
         Personaje personaje3 = new Personaje("Patrick Zweig", actor3, 2500000);
         Personaje personaje4 = new Personaje("Chani", actor1, 5000000);
         Personaje personaje5 = new Personaje("Paul Atreides", actor4, 6000000);
         Personaje personaje6 = new Personaje("Alia Atreides", actor5, 4000000);
         Personaje personaje7 = new Personaje("Emma Woodhouse", actor5, 4000000);
         Personaje personaje8 = new Personaje("Mr. Elton", actor3, 4000000);
         try
         {
            Personaje personaje9 = new Personaje("Mr. Knightley", null, 4000000);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine(divisor);
         Console.WriteLine(" personajes cargados...");
         Console.WriteLine(personaje1);
         Console.WriteLine(personaje2);
         Console.WriteLine(personaje3);
         Console.WriteLine(personaje4);
         Console.WriteLine(personaje5);
         Console.WriteLine(personaje6);
         Console.WriteLine(personaje7);
         Console.WriteLine(personaje8);

         Console.WriteLine(divisor);
         Console.WriteLine("creando peliculas...");
         Pelicula pelicula1 = new Pelicula("Challengers", 2024);
         Pelicula pelicula2 = new Pelicula("Dune: Part Two", 2024);
         Pelicula pelicula3 = new Pelicula("Emma", 2020);
         Console.WriteLine(divisor);
         Console.WriteLine(" peliculas cargadas...");
         Console.WriteLine(pelicula1);
         Console.WriteLine(pelicula2);
         Console.WriteLine(pelicula3);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando personajes en peliculas...");
         pelicula1.AddPersonaje(personaje1);
         pelicula1.AddPersonaje(personaje2);
         pelicula1.AddPersonaje(personaje3);
         pelicula2.AddPersonaje(personaje4);
         pelicula2.AddPersonaje(personaje5);
         pelicula2.AddPersonaje(personaje6);
         pelicula3.AddPersonaje(personaje7);
         pelicula3.AddPersonaje(personaje8);
         pelicula3.AddPersonaje(personaje5);
         MostrarPersonajes(pelicula1);
         MostrarPersonajes(pelicula2);
         MostrarPersonajes(pelicula3);
         Console.WriteLine(" eliminando personaje mal cargado...");
         pelicula3.RemovePersonaje(personaje5);
         MostrarPersonajes(pelicula3);

         Console.WriteLine(divisor);
         Console.WriteLine(" mostrando creditos..."); // falta resolver como ordenar lista creditos
         MostrarCreditos(pelicula1);
         MostrarCreditos(pelicula2);
         MostrarCreditos(pelicula3);

         Console.WriteLine(divisor);
         Console.WriteLine(" mostrando sumatoria de sueldos...");
         Console.WriteLine($"{pelicula1} = ${pelicula1.SumarSueldos()}");
         Console.WriteLine($"{pelicula2} = ${pelicula2.SumarSueldos()}");
         Console.WriteLine($"{pelicula3} = ${pelicula3.SumarSueldos()}");
         
         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarPersonajes(Pelicula pelicula)
      {
         Console.WriteLine($" mostrando personajes de {pelicula.Nombre}:");
         foreach (var personaje in pelicula.GetPersonajes())
            Console.WriteLine(" - " + personaje);
      }

      private static void MostrarCreditos(Pelicula pelicula)
      {
         Console.WriteLine($" creditos de {pelicula.Nombre}:");
         foreach (var credito in pelicula.GetCreditos())
            Console.WriteLine(" - " + credito);
      }
   }
}