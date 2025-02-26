using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Partido
   {
      // asoc equipo (simple)
      public Equipo Local { get; set; }
      public Equipo Visitante { get; set; }

      // asoc referee (simple)
      public Persona Arbitro { get; set; }

      public byte Jornada { get; set; }
      public DateTime Fecha { get; set; }
      public byte GolesLocales { get; private set; }
      public byte GolesVisitantes { get; private set; }
      private List<byte> minutosGolesLocales;
      private List<byte> minutosGolesVisitantes;
      private bool finPartido;

      public Partido(byte jornada, DateTime fecha, Equipo equipoLocal, Equipo equipoVisitante, Referee arbitro)
      {
         minutosGolesLocales = new List<byte>();
         minutosGolesVisitantes = new List<byte>();

         Jornada = jornada;
         Fecha = fecha;
         Local = equipoLocal;
         Visitante = equipoVisitante;
         Arbitro = arbitro;
         GolesLocales = 0;
         GolesVisitantes = 0;
         finPartido = false;
      }

      public Partido(byte jornada, DateTime fecha, Equipo equipoLocal, Equipo equipoVisitante, Referee arbitro, byte golesLocal, byte golesVisitante) : this (jornada, fecha, equipoLocal, equipoVisitante, arbitro)
      {
         GolesLocales = golesLocal;
         GolesVisitantes = golesVisitante;
         Finalizado();
      }

      public void SetArbitro(Persona arbitro)
      {
         if (!finPartido)
         {
            Arbitro = arbitro;
         }
         else
         {
            throw new ArgumentException(" no se puede asignar un arbitro. el partido se marco como finalizado.");
         }
      }

      public void NuevoGolLocal(ushort minutos)
      {
         if (!finPartido)
         {
            minutosGolesLocales.Add((byte)minutos);
            GolesLocales++;
         }
         else
         {
            throw new ArgumentException(" no se pueden agregar goles. el partido se marco como finalizado.");
         }
      }

      public void NuevoGolVisitante(ushort minutos)
      {
         if (!finPartido)
         {
            minutosGolesVisitantes.Add((byte)minutos);
            GolesVisitantes++;
         }
         else
         {
            throw new ArgumentException(" no se pueden agregar goles. el partido se marco como finalizado.");
         }
      }

      public List<byte> GetAllGolesLocales()
      {
         return minutosGolesLocales;
      }

      public List<byte> GetAllGolesVisitantes()
      {
         return minutosGolesVisitantes;
      }

      public void Finalizado()
      {
         finPartido = true;
      }

      public override string ToString()
      {
         return $" partido #{Jornada} [{Fecha.ToString("dd/MM/yy")}]: {Local} ({GolesLocales}) - {Visitante} ({GolesVisitantes})";
      }
   }
}
