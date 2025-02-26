using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Interprete : Contenido, ITemporizable
   {
      private List<Album> albums;
      private List<Cancion> canciones;

      public int Duracion { get; private set; }

      public Interprete(string nombre) : base (nombre)
      {
         albums = new List<Album>();
         canciones = new List<Cancion>();
      }

      public void AgregarAlbum(Album album)
      {
         if (album == null)
            throw new ArgumentException(" el album no puede estar vacio.");
         if (albums.Contains(album))
            throw new ArgumentException($" el album {album} ya ha sido agregado al interprete.");
         albums.Add(album);
      }

      public List<Album> ObtenerAlbums()
      {
         return albums;
      }

      public void RemoveAlbum(Album album)
      {
         if (album == null)
            throw new ArgumentException(" el album no puede estar vacio.");
         if (!albums.Contains(album))
            throw new ArgumentException($" el album {album} no ha sido agregado al interprete.");
         albums.Remove(album);
      }

      public void AgregarCancion(Cancion cancion)
      {
         if (cancion == null)
            throw new ArgumentException(" la cancion no puede estar vacia.");
         if (canciones.Contains(cancion))
            throw new ArgumentException($" la cancion {cancion} ya ha sido agregada al interprete.");
         canciones.Add(cancion);
         if (!albums.Contains(cancion.album))
            albums.Add(cancion.Album);
      }

      public List<Cancion> ObtenerCanciones()
      {
         return canciones;
      }

      public void RemoveCancion(Cancion cancion)
      {
         if (cancion == null)
            throw new ArgumentException(" la cancion no puede estar vacia.");
         if (canciones.Contains(cancion))
            throw new ArgumentException($" la cancion {cancion} no ha sido agregada al interprete.");
         canciones.Remove(cancion);
      }

      public void CalcularDuracion()
      {
         int duracionCanciones = 0;
         foreach (var cancion in canciones)
            duracionCanciones += cancion.Duracion;
         Duracion = duracionCanciones;
      }

      public override string ToString()
      {
         return $" interprete: {Nombre}";
      }
   }
}
