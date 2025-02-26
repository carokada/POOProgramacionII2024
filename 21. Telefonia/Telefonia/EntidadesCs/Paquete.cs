using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Paquete : IPlan
   {
      private List<Servicio> servicios;

      public decimal Precio { get; private set; }
      public string Nombre { get; set; }

      public void AddServicio(Servicio servicio)
      {
         if (servicio == null)
            throw new ArgumentException(" el servicio no puede ser nulo.");
         if (servicios.Contains(servicio))
            throw new ArgumentException(" el servicio ya ha sido agregado a la lista.");
         servicios.Add(servicio);
      }

      public List<Servicio> GetAllServicios()
      {
         return servicios;
      }

      public void RemoveServicio (Servicio servicio)
      {
         if (servicio == null)
            throw new ArgumentException(" el servicio no puede ser nulo.");
         if (!servicios.Contains(servicio))
            throw new ArgumentException(" el servicio no ha sido agregado a la lista.");
         servicios.Remove(servicio);
      }

      public string GetDisponibleToString()
      {
         return $""; // ?? get disponible de servicio? de que servicio
      }

      public string GetConsumosToString()
      {
         return $""; // foreach de servicios ??
      }
   }
}
