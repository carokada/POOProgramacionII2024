using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Pasaje : IServicio, ICotizacion
   {
      // Iservicio
      public string Descripcion { get; set; }
      public DateTime FechaInicial { get; set; }

      // ICotizacion
      public decimal PrecioPesos { get => PrecioDolar * Venta.CotizacionDolarPesos; }
      public decimal PrecioDolar { get => PrecioUnitario * Asientos; }

      // asoc destino/origen
      public Ciudad Origen { get; set; }
      public Ciudad Destino { get; set; }

      public decimal PrecioUnitario { get; set; }
      public byte Asientos { get; set; }
      // precio = precioUnitario * asientos

      public Pasaje (string descripcion, DateTime fecha, decimal precioUnitario, byte asientos, Ciudad origen, Ciudad destino)
      {
         Descripcion = descripcion;
         FechaInicial = fecha;
         PrecioUnitario = precioUnitario;
         Asientos = asientos;
         Origen = origen;
         Destino = destino;
      }

      public override string ToString()
      {
         return $" pasaje: {Descripcion} desde {Origen} hasta {Destino} el dia {FechaInicial} \n cantidad: {Asientos} \t\t precio: {PrecioUnitario}";
      }
   }
}
