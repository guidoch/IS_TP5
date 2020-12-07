using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Datos;

namespace TP1_ElControlDeCalidad.Modelo
{
    public class Sesion
    {
        public Sesion(int cod, Usuario usuario)
        {
            this.Codigo = cod;
            this.User = usuario;
            this.Inicio = RepositorioHora.Instancia.HoraActual();
        }

        public int Codigo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Usuario User { get; set; }

        internal void Finalizar()
        {
            this.Fin = RepositorioHora.Instancia.HoraActual();
        }
    }
}
