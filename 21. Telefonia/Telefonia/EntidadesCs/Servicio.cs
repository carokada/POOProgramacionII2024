using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public abstract class Servicio
   {
      public decimal Precio { get; private set; }
      public uint Credito { get; set; }
      public uint TotalConsumo { get; private set; }

      public Servicio (decimal precio, uint credito)
      {
         Precio = precio;
         Credito = credito;

         TotalConsumo = 0;
      }

      public void NuevoConsumo(uint valor)
      {
         TotalConsumo += valor;
      }

      public uint GetDisponible()
      {
         return Credito - TotalConsumo;
      }

      public string GetDisponibleToString()
      {
         return $"{GetDisponible()} de {ToString()}";
      }

      public string GetConsumosToString()
      {
         return $"{TotalConsumo}";
      }
   }
}
