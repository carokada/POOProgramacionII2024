using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
   public class SavingAccount : Account
   {
      public SavingAccount(int number, decimal balance, decimal monthlyInterestRate) : base (number, balance)
      {
         MonthlyInterestRate = monthlyInterestRate;
      }

      public decimal MonthlyInterestRate { get; set; }

      public void DepositMonthlyInterest()
      {
         Deposit(Balance * (MonthlyInterestRate / 100));
      }

      // hereda de account
      public override void Withdraw(decimal value)
      {
         if (Balance < value)
            throw new ArgumentException(" sin saldo suficiente para extraccion. ");
         base.Withdraw(value); // distinto a los videos porque daba error con balance -= value
      }
   }
}
