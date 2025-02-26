using System;

namespace EntidadesCs
{
   public class Product
   {
      private string name;
      private string serialNumber;

      public Product()
      {
         name = string.Empty;
         serialNumber = string.Empty;
      }

      public Product(string name, string serialNumber)
      {
         Name = name;
         SerialNumber = serialNumber;
      }

      public string Name
      {
         get
         {
            return name;
         }
         set
         {
            if (value.Length <= 50)
               name = value;
         }
      }

      public string SerialNumber
      {
         get
         {
            return serialNumber;
         }
         set
         {
            if (value.Length <= 10)
               serialNumber = value;
         }
      }

      public override string ToString()
      {
         return string.Format("{0} ({1})", name, serialNumber);
      }
   }
}
