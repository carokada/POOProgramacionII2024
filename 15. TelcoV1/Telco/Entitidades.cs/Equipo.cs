using System;
using System.Collections.Generic;
using System.Text;

namespace EntitidadesCs
{
   public class Equipo
   {
      private string serie;
      private DateTime fechaVenta;

      public Equipo(Marca marca, Modelo modelo, string serie)
      {
         Serie = serie;
      }

      public string Serie
      {
         get
         {
            return serie;
         }
         set
         {
            if (value.Length > 0 && value.Length <= 15)
               serie = value;
         }
      }

      public DateTime FechaVenta
      {
         get
         {
            return fechaVenta;
         }
      }

      public void Vender()
      {
         fechaVenta = DateTime.Now;
      }

      public override string ToString()
      {
         return string.Format("{0}: {1}", "Serie", serie);
      }
   }
}
