using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Persona : Cliente
   {
      public int Dni { get; set; }

      public Persona(string nombre, int dni) : base(nombre)
      {
         Dni = dni;
      }
   }
}
