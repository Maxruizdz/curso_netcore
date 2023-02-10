
﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_netCOREE.Entidades
{

    public abstract class Object_Escuela
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }


        public Object_Escuela() {

            this.UniqueId = Guid.NewGuid().ToString();

        }

    }

