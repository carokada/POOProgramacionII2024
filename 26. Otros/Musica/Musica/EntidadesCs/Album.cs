using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Album : Contenido, ITemporizable
   {
      private List<Cancion> canciones;

      public int Duracion { get; private set; }
      public DateTime fechaLanzamiento;

      public Album(string nombre, DateTime fecha) : base(nombre)
      {
         canciones = new List<Cancion>();

         FechaLanzamiento = fecha;
      }

      public DateTime FechaLanzamiento
      {
         get => fechaLanzamiento;
         set => fechaLanzamiento = value <= DateTime.Now ? value : throw new ArgumentException(" la fecha no es valida.");
      }

      public void AgregarCancion(Cancion cancion)
      {
         if (cancion == null)
            throw new ArgumentException(" la cancion no puede estar vacia.");
         if (canciones.Contains(cancion))
            throw new ArgumentException($" la cancion {cancion} ya ha sido agregada al album.");
         canciones.Add(cancion);
         Duracion += cancion.Duracion;
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
            throw new ArgumentException($" la cancion {cancion} no ha sido agregada al album.");
         canciones.Remove(cancion);
         Duracion -= cancion.Duracion;
      }

      //public void CalcularDuracion()
      //{
      //   int duracionAlbum = 0;
      //   foreach (var cancion in canciones)
      //      duracionAlbum += cancion.Duracion;
      //   Duracion = duracionAlbum;
      //} 

      public override string ToString()
      {
         return $" album: {Nombre} [{Duracion} minutos]";
      }
   }
}
