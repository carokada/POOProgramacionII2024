using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public sealed class Empresa : Propietario
   {
      private string cuit;

      public Empresa(string nombre, string cuit) : base(nombre)
      {
         Cuit = cuit;
      }

      public string Cuit
      {
         get
         {
            return cuit;
         }
         set
         {
            if (value.Length != 13)
               throw new ArgumentException(" el cuit debe tener 13 caracteres");
            cuit = value;
         }
      }

      public override string ToString()
      {
         return $"{Nombre} ({Cuit})";
      }
   }
}
