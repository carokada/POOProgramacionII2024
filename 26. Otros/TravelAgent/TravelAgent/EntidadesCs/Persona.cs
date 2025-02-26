using System;

namespace EntidadesCs
{
   public class Persona
   {
      public uint dni;
      public string nombre;

      public Persona(uint dni, string nombre)
      {
         Dni = dni;
         Nombre = nombre;
      }

      public uint Dni
      {
         get => dni;
         set => dni = value > 1000000 || value >99999999 ? value : throw new ArgumentException(" el dni no es valido.");
      }

      public string Nombre
      {
         get => nombre;
         set => nombre = value.Length > 0 ? value : throw new ArgumentException(" el nombre no es valido.");
      }

      public override string ToString()
      {
         return $"{Nombre}";
      }
   }
}
