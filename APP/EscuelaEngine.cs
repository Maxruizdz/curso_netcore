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
        
        
        
        }
        public void Inicializar()
        {
            escuela= new Escuela("Platzi Academay", 2012, Tipo_Escuela.Primaria,
            cuidad: "Bogotá", pais: "Colombia"
            );
            escuela.cursos_escuelas= new List<Curso>(){
                        new Curso(){ nombre = "101", tipos_Jornada= Tipos_Jornada.Mañana },
                        new Curso() {nombre = "201", tipos_Jornada = Tipos_Jornada.Mañana},
                        new Curso{nombre = "301", tipos_Jornada = Tipos_Jornada.Mañana},
                        new Curso(){ nombre = "401", tipos_Jornada = Tipos_Jornada.tarde },
                        new Curso() {nombre = "501", tipos_Jornada = Tipos_Jornada.tarde},
            };
        }

        }

    }
