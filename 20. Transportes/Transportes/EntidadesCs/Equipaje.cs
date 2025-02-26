using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Equipaje
   {
      public byte pesoKilos { get; set; } = 1;
      public Pasaje pasaje;
      public decimal monto;

      public Equipaje(Pasaje pasaje)
      {
         Pasaje = pasaje;
      }

      //public Equipaje(Pasaje pasaje, byte pesoKilos) : this (pasaje)
      //{
      //   PesoKilos = pesoKilos;
      //}

      // MONTO: anular set, get es 10% del pasaje - pesosKilos predeterminado 1

      public Pasaje Pasaje
      {
         get => pasaje;
         set => pasaje = value ?? throw new ArgumentException(" el pasaje no puede ser nulo.");
      }

      public byte PesoKilos
      {
         get => (byte) (pasaje.Monto * 0.1M);
      }
   }
}
