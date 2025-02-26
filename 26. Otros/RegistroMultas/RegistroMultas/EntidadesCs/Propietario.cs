using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public abstract class Propietario : IMultado
   {
      private List<Vehiculo> vehiculos;
      private List<Multa> multas;

      private decimal totalMultas;

      public string nombre;

      public Propietario(string nombre)
      {
         vehiculos = new List<Vehiculo>();
         Nombre = nombre;
      }

      public string Nombre
      {
         get => nombre;
         set => nombre = value.Length > 0 ? value : throw new ArgumentException(" el nombre no cumple con los requerimientos del campo");
      }

      internal void AddVehiculo(Vehiculo vehiculo)
      {
         if (vehiculos.Contains(vehiculo))
            throw new ArgumentException($" el vehiculo {vehiculo} ya esta registrado.");
         vehiculo.propietario = this;
         vehiculos.Add(vehiculo);
      }

      internal List<Vehiculo> Vehiculos => vehiculos;

      internal void RemoveVehiculo(Vehiculo vehiculo)
      {
         if (!vehiculos.Contains(vehiculo))
            throw new ArgumentException($" el vehiculo {vehiculo} no esta registrado.");
         vehiculo.propietario = null;
         vehiculos.Remove(vehiculo);
      }

      public List<Multa> GetMultas()
      {
         return multas;
      }

      public decimal GetTotalMultas()
      {
         return totalMultas;
      }
   }
}
