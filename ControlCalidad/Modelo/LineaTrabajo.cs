using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ElControlDeCalidad.Modelo
{
    public class LineaTrabajo
    {
        public int Numero { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion.ToString();
        }
    }
}
