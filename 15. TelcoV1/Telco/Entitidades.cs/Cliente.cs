using System;
using System.Collections.Generic;
using System.Text;

namespace EntitidadesCs
{
   public class Cliente
   {
      private UInt32 cuenta;

      public Cliente(UInt32 cuenta)
      {
         Cuenta = cuenta;
      }

      public UInt32 Cuenta
      {
         get
         {
            return cuenta;
         }
         set
         {
            cuenta = value;
         }
      }
   }
}
