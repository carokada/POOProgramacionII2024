using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Factura
   {
      private List<Pasaje> pasajes; // asoc pasaje (1 a muchos)
      public Cliente cliente; // asoc cliente (1 a 1)

      public DateTime fecha;

      public Factura (DateTime fecha, Cliente cliente)
      {
         pasajes = new List<Pasaje>();

         Fecha = fecha;
         Cliente = cliente;

         Agencia.AddFactura(this); // para agregar a la lista de la clase de utilidad
      }

      public Cliente Cliente
      {
         get => cliente;
         set => cliente = value ?? throw new ArgumentException(" el cliente no puede ser nulo."); // falta la invocacion a AddFactura de cliente
      }

      public DateTime Fecha
      {
         get => fecha;
         set => fecha = value <= DateTime.Now ? value : throw new ArgumentException(" la fecha no puede ser mayor a la del sistema.");

      }

      public decimal CalcularMontoTotal() // ESTA BIEN
      {
         decimal total = 0;
         foreach (var pasaje in pasajes)
         {
            total += pasaje.Monto + pasaje.CalcularIva();
         }
         return total;
      }

      public void AddPasaje(Pasaje pasaje)
      {
         if (pasaje == null)
            throw new ArgumentException(" el pasaje no puede ser nulo.");
         if (pasajes.Contains(pasaje))
            throw new ArgumentException(" el pasaje ya ha sido agregado al registro.");
         pasajes.Add(pasaje);
         
      }

      public List<Pasaje> GetPasajes()
      {
         return pasajes;
      }

      public void RemovePasaje(Pasaje pasaje)
      {
         if (pasaje == null)
            throw new ArgumentException(" el pasaje no puede ser nulo.");
         if (!pasajes.Contains(pasaje))
            throw new ArgumentException(" el pasaje no ha sido agregado al registro.");
         pasajes.Remove(pasaje);
      }

      public override string ToString()
      {
         return $"[{Fecha.ToString("dd/MM/yy")}] nombre: {Cliente.Nombre} (monto total: ${CalcularMontoTotal()})";
      }
   }
}
