using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Datos;
using TP1_ElControlDeCalidad.Modelo;
using TP1_ElControlDeCalidad.Presentadores;

namespace TP1_ElControlDeCalidad.Gestores
{
    class GestorIniciarOP
    {
        private PresentadorIniciarOP _presentador;

        public GestorIniciarOP(PresentadorIniciarOP presentadorIniciarOP, int codSup)
        {
            this._presentador = presentadorIniciarOP;
            this.Supervisor = RepositorioEmpleados.Instancia.BuscarCodigo(codSup);
        }
        public Empleado Supervisor { get; set; }

        internal bool IniciarOP(int numero, int linea, int modelo, int color)
        {
            if (RepositorioOP.Instancia.VerificarLineaLibre(linea)) // REPRESENTAR EN EL MODELO??? creeemos que ya no hace falta
            {
                if (RepositorioOP.Instancia.GuardarSeguro(new OP(
                numero,
                Supervisor,
                RepositorioModelos.Instancia.BuscarCodigo(modelo),
                RepositorioColores.Instancia.BuscarCodigo(color),
                RepositorioLineasDeTrabajo.Instancia.BuscarCodigo(linea)
                )))
                {
                    return true; //MessageBox.Show("OP creada", "Aviso");
                }
                else return false; //MessageBox.Show("Linea ocupada", "Aviso");
            }
            else
            {
                return false; //MessageBox.Show("Linea ocupada", "Aviso");
            }
        }

        internal object ListarModelos()
        {
            return RepositorioModelos.Instancia._modelos;
        }

        internal object ListarColores()
        {
            return RepositorioColores.Instancia._colores;
        }

        internal object ListarLineasLibres()
        {
            return RepositorioOP.Instancia.ListarLineasLibres();
        }
    }
}
