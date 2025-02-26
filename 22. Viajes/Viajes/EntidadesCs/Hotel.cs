using System;

namespace EntidadesCs
{
   public class Hotel : IServicio, ICotizacion
   {
      // IServicio
      public string Descripcion { get; set; } // deberian estar en mayusculas ?
      public DateTime FechaInicial { get; set; }

      // ICotizacion
      public decimal PrecioPesos { get => PrecioDolar * Venta.CotizacionDolarPesos; }
      public decimal PrecioDolar { get => PrecioDiaria * Noches * Habitaciones; }

      // asoc ciudad
      public Ciudad Ciudad { get; set; }

      public byte Habitaciones { get; set; }
      public byte Noches { get; set; }
      public decimal PrecioDiaria { get; set; }
      // precio = precioDiaria * noches * habitaciones ?? donde se implementa esto

      public Hotel (string descripcion, DateTime fecha, Ciudad ciudad, byte noches, decimal precioDiaria)
      {
         Descripcion = descripcion;
         FechaInicial = fecha;
         Ciudad = ciudad;
         Noches = noches;
         PrecioDiaria = precioDiaria;
      }

      public override string ToString()
      {
         return $" hotel: {Descripcion} en {Ciudad} ({FechaInicial.ToString("dd/MM/yy")}) \n precio por noche: {PrecioDiaria}";
      }
   }
}
