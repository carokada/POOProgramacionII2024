using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Line
   {
      private string areaCode;
      private string number;

      public Line (string areaCode, string number)
      {
         AreaCode = areaCode;
         Number = number;
      }

      public string AreaCode
      {
         get
         {
            return areaCode;
         }
         set
         {
            if (value.Length > 1 && value.Length <= 4)
               areaCode = value;
         }
      }

      public string Number
      {
         get
         {
            return number;
         }
         set
         {
            if (value.Length > 5 && value.Length <= 8)
               number = value;
         }
      }

      public override string ToString()
      {
         return string.Format("({0}) {1}", 
            areaCode, number);
      }
   }
}
