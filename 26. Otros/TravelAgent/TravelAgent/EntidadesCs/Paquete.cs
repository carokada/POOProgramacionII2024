using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Paquete
   {
      private List<Ticket> tickets;
      public decimal montoTotal; // public decimal MontoTotal => montoTotal; propiedad de solo lectura?

      private readonly ushort numeroDias;
      private byte numeroTickets = 0;

      public string descripcion;
      public DateTime fechaInicial;
      public DateTime fechaFinal;

      public Paquete (string descripcion, DateTime fechaInicial, DateTime fechaFinal)
      {
         tickets = new List<Ticket>();

         Descripcion = descripcion;
         FechaInicial = fechaInicial;
         FechaFinal = fechaFinal;
      }

      public string Descripcion
      {
         get => descripcion;
         set => descripcion = value.Length > 0 ? value : throw new ArgumentException(" la descripcion no es valida.");
      }

      public DateTime FechaInicial
      {
         get => fechaInicial;
         set => fechaInicial = value >= DateTime.Today ? value : throw new ArgumentException(" la fecha no es valida.");
      }

      public DateTime FechaFinal
      {
         get => fechaFinal;
         set => fechaFinal = value >= this.fechaInicial ? value : throw new ArgumentException(" la fecha no es valida.");
      }

      public ushort NumeroDias
      {
         get
         {
            TimeSpan diferencia = FechaFinal - fechaInicial;
            return (ushort) diferencia.Days;
         }
      }

      public byte NumeroTickets
      {
         get
         {
            return numeroTickets;
         }
      }

      public void AddTicket(Ticket ticket)
      {
         if (tickets.Contains(ticket))
            throw new ArgumentException(" el ticket ya se encuentra en el paquete.");
         tickets.Add(ticket);
         numeroTickets++;
         montoTotal += ticket.Monto;
      }

      public List<Ticket> GetTickets()
      {
         return tickets;
      }

      public void RemoveTicket(Ticket ticket)
      {
         if (!tickets.Contains(ticket))
            throw new ArgumentException(" el ticket no se encuentra en el paquete.");
         tickets.Remove(ticket);
         numeroTickets--;
         montoTotal -= ticket.Monto;
      }

      public decimal MontoTotal()
      {
         return montoTotal;
      }

      public override string ToString()
      {
         return $"{Descripcion} ({NumeroDias} dias) ${montoTotal}";
      }
   }
}
