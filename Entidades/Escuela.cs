using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{
 public  class Escuela:Object_Escuela
    {
        public int fecha_Creacion { get; set; }

        public string Cuidad { get; set; }
        public string Pais { get; set; }
        public Tipo_Escuela tipo_escuela { get;set; }
        public List<Curso> cursos_escuelas { get; set; } = new List<Curso>();
        public Escuela( int fechac_creacion, string cuidad, string pais)
        {

           
            this.fecha_Creacion = fechac_creacion;
            this.Cuidad = cuidad;
            this.Pais = pais;
         


        }
        public Escuela(string nombre, int año) => (Nombre, fecha_Creacion) = (nombre, año);
        public Escuela(string nombre, int año,
                             Tipo_Escuela tipo,
                             string pais = "", string cuidad = "") : base()
        {
            (Nombre, fecha_Creacion) = (nombre, año);
            this.Pais = pais;
            this.Cuidad= cuidad;
        }

        public void imprimir_cursos() {

            Console.WriteLine("===============================");
            Console.WriteLine(  "    Curso de la Escuela       ");
            Console.WriteLine("================================");


            foreach (var curs in cursos_escuelas) {
                Console.WriteLine($"Nombre: {base.Nombre} , id: {base.UniqueId}");
            
            
            
            
            
            
            }
        
        
        
        
        
        }

        public void agregara_Curso(Curso curso) {


            this.cursos_escuelas.Add(curso);
        
      
        
        }
        public void agregar_listasCurso(List<Curso> cursos) {
            this.cursos_escuelas.AddRange(cursos);
        
        
        
        }
        public void  eliminar_curso(string nombre) {

            cursos_escuelas.RemoveAll(delegate ( Curso cur) { return base.Nombre== nombre; });
        
        
        }
        public void eliminar_curso2(string nombre) {

            cursos_escuelas.RemoveAll((Curso curso) => base.Nombre == nombre);
        
        
        
        }


        public override string ToString() {




            return $"Nombre de la Institucion: \"{base.Nombre}\" \n  Tipo Institucion: {tipo_escuela}\n   Cuidad de la Institucion: {Cuidad}\n  Pais de la Institucion:{Pais} ";
                
               }

    }
}
