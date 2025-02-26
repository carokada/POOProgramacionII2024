using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Multa
   {
      private Vehiculo vehiculo;

      private DateTime fecha;
      private decimal latitud;
      private decimal longitud;
      private ushort unidades = 1;
      public decimal MontoUnidad { get; set; }
       
      public Multa (Vehiculo vehiculo, DateTime fecha, decimal latitud, decimal longitud)
      {
         this.vehiculo = vehiculo;
         Fecha = fecha;
         Longitud = longitud;
         Latitud = latitud;
      }

      public Multa (Vehiculo vehiculo, DateTime fecha, decimal latitud, decimal longitud, ushort unidades) : this(vehiculo, fecha, latitud, longitud)
      {
         Unidades = unidades;
      }

      public DateTime Fecha
      {
         get => fecha;
         set => fecha = value < DateTime.Now ? value : throw new ArgumentException(" la fecha no es valida");
      }

      public decimal Latitud
      {
         get => latitud;
         set => latitud = value >= -90 && value <= 90 ? value : throw new ArgumentException(" la latitud debe ser un valor entre -90 y 90."); 
      }

      public decimal Longitud
      {
         get => longitud;
         set => longitud = value >= -180 && value <= 180 ? value : throw new ArgumentException(" la longitud debe ser un valor entre -180 y 180.");
      }

      public ushort Unidades
      {
         get => unidades;
         set => unidades = value > 0 ? value : throw new ArgumentException(" el valor debe ser mayor a cero.");
      }

      public decimal CalcularMonto()
      {
         return MontoUnidad * unidades;
      }

      public override string ToString()
      {
         return $"{vehiculo} ({Fecha.ToString("dd/MM/yyyy")}) ${CalcularMonto()}";
      }
   }
}
