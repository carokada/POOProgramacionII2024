using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesCs
{
   public class Bank
   {
      // asociacion multiple: una o mas instancias de una clase estan asociadas a otra clase. en la clase origen se implementa un campo como una lista del tipo de datos de la clase destino. la clase origen contiene una lista (coleccion) que contiene todas las instancias de la clase destino. no se implementa propiedad (set, get) sino metodos metodos que siguen una regla estandarizada que permiten como minimo agregar y quitar elementos a la lista, obtener la lista completa y obtener instancias mediante busqueda por sus atributos
      private List<Customer> customers;

      public Bank()
      {
         customers = new List<Customer>(); //inicializador para la lista de clientes
      }

      public void AddCustomer(Customer customer) // agregar un cliente a la lista
      {
         customers.Add(customer);
      }

      public List<Customer> GetCustomers() // imprimir los clientes en la lista
      {
         return customers;
      }
   }
}
