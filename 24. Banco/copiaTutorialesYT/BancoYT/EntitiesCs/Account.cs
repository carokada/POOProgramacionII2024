using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
   public class Account
   {
      // readonly: solo se modifica mediante metodos internos
      private decimal balance = 0;

      public Account()
      {
         Enabled = true;
      }

      // constructor que hereda SavingAccount
      public Account(int number, decimal valorBalance) : this()
      {
         Number = number;
         balance = valorBalance;
      }

      // propiedades autoimplementadas (ya que la mayoria de las propiedades tienen un campo homonimo y del mismo tipo y solo almacenan informacion dentro de la clase suelen no necesitaarse modificaciones sobre el get y el set. su modificador de acceso de campo siempre es private
      public int Number { get; set; }
      public bool Enabled { get; set; }

      //propiedad de solo lectura abreviada
      public decimal Balance { get => balance; }

      // asociacion
      // asociacion: existen varios tipos. se determinan segun la vinculacion que exista entre clases. puede tener cardinalidad (cuantos atributos forman parte de la asociacion). 2 niveles: semantica (disenio) [asociacion, agregacion y composicon] y estructural (implementacion) [segun cardinalidad (simple o multiple) y segun navegabilidad (unidireccional o bidireccional)]
      // asociacion simple: una instancia de una clase esta asociada unicamente a otra instancia de otra clase. la clase de origen tendra una propiedad de la clase/entidad destino (no especificado en UML, se lee a partir de la asociacion)
      // propiedad que referencia a la clase Customer 

      public Customer Customer { get; set; } // asociacion simple

      // metodos
      // metodo interno (privado)
      private void addBalance(decimal value)
      {
         balance += value;
      }

      // deposit y withdraw trabajan sobre addbalance para unificar la operacion en un solo metodo 
      public void Deposit(decimal value)
      {
         addBalance(value);
      }

      // declarado como virtual para que no tire error al sobreescribirlo en SavingAccount (chat)
      public virtual void Withdraw(decimal value)
      {
         addBalance(-value);
      }
   }
}
