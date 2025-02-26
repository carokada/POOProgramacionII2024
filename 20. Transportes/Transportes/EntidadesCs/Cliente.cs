using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Cliente : Persona
   {
      private List<Factura> facturas;

      public Cliente(string dni, string nombre) : base(dni, nombre)
      {
         facturas = new List<Factura>();
      }

      internal void AddFactura(Factura factura) 
      {
         if (factura == null)
            throw new ArgumentException(" la factura no puede ser nula.");
         facturas.Add(factura);
      }

      public List<Factura> GetAllFacturas()
      {
         return facturas;
      }

      //public void RemoveFactura(Factura factura)
      //{
      //   if (!facturas.Contains(factura))
      //      throw new ArgumentException(" la factura no ha sido agregada a la lista.");
      //   facturas.Remove(factura);
      //}

   }
}
