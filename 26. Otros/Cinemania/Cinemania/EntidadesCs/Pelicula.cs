using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Pelicula : Ente
   {
      public ushort Anio { get; set; }

      private List<Personaje> personajes;
      private List<string> creditos;
      private decimal[] topSueldo = { 0, 0, 0};
      private string[] topSueldoNombres = { "", "", ""};
      private List<Personaje> topSueldos;

      public Pelicula (string nombre, ushort anio) : base(nombre)
      {
         personajes = new List<Personaje>();

         Anio = anio;  
      }

      public void AddPersonaje(Personaje personaje)
      {
         if (personajes.Contains(personaje))
            throw new ArgumentException($" el personaje {personaje} ya esta en la lista.");
         personajes.Add(personaje);
      }

      public List<Personaje> GetPersonajes()
      {
         return personajes;
      }

      public void RemovePersonaje(Personaje personaje)
      {
         if (!personajes.Contains(personaje))
            throw new ArgumentException($" el personaje {personaje} no esta en la lista.");
         personajes.Remove(personaje);
      }

      public List<string> GetCreditos()
      {
         creditos = new List<string>();
         foreach (var personaje in personajes)
         {
            string lineaCredito = $"{personaje.actor.Nombre} ({personaje.Nombre})";
            creditos.Add(lineaCredito);
         }
         return creditos;
      }

      public decimal SumarSueldos()
      {
         decimal sumaSueldos = 0;
         foreach (var actor in personajes)
            sumaSueldos += actor.Sueldo;
         return sumaSueldos;
      }

      public override string ToString()
      {
         return $"{Nombre} ({Anio})";
      }
   }
}
