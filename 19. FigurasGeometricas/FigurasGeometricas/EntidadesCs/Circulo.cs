using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Circulo : Figura
   {
      private float Radio { get; set; }

      public Circulo(string nombre, float radio) : base(nombre)
      {
         Radio = radio;
      }

      public override float CalcularArea()
      {
         return (float) (Math.PI * (Math.Pow(Radio, 2)));
      }

      public override string ToString()
      {
         //return string.Format("{0}\n area: {1}", base.ToString(), CalcularArea());
         return $"Soy {Nombre} y tengo un radio de {Radio}";
      }
   }
}
