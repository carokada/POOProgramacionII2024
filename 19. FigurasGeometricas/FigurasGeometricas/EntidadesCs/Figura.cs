using System;

namespace EntidadesCs
{
   public abstract class Figura
   {
      public string Nombre { get; set; }

      public Figura(string nombre)
      {
         Nombre = nombre;
      }

      public abstract float CalcularArea();
   }
}
