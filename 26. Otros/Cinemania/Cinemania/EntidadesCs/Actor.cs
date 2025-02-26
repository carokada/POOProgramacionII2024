using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Actor : Ente
   {
      public DateTime fechaNacimiento;

      public Actor (string nombre, DateTime fechaNacimiento) : base (nombre)
      {
         FechaNacimiento = fechaNacimiento;
      }

      public DateTime FechaNacimiento
      {
         get => fechaNacimiento;
         set => fechaNacimiento = value < DateTime.Today ? value : throw new ArgumentException(" la fecha de nacimiento no cumple con los requerimientos del campo.");
      }

      public override string ToString()
      {
         return $"{Nombre}";
      }
   }
}
