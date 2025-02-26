using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class ContenidoService
   {
      public List<Contenido> contenidos = new List<Contenido>();

      // BuscarPorNombre

      public void AgregarContenido(Contenido contenido)
      {
         if (contenido == null)
            throw new ArgumentException(" el contenido no puede estar vacio.");
         if (contenidos.Contains(contenido))
            throw new ArgumentException($" {contenido} ya ha sido agregado a la lista de favoritos.");
         contenidos.Add(contenido);
      }

      public List<Contenido> ObtenerContenidos()
      {
         return contenidos;
      }

      public void RemoveContenido(Contenido contenido)
      {
         if (contenido == null)
            throw new ArgumentException(" el contenido no puede estar vacio.");
         if (!contenidos.Contains(contenido))
            throw new ArgumentException($" {contenido} no ha sido agregado a la lista de favoritos.");
         contenidos.Remove(contenido);
      }

      public Contenido BuscarPorNombre(string nombre)
      {
         foreach (var cont in contenidos)
         {
            if (cont.Nombre == nombre)
               return cont;
            else
               throw new ArgumentException(" no se encontro contenido con ese nombre.");
         }
         return null;
      }
   }
}
