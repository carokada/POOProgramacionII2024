using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public abstract class Contenido
   {
      private string nombre;

      public Contenido (string nombre)
      {
         Nombre = nombre;
      }

      public string Nombre
      {
         get => nombre;
         set => nombre = value.Length >= 1 ? value : throw new ArgumentException(" el nombre no cumple con los requerimientos del campo.");
      }
   }
}
