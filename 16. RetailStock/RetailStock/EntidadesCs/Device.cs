using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Device
   {
      private string sku;
      private DateTime entryDate;
      private DateTime saleDate;

      // revisar constructor con parametro daytime
      //public Device(string sku, DateTime entryDate, DateTime saleDate)
      //{
      //   Sku = sku;
      //   EntryDate = entryDate;
      //   SaleDate = saleDate;
      //}

      public string Sku
      {
         get
         {
            return sku;
         }
         set
         {
            if (value.Length <= 20)
               sku = value;
         }
      }

      public DateTime EntryDate
      {
         get
         {
            return entryDate;
         }
         set
         {
            if (value > DateTime.MinValue)
               entryDate = value;

         }
      }

      public DateTime SaleDate
      {
         get
         {
            return saleDate;
         }
         set
         {
            if (value >= entryDate)
               saleDate = value;
         }
      }

      public override string ToString()
      {
         return string.Format(" SKU: {0} \n fecha de entrada: {1}\n fecha de venta: {2}", sku, entryDate, saleDate);
      }
   }
}
