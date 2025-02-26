using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Ticket
   {
      public Persona Persona { get; set; }
      private decimal monto;

      public Ticket (Persona persona, decimal monto)
      {
         Persona = persona;
         Monto = monto;
      }

      public decimal Monto
      {
         get => monto;
         set => monto = value > 0 ? value : throw new ArgumentException(" el monto no es valido.");
      }

      public override string ToString()
      {
         return $"{Persona}: ${Monto}";
      }
   }
}
