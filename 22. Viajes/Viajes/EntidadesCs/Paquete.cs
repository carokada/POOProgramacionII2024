using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Paquete : IServicio, ICotizacion
   {
      // IServicio
      public decimal PrecioPesos { get => Venta.CotizacionDolarPesos * PrecioDolar; }
      public decimal PrecioDolar { get => CalcularSumatoria(); }

      // ICotizacion
      public DateTime FechaInicial { get; set; }
      public string Descripcion { get; set; }
      
      // asoc (multiple) Iservicio toma tanto hotel como pasaje como paquete
      private List<IServicio> servicios;

      private DateTime FechaFinal { get; set; }
      private ushort NumeroDias { get; set; }
      private ushort NumeroPasajeros { get; set; }
      // precio = Sumatoria(precio) ?? campo precio final ?

      public Paquete (string descripcion, DateTime fechaInicial, DateTime fechaFinal)
      {
         servicios = new List<IServicio>();

         Descripcion = descripcion;
         FechaInicial = fechaInicial;
         FechaFinal = fechaFinal;
      }

      public void AddServicio (IServicio servicio)
      {
         if (servicios.Contains(servicio))
            throw new ArgumentException(" el servicio ya se encuentra en la lista de servicios.");
         servicios.Add(servicio);
      }

      public List<IServicio> GetAllServicios()
      {
         return servicios;
      }

      public void RemoveServicio (IServicio servicio)
      {
         if (!servicios.Contains(servicio))
            throw new ArgumentException(" el servicio no se encuentra en la lista de servicios.");
         servicios.Remove(servicio);
      }

      public decimal CalcularSumatoria()
      {
         int total = 0;
         foreach (var servicio in servicios)
         {
            total += servicio.precio;
         }
         return total;
      }

      public override string ToString()
      {
         return $" paquete: {Descripcion} \n desde: {FechaInicial} \t\t hasta: {FechaFinal} \n dias: {NumeroDias} \t\t pasajeros: {NumeroPasajeros}";
      }
   }
}
