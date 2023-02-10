using curso_netCOREE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.APP
{
    public class EscuelaEngine

    {
       public Escuela escuela { get; set; }

        public EscuelaEngine() {
            this.escuela = new Escuela("Platzi Academay", 2012, Tipo_Escuela.Primaria,
               cuidad: "Bogotá", pais: "Colombia"
               );


        }
        public void Inicializar()
        {
            
            CargarCursos();
         CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            Random rdm = new Random();

            int[] numeroexamen = new int[] { 1, 2, 3, 4, 5 };

            foreach (var curso in escuela.cursos_escuelas) {

                var evaluaciones = from alumno in curso.alumnos
                                   from asigna in curso.asignaturas
                                   from nume_Exa in numeroexamen
                                   select new Evaluacion (){ nombre = $"examen n {nume_Exa}", alumno = alumno, Asignatura = asigna, nota =(float)(5 * rdm.NextDouble()) };

                foreach (var alumnos in curso.alumnos) {


                    alumnos.evaluaciones = evaluaciones.Where(p => p.UniqueID == alumnos.UniqueID).ToList();

                  
                
                }
              
            }

        }

        private void CargarAsignaturas()
        {
            foreach (Curso curso in escuela.cursos_escuelas) {


                List<Asignatura> listaAsignatura =new List<Asignatura>() { new Asignatura{Nombre="Matematicas"}, new Asignatura { Nombre = "Educacion Fisica" }, new Asignatura { Nombre = "Catellano" }, new Asignatura { Nombre = "Ciencias Naturales" } };
               
                curso.asignaturas=listaAsignatura; 
            
            
            }
        }

        public IEnumerable<Alumno> GenerarAlumnosAlzar(int cantidad)
        {
            string[] primer_nombre = { "Alba", "Felipe", "Eusebio", "Donald", "Alvaro", "Nicolas"};
            string[] apellido= { "Ruiz","Sarmiento","Uribe", "Maduro","Trump", "Toledo","Herrera" };
           string[] segundo_nombre = { "Lionel", "Cesar", "Murty", "Silvina", "Nimedes", "Teodoro" };


            var lista_Alumno = from n1 in primer_nombre
                               from n2 in segundo_nombre
                               from ape in apellido
                               select new Alumno { nombre = $"{n1}  {n2} {ape}" };


            return lista_Alumno.OrderBy((al)=> al.UniqueID).Take(cantidad).ToList();



        }

        public void CargarCursos() {

            this.escuela.cursos_escuelas = new List<Curso>(){
                        new Curso(){ nombre = "101", tipos_Jornada= Tipos_Jornada.Mañana },
                        new Curso() {nombre = "201", tipos_Jornada = Tipos_Jornada.Mañana},
                        new Curso{nombre = "301", tipos_Jornada = Tipos_Jornada.Mañana},
                        new Curso(){ nombre = "401", tipos_Jornada = Tipos_Jornada.tarde },
                        new Curso() {nombre = "501", tipos_Jornada = Tipos_Jornada.tarde},


                        
            };

            Random rnd = new Random();
      
            foreach (var curso in escuela.cursos_escuelas) {

                int cantRandom = rnd.Next(5, 20);
                curso.alumnos = GenerarAlumnosAlzar(cantRandom).ToList();
            
            
            
            
            }



        }
        public void ver_Evaluaciones_Alumnos() { 
        
        foreach(var cursos in escuela.cursos_escuelas)
            {
                foreach (var alumnos in cursos.alumnos) {


                    foreach (var evealuaciones in alumnos.evaluaciones) {

                        Console.WriteLine($"Nombre Alumno:{evealuaciones.alumno}  Materia{evealuaciones.Asignatura}   Nota:{evealuaciones.nota}");
                    
                    
                    }
                
                
                }


            }
        
        
        
        }
        public void prueba() {
            foreach (var escuela in escuela.cursos_escuelas) {
                es
            
            
            }
        
        
        }



        }

    }
