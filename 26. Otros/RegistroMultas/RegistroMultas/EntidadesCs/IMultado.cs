﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public interface IMultado
   {
      List<Multa> GetMultas();
      decimal GetTotalMultas();
   }
}
