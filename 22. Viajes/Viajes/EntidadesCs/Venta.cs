using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Venta : ICotizacion, IServicio
   {
      // ICotizacion
      public decimal PrecioPesos { get => PrecioDolar * CotizacionDolarPesos; } // en otras clases se llama a Venta.CotizacionDolarPesos
      public decimal PrecioDolar { get; set; }

      // Iservicio
      public string Descripcion { get; set; }
      public DateTime FechaInicial { get; set; }

      // asoc cliente
      public Cliente cliente;

      // asoc pasajero (multiple)
      private List<Pasajero> pasajeros;

      public DateTime Fecha { get; set; }
      public static decimal CotizacionDolarPesos { get; set; }

      public Venta (DateTime fecha, Cliente cliente)
      {
         pasajeros = new List<Pasajero>();

         Fecha = fecha;
         Cliente = cliente;
      }

      public Cliente Cliente
      {
         get => cliente;
         private set => cliente = value ?? throw new ArgumentException(" el cliente no puede ser nulo.");
      }


      //private decimal PrecioTotal() { } foreach de lista IServicios ?? confusing
      //los precios son en dolares
      //los precios en pesos se calculan segun la cotizacion del dolar

      public void AddPasajero(Pasajero pasajero)
      {
         if (pasajero == null)
            throw new ArgumentException(" el pasajero no puede ser nulo.");
         if (pasajeros.Contains(pasajero))
            throw new ArgumentException($" el pasajero {pasajero} ya se encuentra en la lista ");
         pasajeros.Add(pasajero);
      }

      public List<Pasajero> GetAllPasajeros()
      {
         return pasajeros;
      }

      public void RemovePasajero(Pasajero pasajero)
      {
         if (pasajero == null)
            throw new ArgumentException(" el pasajero no puede ser nulo.");
         if (!pasajeros.Contains(pasajero))
            throw new ArgumentException($" el pasajero {pasajero} no se encuentra en la lista ");
         pasajeros.Remove(pasajero);
      }

      public override string ToString()
      {
         return $" venta: \n cliente: {cliente.Nombre} \n fecha: {Fecha} \t\t precio total: $ ";
      }
   }
}
