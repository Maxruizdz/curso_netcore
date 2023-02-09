using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{
  public class Alumno
    {
        public string UniqueID { get; private set; }
        public string nombre { get; set; }



        public Alumno() => UniqueID = Guid.NewGuid().ToString();

    }
}
