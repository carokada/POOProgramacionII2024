using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Branch
   {
      private string name;
      private string city;

      public Branch(string name, string city)
      {
         Name = name;
         City = city;
      }

      public string Name
      {
         get
         {
            return name;
         }
         set
         {
            if (value.Length <= 30)
               name = value;
         }
      }

      public string City
      {
         get
         {
            return city;
         }
         set
         {
            if (value.Length <= 50)
               city = value;
         }
      }

      public override string ToString()
      {
         return string.Format("{0} ({1})", name, city);
      }
   }
}
