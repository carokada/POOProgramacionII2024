using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Venta
   {
      private List<Paquete> paquetes;
      private decimal montoTotal;

      private DateTime fecha;
      private Cliente cliente;

      public Venta (Cliente cliente, DateTime fecha)
      {
         paquetes = new List<Paquete>();

         this.cliente = cliente;
         Fecha = fecha;
      }

      public DateTime Fecha
      {
         get => fecha;
         set => fecha = value >= DateTime.Now ? value : throw new ArgumentException(" la fecha no es valida.");
      }

      public void AddPaquete(Paquete paquete)
      {
         if (paquetes.Contains(paquete))
            throw new ArgumentException(" el paquete ya se encuentra en la venta.");
         paquetes.Add(paquete);
         montoTotal += paquete.MontoTotal();
      }

      public List<Paquete> GetPaquetes()
      {
         return paquetes;
      }

      public void RemovePaquete(Paquete paquete)
      {
         if (!paquetes.Contains(paquete))
            throw new ArgumentException(" el paquete no se encuentra en la venta.");
         paquetes.Remove(paquete);
         montoTotal -= paquete.MontoTotal();
      }

      public decimal MontoTotal()
      {
         return montoTotal;
      }

      public bool IsClientePasajero()
      {
         foreach (var paquete in paquetes)
         {
            foreach (var ticket in paquete.GetTickets())
            {
               if (ticket.Persona.Dni == cliente.Dni)
               {
                  return true;
               }
            }
         }
         return false;
      }

      public override string ToString()
      {
         return $"{cliente} [{Fecha.ToString("dd/MM/yyyy")}]";
      }
   }
}
