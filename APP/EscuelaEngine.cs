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

        public List<Object_Escuela> GetObjetosEscuela(bool trae_evaluaciones=true, bool traer_alumnos=true,bool traer_asignaturas=true, bool traerCursos = true )
        {
            var listaObj = new List<Object_Escuela>();
            listaObj.Add(this.escuela);
            if (traerCursos)
            {
                listaObj.AddRange(this.escuela.cursos_escuelas);
            }
            foreach (var curso in escuela.cursos_escuelas)
            {
                if (traer_asignaturas)
                {
                    listaObj.AddRange(curso.asignaturas);
                }
                if (traer_alumnos)
                {
                    listaObj.AddRange(curso.alumnos);
                }
                if (trae_evaluaciones == true)
                {
                    foreach (var alumno in curso.alumnos)
                    {
                        listaObj.AddRange(alumno.evaluaciones);
                    }
                }
            }

            return listaObj;
        }
        #region #region Métodos de Carga
        private void CargarEvaluaciones()
        {
            var rnd = new Random();
            foreach (var curso in escuela.cursos_escuelas)
            {
                foreach (var asignatura in curso.asignaturas)
                {
                    foreach (var alumno in curso.alumnos)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluacion
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                nota = MathF.Round(
                                    5 * (float)rnd.NextDouble()
                                    , 2),
                                alumno = alumno
                            };
                            alumno.evaluaciones.Add(ev);
                        }
                    }
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
                               select new Alumno { Nombre = $"{n1}  {n2} {ape}" };


            return lista_Alumno.OrderBy((al)=> al.UniqueId).Take(cantidad).ToList();



        }

        public void CargarCursos() {

            this.escuela.cursos_escuelas = new List<Curso>(){
                        new Curso(){ Nombre = "101", tipos_Jornada= Tipos_Jornada.Mañana },
                        new Curso() {Nombre = "201", tipos_Jornada = Tipos_Jornada.Mañana},
                        new Curso{Nombre = "301", tipos_Jornada = Tipos_Jornada.Mañana},
                        new Curso(){ Nombre = "401", tipos_Jornada = Tipos_Jornada.tarde },
                        new Curso() {Nombre = "501", tipos_Jornada = Tipos_Jornada.tarde},


                        
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
        #endregion metodos de carga Metodos de carga



    }



        }

    
