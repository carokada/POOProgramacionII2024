using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Registro
   {
      private List<Multa> multas = new List<Multa>();
      private List<Propietario> propietariosMultados = new List<Propietario>();

      public void AddMulta(Multa multa)
      {
         if (multas.Contains(multa))
            throw new ArgumentException($" la multa {multa} ya esta registrada.");
         multas.Add(multa);
      }

      //public List<Multa> GetMultasByMultado()
      //{
      //   return multas;
      //}

      //public List<Propietario> GetAllPropietariosMultados()
      //{
      //   return propietariosMultados;
      //}

      //public Persona GetPersonaByDni(uint dni)
      //{
      //   return Persona;
      //}
   }
}
