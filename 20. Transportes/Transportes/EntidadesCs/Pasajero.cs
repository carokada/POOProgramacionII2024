using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public sealed class Pasajero : Persona
   {
      private List<Pasaje> pasajes;

      public Pasajero(string dni, string nombre) : base(dni, nombre)
      {
         pasajes = new List<Pasaje>();
      }

      internal void AddPasaje(Pasaje pasaje) //nivel paquete porque la otra clase lo hace de manera publica. una expone y la otra no.
      {
         if (pasaje == null)
            throw new ArgumentException(" el pasaje no puede ser nulo.");
         pasajes.Add(pasaje);
      }

      public List<Pasaje> GetAllPasajes()
      {
         return pasajes;
      }

      // remove no es necesario porque no esta en el uml
      //public void RemovePasaje(Pasaje pasaje)
      //{
      //   if (!pasajes.Contains(pasaje))
      //      throw new ArgumentException(" el pasaje no ha sido agregado a la lista.");
      //   pasajes.Remove(pasaje);
      //}
   }
}
