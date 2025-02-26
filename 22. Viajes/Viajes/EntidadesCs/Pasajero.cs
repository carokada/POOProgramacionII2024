using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Pasajero : Entidad, IPasajero
   {
      //IPasajero
      public uint Pasaporte { get; set; }
      public uint Dni { get; set; }
      public DateTime FechaNacimiento { get; set; }

      private Pasajero tutor;

      public Pasajero(uint dni, string nombre, string domicilio, DateTime fechaNacimiento) : base(nombre, domicilio)
      {
         Dni = dni;
         FechaNacimiento = fechaNacimiento;
         Tutor = null;
      }

      public Pasajero(uint dni, string nombre, string domicilio, DateTime fechaNacimiento, uint pasaporte) : this(dni, nombre, domicilio, fechaNacimiento)
      {
         Pasaporte = pasaporte;
      }

      public Pasajero Tutor
      {
         get => tutor;
         set
         {
            if (IsMayorEdad())
               throw new ArgumentException(" no se puede asignar un tutor a un pasajero mayor de edad.");
            tutor = value;
         }
      }

      public bool IsMayorEdad()
      {
         if (FechaNacimiento.Date > DateTime.Today.AddYears(FechaNacimiento.Year - DateTime.Today.Year))
            return false;
         else
            return true;
      }

      public override string ToString()
      {
         return $" pasajero: ({Dni}) {Nombre}";
      }
   }
}
