using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Persona : Propietario
   {
      public string dni;

      public Persona(string nombre, string dni) : base(nombre)
      {
         Dni = dni;
      }

      public string Dni
      {
         get
         {
            return dni;
         }
         set
         {
            if (value.Length != 8)
               throw new ArgumentException(" el dni debe tener 8 caracteres.");
            dni = value;
         }
      }

      public override string ToString()
      {
         return $"{Nombre} ({Dni})";
      }
   }
}
