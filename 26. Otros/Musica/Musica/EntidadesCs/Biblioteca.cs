using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Biblioteca : ITemporizable
   {
      private List<Contenido> favoritos;

      public int Duracion { get; private set; }

      public Biblioteca()
      {
         favoritos = new List<Contenido>();
      }

      public void AgregarFavorito(Contenido favorito)
      {
         if (favorito == null)
            throw new ArgumentException(" el contenido no puede estar vacio.");
         if (favoritos.Contains(favorito))
            throw new ArgumentException($" {favorito} ya ha sido agregado a la lista de favoritos.");
         favoritos.Add(favorito);
      }

      public List<Contenido> ObtenerFavoritos()
      {
         return favoritos;
      }

      public void RemoveFavorito(Contenido favorito)
      {
         if (favorito == null)
            throw new ArgumentException(" el album no puede estar vacio.");
         if (!favoritos.Contains(favorito))
            throw new ArgumentException($" {favorito} no ha sido agregado a la lista de favoritos.");
         favoritos.Remove(favorito);
      }

      //public void CalcularDuracion()
      //{
      //   int duracionBiblioteca = 0;
      //   foreach (var contenido in favoritos)
      //      duracionBiblioteca += contenido;
      //   Duracion = duracionBiblioteca;
      //}
   }
}
