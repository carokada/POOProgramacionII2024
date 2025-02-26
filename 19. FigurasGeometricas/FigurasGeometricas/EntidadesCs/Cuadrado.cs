using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Cuadrado : Figura
   {
      private float Lado { get; set; }

      public Cuadrado(string nombre, float lado) : base(nombre)
      {
        Lado = lado;
      }

      // override sobreescribe CalcularArea de clase base
      public override float CalcularArea()
      {
         return (float) Math.Pow((double) Lado, 2);
      }

      public override string ToString()
      {
         //return string.Format("{0}\n area: {1}", base.ToString(), CalcularArea());
         return $"Soy {Nombre} y tengo mis lados de {Lado}";
      }
   }
}
