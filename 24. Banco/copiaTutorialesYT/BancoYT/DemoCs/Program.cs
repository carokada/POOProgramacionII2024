using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesCs;

namespace DemoCs
{
   class Program
   {
      static void Main(string[] args)
      {
         string divisor = "----------------------------------------------------------";

         // nuevo objeto cliente
         Customer cliente1 = new Customer();
         // asignacion de valores a cada campo
         cliente1.Name = "Juan Perez";
         cliente1.Dni = 35619826;
         cliente1.Birthday = new DateTime(2000, 5, 8);

         Console.WriteLine(" cliente 1: ");
         ShowCustomer(cliente1);

         //propiedades con comprobacion de campos
         Customer cliente2 = new Customer();
         Console.WriteLine("\n cliente 2: ");
         cliente2.Name = "Alf";
         //Console.WriteLine(" nombre: (invalido)" + cliente2.Name);

         cliente2.Name = "Alf Tanner";
         cliente2.Dni = 234695;
         //Console.WriteLine("\n nombre: " + cliente2.Name);
         //Console.WriteLine(" dni: (invalido)" + cliente2.Dni);

         cliente2.Dni = 2346956;
         cliente2.Birthday = new DateTime(2010, 5, 8);
         //Console.WriteLine("\n nombre: " + cliente2.Name);
         //Console.WriteLine(" dni: " + cliente2.Dni);
         //Console.WriteLine(" fecha de nacimiento: (invalida)" + cliente2.Birthday);

         cliente2.Birthday = new DateTime(2003, 10, 31);
         ShowCustomer(cliente2);

         // propiedades de solo lectura: no puede asignarse un valor
         // cliente2.Age = 24 genera un error

         // constructores
         Customer cliente3 = new Customer("Juana Pacheco", 34265913);
         Console.WriteLine("\n cliente 3: ");
         ShowCustomer(cliente3);

         Customer cliente4 = new Customer("Ramiro Moran", 8169425, new DateTime(1950, 2, 10));
         Console.WriteLine("\n cliente 4: ");
         ShowCustomer(cliente4);

         Console.WriteLine(divisor);

         // propiedades autoimplementadas
         Account cuenta1 = new Account();
         cuenta1.Number = 322345;
         cuenta1.Enabled = true;
         // asociacion simple account -> customer
         cuenta1.Customer = cliente1;

         Console.WriteLine("\n cuenta 1: ");
         ShowAccount(cuenta1);

         // metodos
         cuenta1.Deposit(10000);
         Console.WriteLine(" saldo despues de deposito: " + cuenta1.Balance);
         cuenta1.Withdraw(4000);
         Console.WriteLine(" saldo despues de extraccion: " + cuenta1.Balance);

         // herencia
         SavingAccount cajaAhorro1 = new SavingAccount(322391, 0, 5);
         // asociacion simple account->customer
         cajaAhorro1.Customer = cliente2;

         Console.WriteLine(divisor);

         Console.WriteLine("\n caja de ahorro 1: ");
         ShowAccount(cajaAhorro1);
         cajaAhorro1.Deposit(10000);
         Console.WriteLine(" saldo despues de deposito: " + cajaAhorro1.Balance);
         cajaAhorro1.Withdraw(4000);
         Console.WriteLine(" saldo despues de extraccion: " + cajaAhorro1.Balance);
         cajaAhorro1.DepositMonthlyInterest();
         Console.WriteLine(" saldo despues de DepositMonthlyInterest(): " + cajaAhorro1.Balance);

         Console.WriteLine(divisor);

         // asociacion multiple bank -> customers
         Bank banco = new Bank();
         banco.AddCustomer(cliente1);
         banco.AddCustomer(cliente2);
         banco.AddCustomer(cliente3);
         banco.AddCustomer(cliente4);

         Console.WriteLine("\n lista de clientes del banco: ");
         foreach(Customer cliente in banco.GetCustomers())
         {
            Console.WriteLine(" - " + cliente.Name);
         }

         // asociacion bidireccional: se puede leer en ambos sentidos (asociacion sincronizada: una clase es responsable de la asignacion en ambos lados y la otra colabora con un metodo de asignacion con visibilidad a nivel de proyecto; de un lado un metodo publico responsable de hacerlo, y del otro un metodo a nivel proyecto que colabora con el de afuera). cada clase tiene una referencia hacia la otra. si la referencia es simple, sera un atributo; si la referencia es multiple, sera una lista. puede estar detallado o no en el UML. cuando uno manipula los datos, se manipula desde un lado y el otro se hace automaticamente o encapsulada.

         Console.WriteLine(divisor);

         // herencia + manejo de excepciones
         SavingAccount cajaAhorro2 = new SavingAccount(322425, 0, 7);
         cajaAhorro2.Customer = cliente3;
         Console.WriteLine("\n caja de ahorro 2: ");
         ShowAccount(cajaAhorro2);
         cajaAhorro2.Deposit(100000);
         Console.WriteLine(" saldo despues de deposito: " + cajaAhorro2.Balance);
         cajaAhorro2.DepositMonthlyInterest();
         Console.WriteLine(" saldo despues de DepositMonthlyInterest(): " + cajaAhorro2.Balance);

         Console.WriteLine("\n intercepcion de errores");
         // los mensajes de error se implementan en el set del metodo 
         Console.WriteLine(" extraccion 1: 200000");
         try
         {
            cajaAhorro2.Withdraw(200000);
         }
         catch (ArgumentException excepcion)
         {
            Console.WriteLine("{0}\n !! error: {1}\n {2}", divisor, excepcion.Message, divisor);
         }

         Console.WriteLine(" extraccion 2: 70000");
         try
         {
            cajaAhorro2.Withdraw(70000);
         }
         catch (ArgumentException excepcion)
         {
            Console.WriteLine("\n error: " + excepcion.Message);
         }

         Console.WriteLine(" saldo: " + cajaAhorro2.Balance);
         
         Console.WriteLine(divisor);



         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void ShowCustomer(Customer cliente)
      {
         Console.WriteLine(" nombre: " + cliente.Name);
         Console.WriteLine(" dni: " + cliente.Dni);
         Console.WriteLine(" fecha de nacimiento: " + cliente.Birthday);
         Console.WriteLine(" edad: " + cliente.Age);
         Console.WriteLine(" nacionalidad: " + cliente.Nationality);
      }

      private static void ShowAccount(Account cuenta)
      {
         Console.WriteLine(" cuenta #" + cuenta.Number);
         Console.WriteLine(" cliente: " + cuenta.Customer.Name);
         Console.WriteLine(" estado: " + cuenta.Enabled);
         Console.WriteLine(" saldo: " + cuenta.Balance);
      }

      private static void ShowAccount(SavingAccount cajaAhorro)
      {
         ShowAccount((Account) cajaAhorro); // casting para poder utilizar el metodo ShowAccount (Account)
         Console.WriteLine(" interes mensual: %" + cajaAhorro.MonthlyInterestRate);
      }
   }
}
