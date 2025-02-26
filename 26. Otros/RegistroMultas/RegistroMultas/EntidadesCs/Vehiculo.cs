using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Vehiculo : IMultado
   {
      private List<Multa> multas;
      private decimal totalMultas = 0;

      public string patente;
      public Propietario propietario;

      public Vehiculo (string patente)
      {
         multas = new List<Multa>();

         Patente = patente;
      }

      public string Patente
      {
         get
         {
            return patente;
         }
         set
         {
            if (value.Length != 6 && value.Length != 8)
               throw new ArgumentException(" la patente debe tener 6 u 8 caracteres.");
            patente = value;
         }
      }

      internal void AddMulta(Multa multa)
      {
         if (multa == null)
            throw new ArgumentException(" la multa no puede estar vacia");
         if (multas.Contains(multa))
            throw new ArgumentException($" la multa {multa} ya esta registrada.");
         multas.Add(multa);
         totalMultas += multa.CalcularMonto();
      }

      internal void RemoveMulta(Multa multa)
      {
         if (multa == null)
            throw new ArgumentException(" la multa no puede estar vacia");
         if (!multas.Contains(multa))
            throw new ArgumentException($" la multa {multa} no esta registrada.");
         multas.Remove(multa);
         totalMultas -= multa.CalcularMonto();
      }

      public List<Multa> GetMultas()
      {
         return multas;
      }

      public decimal GetTotalMultas()
      {
         return totalMultas;
      }

      public override string ToString()
      {
         if (propietario != null)
            return $"{Patente.ToUpper()} [{propietario}]";
         else
            return $"{Patente.ToUpper()}";
      }
   }
}
