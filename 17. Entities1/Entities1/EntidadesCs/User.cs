using System;

namespace EntidadesCs
{
   public class User
   {
      private string name;
      private string dni;

      public User(string name, string dni)
      {
         Name = name;
         Dni = dni;
      }

      public string Name
      {
         get
         {
            return name;
         }
         set
         {
            if (value.Length > 0 && value.Length <= 50)
               name = value;
         }
      }

      public string Dni
      {
         get
         {
            return dni;
         }
         set
         {
            if (value.Length > 6 && value.Length <= 8)
               dni = value;
         }
      }

      public override string ToString()
      {
         return string.Format(" nombre: {0}\n dni: {1}",
            name, dni);
      }
   }
}
