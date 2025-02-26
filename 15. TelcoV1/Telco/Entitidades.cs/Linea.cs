using System;
using System.Collections.Generic;
using System.Text;

namespace EntitidadesCs
{
   public class Linea
   {
      private ushort codigoArea;
      private UInt32 numero;
      private string estado;

      public Linea(ushort codigoArea, UInt32 numero)
      {
         CodigoArea = codigoArea;
         Numero = numero;
      }

      public ushort CodigoArea
      {
         get
         {
            return codigoArea;
         }
         set
         {
            if (value >= 100 && value <= 9999)
               codigoArea = value;
         }
      }

      public UInt32 Numero
      {
         get
         {
            return numero;
         }
         set
         {
            if (value >= 100000 && value <= 9999999)
               numero = value;
         }
      }

      public string Estado
      {
         get
         {
            return estado;
         }
      }

      public void suspender()
      {
         estado = "suspendida";
      }

      public void reactivar()
      {
         estado = "activa";
      }

      public override string ToString()
      {
         if (estado == "suspendida")
         {
            return string.Format("({0}){1} ({2})",
               codigoArea, numero, estado);
         }
         else
         {
            return string.Format("({0}){1}",
               codigoArea, numero);
         }
      }
   }
}
