using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Jugador : Persona
   {
      public byte numero;

      public Equipo equipoActual;

      public Jugador(string nombre, DateTime fechaNacimiento, byte numero) : base(nombre, fechaNacimiento)
      {
         Numero = numero;
      }

      public byte Numero
      {
         get
         {
            return numero;
         }
         set
         {
            if (value < 1 || value > 99)
               throw new ArgumentException(" el numero no cumple con los requerimientos del campo.");
            numero = value;
         }
      }

      public Equipo EquipoActual
      {
         get
         {
            return equipoActual;
         }
         set
         {
            equipoActual = value;
         }
      }

      public void SetEquipo(Equipo equipo)
      {
         EquipoActual = equipo;
      }

      public override string ToString()
      {
         return $"{Nombre} [#{Numero}]";
      }
   }
}
