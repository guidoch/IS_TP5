using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_ElControlDeCalidad.Vistas;
using TP1_ElControlDeCalidad.Gestores;

namespace TP1_ElControlDeCalidad.Presentadores
{
    class PresentadorVisualizarInformacion
    {
        private VistaVisualizarInformacion _vista;
        private GestorVisualizarInformacion _gestor;
        private BindingSource _bindingOP;

        public PresentadorVisualizarInformacion(VistaVisualizarInformacion vista,int op, BindingSource bindingOP)
        {
            this._vista = vista;
            this._gestor = new GestorVisualizarInformacion(this, op);
            this._bindingOP = bindingOP;
        }

        internal void Actualizar()
        {
            _bindingOP.DataSource = null;
            _bindingOP.DataSource = _gestor.OP;
            _vista.Actualizar(_gestor.ContarPrimeraEnTurno(), _gestor.CalcularObjetivo(), _gestor.TopDefectos());
        }

        internal void Close()
        {
            _gestor.Close();
        }
    }
}
