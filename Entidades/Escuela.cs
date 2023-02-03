using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{
 public  class Escuela
    {
        public string nombre
        {
            get; set;
            
        }
        public int fecha_Creacion { get; set; }

        public string Cuidad { get; set; }
        public string Pais { get; set; }
        public Tipo_Escuela tipo_escuela { get;set; }
        public Escuela(string nombre, int fechac_creacion, string cuidad, string pais)
        {

            this.nombre = nombre;
            this.fecha_Creacion = fechac_creacion;
            this.Cuidad = cuidad;
            this.Pais = pais;



        }
        public Escuela(string nombre, int año, Tipo_Escuela tipo, string pais = "", string cuidad = "") {



            this.nombre = nombre;
            this.fecha_Creacion = año;
            this.Cuidad = cuidad;
            this.Pais = pais;
            tipo_escuela = tipo;





        }



        public override string ToString() {




            return $"Nombre de la Institucion: \"{nombre}\" \n  Tipo Institucion: {tipo_escuela}\n   Cuidad de la Institucion: {Cuidad}\n  Pais de la Institucion:{Pais} ";
                
               }
    }
}
