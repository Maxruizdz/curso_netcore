using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{
    public class Curso
    {
        public string nombre { get;  set; }
        public string UniqueID { get;private  set; }
        public Tipos_Jornada tipos_Jornada { get; set; }

        public Curso() {

            UniqueID = Guid.NewGuid().ToString();
        
        
        }
    
    
    
    }
}
