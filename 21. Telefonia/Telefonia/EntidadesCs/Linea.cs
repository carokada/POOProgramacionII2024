using System;

namespace EntidadesCs
{
   public class Linea
   {
      public Equipo equipo;
      public IPlan Plan { get; set; }
      public Paquete Paquete { get; set; }


      public ushort CodigoArea { get; set; }
      public uint Numero { get; set; }
      public string Estado { get; private set; }

      public Linea (ushort codigoArea, uint numero, Equipo equipo)
      {
         CodigoArea = codigoArea;
         Numero = numero;
         Equipo = equipo;
         Reactivar();
      }

      public void Suspender()
      {
         Estado = "suspendida";
      }

      public void Reactivar()
      {
         Estado = "activa";
      }

      public Equipo Equipo
      {
         get => equipo;
         set => equipo = value ?? throw new ArgumentException(" el equipo no puede ser nulo.");
      }

      public override string ToString()
      {
         if (Estado == "suspendida")
         {
            return $"{CodigoArea}-{Numero} ({Estado})";
         }
         else
         {
            return $"{CodigoArea}-{Numero}";
         }
      }
   }
}
