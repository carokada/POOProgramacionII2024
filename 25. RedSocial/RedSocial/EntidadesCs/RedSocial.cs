using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class RedSocial
   {
      private static List<Usuario> usuarios = new List<Usuario>();

      public static void AddUsuario(Usuario usuario)
      {
         if (usuario == null)
            throw new ArgumentException(" debe especificar un usuario.");
         if (usuarios.Contains(usuario))
            throw new ArgumentException($" el usuario {usuario.Nombre} ya ha sido agregado a la lista.");
         usuarios.Add(usuario);
      }

      public static void RemoveUsuario(Usuario usuario)
      {
         if (usuario == null)
            throw new ArgumentException(" debe especificar un usuario.");
         if (!usuarios.Contains(usuario))
            throw new ArgumentException($" el usuario {usuario.Nombre} no esta en la lista.");
         usuarios.Remove(usuario);
      }

      public static List<Usuario> GetUsuarios()
      {
         return usuarios;
      }

   }
}
