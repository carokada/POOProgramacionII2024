using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public abstract class Persona
   {
      private DateTime fechaNacimiento;
      public ushort Edad { get; private set; }
      private string nombre;

      public Persona ()
      {
         Nombre = string.Empty;
         fechaNacimiento = DateTime.MinValue;
         Edad = CalcularEdad();
      }

      public Persona (string nombre, DateTime fechaNacimiento)
      {
         Nombre = nombre;
         FechaNacimiento = fechaNacimiento;
         Edad = CalcularEdad();
      }

      /*public string Name
       {
         get => name;
         set => name = !string.IsNullOrEmpty(value) ? value : "invalid name";
       }
       */

      public string Nombre
      {
         get 
         {
            return nombre;
         }
         set
         {
            if (value.Length <= 0 || value.Length > 30)
               throw new ArgumentException(" el nombre no cumple con los requerimientos del campo.");
            nombre = value;
         }
      }

      public DateTime FechaNacimiento
      {
         get
         {
            return fechaNacimiento;
         }
         set
         {
            if (DateTime.Today.AddYears(-16) < value)
               throw new ArgumentException(" la persona debe tener por lo menos 16 anios.");
            fechaNacimiento = value;
         }
      }

      public ushort CalcularEdad()
      {
         int age = DateTime.Today.Year - FechaNacimiento.Year;

         if (FechaNacimiento.Date > DateTime.Today.AddYears(-age))
            age--;

         return (ushort) age;
      }

      public override string ToString()
      {
         return $" {Nombre} ({Edad})";
      }
   }
}
