﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{
    public class Evaluaciones
    {
        public string UniqueID { get; set; }
        public string nombre { get; set; }
        public Alumno alumno { get; set; }

        public Asignatura Asignatura { get; set; }

        public float nota { get; set; }

    }
}