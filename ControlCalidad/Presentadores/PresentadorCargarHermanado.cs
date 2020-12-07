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
    class PresentadorCargarHermanado
    {
        private VistaCargarHermanado _vista;
        private BindingSource bindingOP;
        private GestorCargarHermanado _gestor;

        public PresentadorCargarHermanado(VistaCargarHermanado vista, int numero, BindingSource bindingOP)
        {
            this._vista = vista;
            this._gestor = new GestorCargarHermanado(this, numero);
            this.bindingOP = bindingOP;
        }

        internal void CargarHermanado(int hermanado)
        {
            if (_gestor.CargarHermanado(hermanado))
            {
                MessageBox.Show("Hermanado cargado correctamente.","Aviso");
            }
            else
            {
                MessageBox.Show("No se pudo cargar hermanado, OP finalizada.", "Aviso");
            }
            Actualizar();
            _vista.Close();
        }

        internal void Actualizar()
        {
            bindingOP.DataSource = _gestor.OP as Modelo.OP;
        }
    }
}
