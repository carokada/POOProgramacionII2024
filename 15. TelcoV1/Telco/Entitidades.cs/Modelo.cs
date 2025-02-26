using System;
using System.Collections.Generic;
using System.Text;

namespace EntitidadesCs
{
   public class Modelo
   {
      private string nombre;

      public Modelo(string nombre)
      {
         Nombre = nombre;
      }

      public string Nombre
      {
         get
         {
            return nombre;
         }
         set
         {
            if (value.Length > 0 && value.Length <= 50)
               nombre = value;
         }
      }

      public override string ToString()
      {
         return string.Format("{0}: {1}", "Nombre", nombre);
      }
   }
}
