﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ElControlDeCalidad.Modelo
{
    public class Turno
    {
        public int Codigo { get; set; }
        public List<int> Dias { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
    }
}
