using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_ElControlDeCalidad.Gestores;
using TP1_ElControlDeCalidad.Vistas;

namespace TP1_ElControlDeCalidad.Presentadores
{
    class PresentadorIniciarOP
    {
        private VistaIniciarOP _vista;
        private GestorIniciarOP _gestor;
        private BindingSource _bindingEmpleado;
        private BindingSource _bindingModelo;
        private BindingSource _bindingColor;
        private BindingSource _bindingLinea;

        /*public PresentadorIniciarOP(VistaIniciarOP vista, Empleado supervisor)
        {
            _supervisor = supervisor;
            _vista = vista;
        }*/

        public PresentadorIniciarOP(VistaIniciarOP vista, int codSup, BindingSource empleadoBindingSource, BindingSource modeloBindingSource, BindingSource colorBindingSource, BindingSource lineaTrabajoBindingSource) //: this(vista, supervisor)
        {
            this._gestor = new GestorIniciarOP(this, codSup);
            this._vista = vista;
            this._bindingEmpleado = empleadoBindingSource;
            this._bindingModelo = modeloBindingSource;
            this._bindingColor = colorBindingSource;
            this._bindingLinea = lineaTrabajoBindingSource;
        }

        internal void IniciarOP(int numero, int linea, int modelo, int color)
        {
            //controlar que la linea este libre
            if (_gestor.IniciarOP(numero, linea, modelo, color)) MessageBox.Show("OP creada", "Aviso");
            else MessageBox.Show("Linea ocupada", "Aviso");
            Actualizar();
        }

        public void Actualizar()
        {
            _bindingEmpleado.DataSource = _gestor.Supervisor;
            _bindingModelo.DataSource = _gestor.ListarModelos(); //RepositorioModelos.Instancia._modelos;
            _bindingColor.DataSource = _gestor.ListarColores(); // RepositorioColores.Instancia._colores;
            _bindingLinea.DataSource = _gestor.ListarLineasLibres(); //RepositorioOP.Instancia.ListarLineasLibres();    // (creo que ya ta) ojo falta controlar que las lineas no esten ocupadas
        }
    }
}
