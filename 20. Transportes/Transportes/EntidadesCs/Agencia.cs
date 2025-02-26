﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   class Agencia
   {
      private static List<Factura> facturas = new List<Factura>(); // 

      public static void AddFactura(Factura factura) // un miembro static solo puede acceder a miembros static
      {
         if (factura == null)
            throw new ArgumentException(" la factura no puede ser nula.");
         if (facturas.Contains(factura))
            throw new ArgumentException(" la factura ya ha sido agregada al registro");
         facturas.Add(factura);
      }

      //public List<Factura> GetAllFacturas()
      //{
      //   return facturas;
      //}

      //public void RemoveFactura(Factura factura)
      //{
      //   if (factura == null)
      //      throw new ArgumentException(" la factura no puede ser nula.");
      //   if (!facturas.Contains(factura))
      //      throw new ArgumentException(" la factura no ha sido agregado al registro.");
      //   facturas.Remove(factura);
      //}

      public List<Factura> GetAllFacturasByFecha(DateTime fecha)
      {
         List<Factura> facturasPorFecha = new List<Factura>();

         foreach (var factura in facturas)
         {
            if (factura.Fecha.Date == fecha.Date) // Comparar solo la fecha, sin importar la hora
            {
               facturasPorFecha.Add(factura);
            }
         }
            return facturasPorFecha;
      }

      public List<Pasajero> GetPasajerosByDestinoAndFecha(Ciudad destino, DateTime fecha)
      {
         List<Pasajero> pasajerosPorDestinoYFecha = new List<Pasajero>();

         foreach (var factura in facturas)
         {
            foreach (var pasaje in factura.GetPasajes())
            {
               if (pasaje.Fecha == fecha && pasaje.Destino == destino)
               {
                  pasajerosPorDestinoYFecha.Add(pasaje.Pasajero);
               }
            }
         }

         return pasajerosPorDestinoYFecha;
      }

      public List<Persona> GetMovimientosByPersona(Persona persona)
      {
         List<Persona> movimientosPorPersona = new List<Persona>();

         foreach (var factura in facturas)
         {
            if (factura.Cliente.Dni == persona.Dni)
            {
               movimientosPorPersona.Add(factura.Cliente);
            }
            
            foreach (var pasaje in factura.GetPasajes())
            {
               if (pasaje.Pasajero.Dni == persona.Dni)
               {
                  movimientosPorPersona.Add(pasaje.Pasajero);
               }
            }
         }

         return movimientosPorPersona;
      }
   }
}
