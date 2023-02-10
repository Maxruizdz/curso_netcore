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
        public List<Asignatura> asignaturas { get; set; }
        public List<Alumno> alumnos { get; set; }
        //public List<Evaluacion> Evaluaciones { get; set; }
        public Curso() {

            UniqueID = Guid.NewGuid().ToString();
            this.asignaturas = new List<Asignatura>();
            this.alumnos = new List<Alumno>();
           // this.Evaluaciones = new List<Evaluacion>();
        
        
        }


        public override string ToString()
        {
            return $"Curso: {nombre}  Tipo de Jordana{tipos_Jornada}";
        }




    }
}
