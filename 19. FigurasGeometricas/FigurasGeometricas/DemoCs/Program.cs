using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCs;

namespace DemoCs
{
   class Program
   {
      static void Main(string[] args)
      {
         // para realizar la herencia de forma correcta, se declara el obj como clase  base pero se crea con el constructor de la clase derivada: tiene la apariencia de la figura pero el comportamiento de la subclase
         float lado1 = 10;
         Figura cuadrado = new Cuadrado("mi cuadrado", lado1);
         Console.WriteLine($"{cuadrado} con superficie de {cuadrado.CalcularArea()}");

         float lado2 = 5;
         Figura rectangulo = new Rectangulo("mi rectangulo", lado1, lado2);
         Console.WriteLine($"{rectangulo} con superficie de {rectangulo.CalcularArea()}");

         Figura triangulo = new Triangulo("mi triangulo rectangulo", lado1, lado2);
         Console.WriteLine($"{triangulo} con superficie de {triangulo.CalcularArea()}");

         Figura circulo = new Circulo("mi circulo", lado1);
         Console.WriteLine($"{circulo} con superficie de {circulo.CalcularArea()}");

         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }
   }
}
