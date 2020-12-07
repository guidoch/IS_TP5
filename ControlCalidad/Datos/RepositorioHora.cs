using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_ElControlDeCalidad.Datos
{
    class RepositorioHora
    {
        public static RepositorioHora Instancia = new RepositorioHora();

        public DateTime HoraActual()
        {
            return DateTime.Now;
        }
    }
}
