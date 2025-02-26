using System;

namespace EntidadesCs
{
   public class Hotel : IServicio, ICotizacion
   {
      // IServicio
      public string descripcion { get; private set; } // deberian estar en mayusculas ?
      public DateTime fechaInicial { get; private set; }

      // ICotizacion
      public decimal PrecioPesos { get; private set; }
      public decimal PrecioDolar { get; private set; }
      
      // asoc ciudad
      public Ciudad Ciudad { get; set; }

      public byte Habitaciones { get; set; }
      public byte Noches { get; set; }
      public decimal PrecioDiaria { get; set; }
      // precio = precioDiaria * noches * habitaciones ?? donde se implementa esto

      public Hotel (string descripcion, DateTime fecha, Ciudad ciudad, byte noches, decimal precioDiaria)
      {
         this.descripcion = descripcion;
         this.fechaInicial = fecha;
         Ciudad = ciudad;
         Noches = noches;
         PrecioDiaria = precioDiaria;
      }

      public override string ToString()
      {
         return $" hotel: {descripcion} en {Ciudad} ({fechaInicial}) \n precio por noche: {PrecioDiaria}";
      }
   }
}
