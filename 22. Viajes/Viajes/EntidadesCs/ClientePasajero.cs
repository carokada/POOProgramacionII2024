using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class ClientePasajero : Cliente, IPasajero
   {
      // IPasajero
      public uint Pasaporte { get; private set; }
      public uint Dni { get; private set; }
      public DateTime FechaNacimiento { get; private set; }

      public ClientePasajero (string cuitCuil, uint dni, string nombre, string domicilio, DateTime fechaNacimiento) : base(cuitCuil, nombre, domicilio)
      {
         Dni = dni;
         FechaNacimiento = fechaNacimiento;
      }

      public ClientePasajero (string cuitCuil, uint dni, string nombre, string domicilio, DateTime fechaNacimiento, uint pasaporte) : base(cuitCuil, nombre, domicilio)
      {
         Dni = dni;
         FechaNacimiento = fechaNacimiento;
         Pasaporte = pasaporte;
      }

      public override string ToString()
      {
         return $" cliente pasajero: \n nombre: {Nombre} ({FechaNacimiento}) \n dni: {Dni} \t\t cuit/cuil: {CuitCuil}";
      }
   }
}
