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
    public class PresentadorListaOpSupLinea
    {
        private VistaListaOP _vista;
        public GestorListaOPSupLinea _gestor;
        private BindingSource _bindingEmpleado;
        private BindingSource _bindingOPs;

        public PresentadorListaOpSupLinea(VistaListaOP vista, int codSup, BindingSource empleadoBindingSource, BindingSource oPBindingSource)
        {
            this._vista = vista;
            this._gestor = new GestorListaOPSupLinea(this, codSup);
            //this._supervisor = supervisor;
            this._bindingEmpleado = empleadoBindingSource;
            this._bindingOPs = oPBindingSource;
        }
        public void Actualizar() 
        {
            _bindingEmpleado.DataSource = _gestor.Supervisor;
            _bindingOPs.DataSource = _gestor.ListarOPs(); //RepositorioOP.Instancia.BuscarSupervisorLinea(_supervisor)
            ///_bindingOPs.DataSource = RepositorioOP.Instancia._ops; antes traia todas las ops
        }

        internal void IniciarOP()
        {
            //controlar que no haya ops sin finalizar para el sup
            if (_gestor.ControlarTodasFinalizadas())//(RepositorioOP.Instancia.TodasFinalizadas(_supervisor))
                new VistaIniciarOP(_gestor.Supervisor.Codigo).ShowDialog();
            else
                MessageBox.Show("Existen OP sin finalizar", "Aviso");
            Actualizar();
        }

        internal void ReanudarOP()
        {
            if (_gestor.ReanudarOP((_bindingOPs.Current as Modelo.OP).Numero)) MessageBox.Show("OP reanudada", "Aviso"); 
            else MessageBox.Show("OP no se puede reanudar", "Aviso");
            Actualizar();
        }

        internal void VisualizarOP() //no se si vamos a implementar esto aqui
        {
            var numOP = (_bindingOPs.Current as Modelo.OP).Numero;
            new VistaVisualizarInformacion(numOP).Show();
        }

        internal void FinalizarOP()
        {
            if (_gestor.FinalizarOP((_bindingOPs.Current as Modelo.OP).Numero)) MessageBox.Show("OP finalizada", "Aviso");
            else MessageBox.Show("OP no se puede finalizar", "Aviso");
            Actualizar();
        }

        internal void PausarOP()
        {
            if (_gestor.PausarOP((_bindingOPs.Current as Modelo.OP).Numero)) MessageBox.Show("OP pausada", "Aviso");
            else MessageBox.Show("OP no se puede pausar", "Aviso");
            Actualizar();
        }
    }
}
