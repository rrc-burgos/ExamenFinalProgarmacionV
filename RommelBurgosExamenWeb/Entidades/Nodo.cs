using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RommelBurgosExamenWeb.Entidades
{
    public class Nodo
    {
       public double Valor { get; set; }
        public List<Nodo> NodosHijos { get; set; } = new List<Nodo>(); 
     
    }
}
