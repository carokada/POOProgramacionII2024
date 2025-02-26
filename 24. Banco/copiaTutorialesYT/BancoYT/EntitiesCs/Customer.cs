using System;

namespace EntitiesCs
{
   public class Customer
   {
      // campos
      private string name;
      private int dni;
      private DateTime birthday;
      // fin campos

      // constructores
      public Customer()
      {
         Nationality = "Argentinx";
      }
      // sobrecarga de constructor
      public Customer(string name, int dni) : this() // invocacion al constructor sin parametros
      {
         Name = name;
         Dni = dni;
      }

      public Customer(string name, int dni, DateTime birthday) : this(name, dni) // invocacion al constructor de 2 parametros (que a su vez invoca al otro constructor
      {
         Birthday = birthday; 
      }
      // propiedades
      public string Name
      {
         get
         {
            return name;
         }
         set
         {
            if (value.Length > 3)
               name = value;
         }
      }

      public int Dni
      {
         get
         {
            return dni;
         }
         set
         {
            if (value > 999999)
               dni = value;
         }
      }

      public DateTime Birthday
      {
         get
         {
            return birthday;
         }
         set
         {
            if (value.AddYears(18) < DateTime.Now)
               birthday = value;
         }
      }

      public string Nationality { get; set; }
      // fin propiedades

      // propiedades de solo lectura
      public UInt16 Age
      {
         get
         {
            UInt16 edad = (UInt16) (DateTime.Now.Year - birthday.Year);
            // si no cumplio anios descontar -1
            //if (DateTime.Now.Month > birthday.Month)
            //if (DateTime.Now.Day < birthday.Day)
            return edad;
         }
      }
   }
}
