using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Presentadores;
using TP1_ElControlDeCalidad.Datos;
using TP1_ElControlDeCalidad.Modelo;

namespace TP1_ElControlDeCalidad.Gestores
{
    class GestorCargarHermanado
    {
        private PresentadorCargarHermanado _presentador;
        public OP OP { get; set; }

        public GestorCargarHermanado(PresentadorCargarHermanado presentador, int numero)
        {
            this._presentador = presentador;
            this.OP = RepositorioOP.Instancia.BuscarCodigo(numero);
        }

        internal bool CargarHermanado(int hermanado)
        {
            //controlar op no finalizada
            if (!OP.Estado.Equals(Estado.FINALIZADA))
            {
                OP.Hermanado += hermanado;
                RepositorioOP.Instancia.Actualizar(OP);//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
