using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ElControlDeCalidad.Modelo
{
    public class Modelo
    {
        public int SKU { get; set; }
        public string Denominacion { get; set; }
        public int Objetivo { get; set; }

        public override string ToString()
        {
            return Denominacion.ToString();
        }
    }
}
