using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Call
   {
      private DateTime smallDateTime;
      private string targetLine;
      private ushort durationSeconds;

      public Call (DateTime smallDateTime, string targetLine, ushort durationSeconds)
      {
         SmallDateTime = smallDateTime;
         TargetLine = targetLine;
         DurationSeconds = durationSeconds;
      }

      public DateTime SmallDateTime
      {
         get
         {
            return smallDateTime;
         }
         set
         {
            smallDateTime = value;
         }
      }

      public string TargetLine
      {
         get
         {
            return targetLine;
         }
         set
         {
            if (value.Length <= 12)
               targetLine = value;
         }
      }

      public ushort DurationSeconds
      {
         get
         {
            return durationSeconds;
         }
         set
         {
            durationSeconds = value;
         }
      }

      public override string ToString()
      {
         return string.Format(" fecha: {0}\n linea: {1}\n duracion: {2}",
            smallDateTime, targetLine, durationSeconds);
      }
   }
}
