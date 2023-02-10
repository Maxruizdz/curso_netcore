using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{

    public class Evaluacion:Object_Escuela


    {

        public Alumno alumno { get; set; }

        public Asignatura Asignatura { get; set; }

        public float nota { get; set; }


        public override string ToString()
        {
            return $"Alumno{alumno}   \nAsignatura:{Asignatura}\n  Nota:{nota}  ";
        }

    }
}
