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
         // sin clase torneo
         string divisor = "----------------------------------------------------------";

         Console.WriteLine(divisor);
         Console.WriteLine(" creando equipos...");
         Equipo equipo1 = new Equipo("boca");
         Equipo equipo2 = new Equipo("tigre");
         Equipo equipo3 = new Equipo("all boys");
         try
         {
            Equipo equipo4 = new Equipo("club atletico san lorenzo de almagro");
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error :" + e.Message);
         }

         Console.WriteLine("\n mostrando equipos cargados...");
         Console.WriteLine(equipo1);
         Console.WriteLine(equipo2);
         Console.WriteLine(equipo3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando jugadores...");
         Persona jugador1 = new Jugador("martin gularte", new DateTime(2008, 10, 12), 15);
         Persona jugador2 = new Jugador("fabricio gomez", new DateTime(2008, 5, 30), 16);
         Persona jugador3 = new Jugador("alejandro prieto", new DateTime(2008, 7, 22), 17);
         try
         {
            Persona jugador4 = new Jugador("Carmen Elizabeth Juanita Echo Sky Brava Cortez", new DateTime(2008, 10, 12), 18);
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error :" + e.Message);
         }
         try
         {
            Persona jugador5 = new Jugador("juan salguero", new DateTime(2009, 4, 9), 19);
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error :" + e.Message);
         }
         try
         {
            Persona jugador5 = new Jugador("mario garcia", new DateTime(2006, 9, 15), 134);
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error :" + e.Message);
         }

         Console.WriteLine("\n mostrando jugadores cargados...");
         Console.WriteLine(jugador1);
         Console.WriteLine(jugador2);
         Console.WriteLine(jugador3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando arbitros...");
         Persona arbitro1 = new Referee("juan salguero", new DateTime(1998, 10, 12), true);
         Persona arbitro2 = new Referee("bernardo hidalgo", new DateTime(1999, 8, 31), false);
         Persona arbitro3 = new Referee("roberto bautista", new DateTime(2000, 11, 3), false);

         Console.WriteLine("\n mostrando arbitros cargados...");
         Console.WriteLine(arbitro1);
         Console.WriteLine(arbitro2);
         Console.WriteLine(arbitro3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando partidos...");
         Partido partido1 = new Partido(1, new DateTime(2025, 2, 15), equipo1, equipo2, (Referee)arbitro2);
         Partido partido2 = new Partido(2, new DateTime(2025, 2, 16), equipo2, equipo3, (Referee)arbitro3, 3, 1);
         Partido partido3 = new Partido(3, new DateTime(2025, 2, 17), equipo3, equipo1, (Referee)arbitro1);

         Console.WriteLine("\n mostrando partidos cargados...");
         Console.WriteLine(partido1);
         Console.WriteLine(partido2);
         Console.WriteLine(partido3);

         Console.WriteLine(divisor);
         Console.WriteLine(" cargando goles...");
         partido1.NuevoGolVisitante(10);
         partido1.NuevoGolLocal(15);
         partido1.NuevoGolLocal(25);
         partido1.Finalizado();
         Console.WriteLine("\n" + partido1);
         try
         {
            partido1.NuevoGolVisitante(35);
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error :" + e.Message);
         }
         VerGolesLocales(partido1);
         VerGolesVisitantes(partido1);
         Console.WriteLine();
         try
         {
            partido2.SetArbitro(arbitro1);
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error :" + e.Message);
         }
         Console.WriteLine(partido2);

         //partido3.SetArbitro(arbitro1);
         partido3.NuevoGolVisitante(35);
         partido3.NuevoGolVisitante(40);
         partido3.Finalizado();

         Console.WriteLine(partido3 + "\t" + partido3.Arbitro);
         VerGolesLocales(partido3);
         VerGolesVisitantes(partido3);

         Console.WriteLine(divisor);
         Console.WriteLine(" compra/venta de jugadores...");
         equipo1.ComprarJugador(jugador1);
         equipo1.ComprarJugador(jugador2);
         equipo1.ComprarJugador(jugador3);
         try
         {
            equipo1.ComprarJugador(jugador3);
         }
         catch (Exception e)
         {
            Console.WriteLine(" !! error :" + e.Message);
         }
         Console.WriteLine();
         VerJugadores(equipo1);
         equipo1.VenderJugador(jugador2, equipo3);
         equipo1.LiberarJugador(jugador3);
         VerJugadores(equipo1);
         VerJugadores(equipo2);
         VerJugadores(equipo3);

         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void VerJugadores(Equipo equipo)
      {
         Console.WriteLine($"\n jugadores en el equipo {equipo.Nombre}:");
         foreach (var jugador in equipo.GetAllJugadores())
         {
            Console.WriteLine(" - " + jugador);
         }
      }

      private static void VerGolesVisitantes(Partido partido)
      {
         Console.WriteLine($"\n {partido}: goles visitante:");
         foreach (var gol in partido.GetAllGolesVisitantes())
         {
            Console.WriteLine(" - minuto " + gol);
         }
      }

      private static void VerGolesLocales(Partido partido)
      {
         Console.WriteLine($"\n {partido}: goles local:");
         foreach (var gol in partido.GetAllGolesLocales())
         {
            Console.WriteLine(" - minuto " + gol);
         }
      }
   }
}
