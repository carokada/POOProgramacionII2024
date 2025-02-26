using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Publicacion
   {
      // por que private usuario ? parte de asociacion ? 
      private Usuario usuario;

      private List<Usuario> gustaron;

      public DateTime FechaHora { get; set; }

      public string Texto { get; set; }

      public Publicacion(DateTime fechaHora, string texto, Usuario usuario)
      {
         gustaron = new List<Usuario>();

         FechaHora = fechaHora;
         Texto = texto;
         Usuario = usuario;
      }

      // privado para que solo se pueda cambiar desde dentro de la clase.
      public Usuario Usuario
      {
         get
         {
            return usuario;
         }
         private set
         {
            if (value == null)
               throw new ArgumentException(" el usuario no puede ser nulo.");
            value.Publicar(this); // publicar esta publicacion por el metodo de la clase Usuario
            usuario = value;
         }
      }

      internal void Gusto(Usuario usuario)
      {
         if (usuario == null)
            throw new ArgumentException(" el usuario no puede ser nulo.");
         if (gustaron.Contains(usuario))
            throw new ArgumentException($" la publicacion ya fue gustada por el usuario {usuario}."); // no hace falta porque megusta es bool ??
         gustaron.Add(usuario);
      }

      internal void StopGusto(Usuario usuario)
      {
         if (usuario == null)
            throw new ArgumentException(" el usuario no puede ser nulo.");
         if (!gustaron.Contains(usuario))
            throw new ArgumentException($" la publicacion no fue gustada por el usuario {usuario}.");
         gustaron.Remove(usuario);
      }

      public List<Usuario> GetGustaron()
      {
         return gustaron;
      }

      public override string ToString()
      {
         return $"[{FechaHora}] {Usuario} -> {Texto}";
      }
   }
}
