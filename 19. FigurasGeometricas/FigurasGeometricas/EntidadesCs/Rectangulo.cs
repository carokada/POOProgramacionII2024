using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Rectangulo :  Figura
   {
      public float Altura { get; set; }
      public float Base { get; set; }

      public Rectangulo(string nombre, float @base, float altura) : base(nombre)
      {
         Altura = altura;
         Base = @base;
      }

      public override float CalcularArea()
      {
         return Base * Altura;
      }

      public override string ToString()
      {
         //return string.Format("{0}\n area: {1}", base.ToString(), CalcularArea());
         return $"Soy {Nombre} y tengo la base de {Base} y la altura de {Altura}";
      }
   }
}
