using System;
using System.Collections.Generic;

namespace EntidadesCs
{
   public class Equipo
   {
      public string nombre;

      public List<Persona> jugadores;

      public Equipo ()
      {
         jugadores = new List<Persona>();

         Nombre = string.Empty;
      }

      public Equipo (string nombre)
      {
         jugadores = new List<Persona>();

         Nombre = nombre;
      }

      public string Nombre
      {
         get
         {
            return nombre;
         }
         set
         {
            if (value.Length <= 0 || value.Length > 30)
               throw new ArgumentException(" el nombre no cumple con los requerimientos del campo.");
            nombre = value;
         }
      }

      public void ComprarJugador(Persona jugador)
      {
         if (jugador == null)
            throw new ArgumentException(" el jugador no puede ser nulo.");
         if (jugadores.Contains(jugador))
            throw new ArgumentException($" el jugador {jugador.Nombre} ya esta en el equipo.");
         jugadores.Add(jugador);
      }

      public List<Persona> GetAllJugadores()
      {
         return jugadores;
      }

      public void VenderJugador(Persona jugador, Equipo equipoDestino)
      {
         if (jugador == null)
            throw new ArgumentException(" el jugador no puede ser nulo.");
         if (!jugadores.Contains(jugador))
            throw new ArgumentException($" el jugador {jugador.Nombre} no esta en el equipo.");
         jugadores.Remove(jugador);
         equipoDestino.ComprarJugador(jugador);
      }

      public void LiberarJugador(Persona jugador)
      {
         if (jugador == null)
            throw new ArgumentException(" el jugador no puede ser nulo.");
         if (!jugadores.Contains(jugador))
            throw new ArgumentException($" el jugador {jugador.Nombre} no esta en el equipo.");
         jugadores.Remove(jugador);
      }

      public override string ToString()
      {
         return $"{Nombre}";
      }
   }
}
