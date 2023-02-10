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


        public List<Evaluacion> evaluaciones { get; set; }

        public Alumno() => (UniqueID, evaluaciones)= (Guid.NewGuid().ToString(), this.evaluaciones= new List<Evaluacion>());
        public override string ToString()
        {




            return $"Nombre del Alumno: \"{nombre}\" \n";

        }

        public void  mostrarEvaluaciones() {


            foreach (var examenes in evaluaciones) {

                Console.WriteLine(examenes);
            
            
            }
        
        }
    }
}
