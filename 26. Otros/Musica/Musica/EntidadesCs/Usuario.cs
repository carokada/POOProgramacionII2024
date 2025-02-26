using System;

namespace EntidadesCs
{
   public class Usuario
   {
      private Biblioteca biblioteca;

      private string nombre;
      private string email;

      public Usuario (string nombre, string email)
      {
         Nombre = nombre;
         Email = email;

         biblioteca = new Biblioteca();
      }

      public string Nombre
      {
         get => nombre;
         set => nombre = value.Length > 3 ? value : throw new ArgumentException(" el nombre no cumple con los requerimientos del campo.");
      }

      public string Email
      {
         get => email;
         set => email = value.Contains("@") ? value : throw new ArgumentException(" el email no cumple con los requerimientos del campo.");
      }

      public Biblioteca Biblioteca
      {
         get => biblioteca;
         set => biblioteca = value ?? throw new ArgumentException(" la biblioteca no puede estar vacia.");
      }

      public override string ToString()
      {
         return $"{Nombre} [{Email}]";
      }
   }
}
