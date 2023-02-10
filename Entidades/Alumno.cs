using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{
    public class Alumno: Object_Escuela
    {


        public List<Evaluacion> evaluaciones { get; set; } = new List<Evaluacion>();


        public override string ToString()
        {




            return $"Nombre del Alumno: \"{base.Nombre}\" \n";


        }
        public void  mostrarEvaluaciones() {


            foreach (var examenes in evaluaciones) {

                Console.WriteLine(examenes);
            
            
            }
        
        }
    }
}
