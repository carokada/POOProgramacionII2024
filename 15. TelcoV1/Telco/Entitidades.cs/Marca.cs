using System;

namespace EntitidadesCs
{
   public class Marca
   {
      private string nombre;

      public Marca(string nombre) //constructor  -- : this() para invocar al constructor inicial
      {
         Nombre = nombre;
      }

      public string Nombre //propiedad
      {
         get
         {
            return nombre;
         }
         set
         {
            if (value.Length > 0 && value.Length <= 30)
               nombre = value;
         }
      }

      public override string ToString()
      {
         return string.Format("{0}: {1}", "Nombre", nombre);
      }
   }
}
