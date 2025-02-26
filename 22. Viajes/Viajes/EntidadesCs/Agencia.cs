﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Agencia
   {
      // asoc venta (multiple)
      private static List<Venta> ventas = new List<Venta>();

      public static void AddVenta(Venta venta)
      {
         if (venta == null)
            throw new ArgumentException(" debe especificar una venta.");
         if (ventas.Contains(venta))
            throw new ArgumentException($" la venta {venta} ya se encuentra en la lista ");
         ventas.Add(venta);
      }

      public static List<Venta> GetAllVentas()
      {
         return ventas;
      }

      public static void RemoveVenta(Venta venta)
      {
         if (venta == null)
            throw new ArgumentException(" debe especificar una venta.");
         if (!ventas.Contains(venta))
            throw new ArgumentException($" la venta {venta} no se encuentra en la lista ");
         ventas.Remove(venta);
      }
   }
}
