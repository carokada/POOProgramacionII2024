using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Torneo
   {
      // asoc persona
      private List<Persona> personas;

      public Torneo() { } // si es clase de utilidades no tiene contructor ?

      public void AddPersona(Persona persona)
      {
         if (persona == null)
            throw new ArgumentException(" la persona no puede ser nula.");
         if (personas.Contains(persona))
            throw new ArgumentException($" la persona {persona.Nombre} ya esta incluida en el torneo.");
         personas.Add(persona);
      }

      public List<Persona> GetPersonas()
      {
         return personas;
      }

      public void RemovePersona(Persona persona)
      {
         if (persona == null)
            throw new ArgumentException(" la persona no puede ser nula.");
         if (!personas.Contains(persona))
            throw new ArgumentException($" la persona {persona.Nombre} no esta incluida en el torneo.");
         personas.Add(persona);
      }

      // TotalGolesFavor(Partido partido) -> por local
      // TotalGolesContra(Partido partido) -> por visitante
      // TotalPuntosByEquipo(Equipo equipo) -> 3pts x ganado, 1 x empate, 0 x partido
   }
}
