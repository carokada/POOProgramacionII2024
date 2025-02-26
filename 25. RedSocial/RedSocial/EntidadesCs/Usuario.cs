using System;
using System.Collections.Generic;


namespace EntidadesCs
{
   public class Usuario
   {
      private List<Publicacion> publicaciones;
      private List<Usuario> seguidores;
      private List<Usuario> seguidos;
      private List<Publicacion> gustados;

      public string Nombre { get; set; }

      public DateTime Nacimiento { get; set; }

      public string Ubicacion { get; set; }

      public Usuario (string nombre, DateTime nacimiento)
      {
         publicaciones = new List<Publicacion>();
         seguidores = new List<Usuario>();
         seguidos = new List<Usuario>();
         gustados = new List<Publicacion>();

         Nombre = nombre;
         Nacimiento = nacimiento;
      }
      public Usuario (string nombre, DateTime nacimiento, string ubicacion) : this(nombre, nacimiento)
      {
         Ubicacion = ubicacion;
      }

      internal void Publicar(Publicacion publicacion)
      {
         if (publicacion == null)
            throw new ArgumentException(" la publicacion no puede ser nula.");
         publicaciones.Add(publicacion);
      }

      public List<Publicacion> GetPublicaciones()
      {
         return publicaciones;
      }

      public void BorrarPublicacion(Publicacion publicacion)
      {
         if (!publicaciones.Contains(publicacion))
            throw new ArgumentException(" la publicacion no existe.");
         publicaciones.Remove(publicacion);
      }

      public void Seguir (Usuario usuario)
      {
         if (usuario == null)
            throw new ArgumentException(" el usuario a seguir no puede ser nulo.");
         if (usuario == this) // this.Equals determina si el obj es igual al obj actual
            throw new ArgumentException(" el usuario no puede seguirse a si mismo.");
         if (seguidos.Contains(usuario))
            throw new ArgumentException(" el usuario ya esta en la lista de seguidos.");
         seguidos.Add(usuario); // agrega el usuario a la lista de seguidos
         usuario.AddSeguidor(this); // invoca al metodo add seguidor para agregar a la lista del usuario que fue seguido el usuario que lo siguie
      }

      public List<Usuario> GetSeguidos()
      {
         return seguidos;
      }

      // no especificado en el UML pero necesario para el buen funcionamiento
      public void StopSeguir(Usuario usuario)
      {
         if (usuario == null)
            throw new ArgumentException(" el usuario no puede ser nulo.");
         if (!seguidos.Contains(usuario))
            throw new ArgumentException($" el usuario {usuario} no esta en la lista de seguidos.");
         seguidos.Remove(usuario);
         usuario.StopSeguidor(this);
      }

      private void AddSeguidor(Usuario usuario)
      {
         seguidores.Add(usuario);
      }

      public List<Usuario> GetSeguidores()
      {
         return seguidores;
      }

      private void StopSeguidor(Usuario usuario)
      {
         seguidores.Remove(usuario);
      }

      public bool MeGusta(Publicacion publicacion)
      {
         if (publicacion == null)
            throw new ArgumentException(" la publicacion no puede ser nula.");

         if (gustados.Contains(publicacion))
         {
            gustados.Remove(publicacion);
            publicacion.StopGusto(this);
            return false;
         }
         else
         {
            gustados.Add(publicacion);
            publicacion.Gusto(this);
            return true;
         }
      }

      public List<Publicacion> GetGustados()
      {
         return gustados;
      }

      public override string ToString()
      {
         return Nombre + (String.IsNullOrEmpty(Ubicacion) ? "" : " desde " + Ubicacion);
      }
   }
}
