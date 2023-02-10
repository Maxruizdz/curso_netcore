using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{
    public  class Asignatura:Object_Escuela
    {



             public override string ToString() { return $"Nombre de la Asignatura {base.Nombre}"; }
    }
}
