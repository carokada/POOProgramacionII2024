using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Personaje : Ente
   {
      public decimal Sueldo { get; set; }
      private Actor actor;

      public Personaje (string nombre, Actor actor, decimal sueldo) : base(nombre)
      {
         Actor = actor;
         Sueldo = sueldo;
      }

      public Actor Actor
      {
         get => actor;
         set => actor = value ?? throw new ArgumentNullException(" el actor no puede ser nulo.");
      }

      public override string ToString()
      {
         return $"{Nombre} ({actor})";
      }
   }
}
