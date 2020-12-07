﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ElControlDeCalidad.Modelo
{
    public class Inspeccion
    {
        public int Codigo { get; set; }
        public DateTime FechaYHora { get; set; }
        public List<Defecto> ListaDefectos { get; set; }
    }
}
