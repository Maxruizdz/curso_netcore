using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{
    public class Curso:Object_Escuela
    {
    
        public Tipos_Jornada tipos_Jornada { get; set; }
        public List<Asignatura> asignaturas { get; set; } = new List<Asignatura>();
        public List<Alumno> alumnos { get; set; } = new List<Alumno>();
        //public List<Evaluacion> Evaluaciones { get; set; }
    


    



    }
}
