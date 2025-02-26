using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Cancion : Contenido, ITemporizable
   {
      public int Duracion { get; }
      public Interprete artista;
      public Album album;

      public Cancion (string nombre, Interprete artista, Album album, int duracion) : base(nombre)
      {
         Nombre = nombre;
         Artista = artista;
         Album = album;
         if (duracion <= 10)
            throw new ArgumentException(" la duracion debe ser mayor a 10.");
         Duracion = duracion;
      }

      public Album Album
      {
         get => album;
         set => album = value ?? throw new ArgumentException(" el album no puede estar vacio."); 
      }

      public Interprete Artista
      {
         get => artista;
         set => artista = value ?? throw new ArgumentException(" el artista no puede estar vacio.");
      }

      public override string ToString()
      {
         return $" cancion: {Nombre} [{Duracion} minutos]";
      }
   }
}
