using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Triangulo :  Figura
   {
      public float Altura { get; set; }
      public float Base { get; set; }

      public Triangulo (string nombre, float @base, float altura) : base (nombre)
      {
         Base = @base;
         Altura = altura;
      }

      public override float CalcularArea()
      {
         return (float) ((Base * Altura) / 2);
      }

      public override string ToString()
      {
         //return string.Format("{0}\n area: {1}", base.ToString(), CalcularArea());
         return $"Soy {Nombre} y tengo la base de {Base} y la altura de {Altura}";
      }
   }
}
