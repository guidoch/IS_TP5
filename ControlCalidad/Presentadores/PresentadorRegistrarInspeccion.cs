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
    class PresentadorRegistrarInspeccion
    {
        private VistaRegistrarInspeccion _vista;
        private GestorRegistrarInspeccion _gestor;
        private BindingSource _bindingEmpleado;
        private BindingSource _bindingOP;
        private BindingSource _bindingDefectos;
        private BindingSource _bindingTipoDefecto;
        //private Inspeccion _inspeccion;

        public PresentadorRegistrarInspeccion(VistaRegistrarInspeccion vista, int numOP, int codSup, BindingSource empleadoBindingSource, BindingSource oPBindingSource, BindingSource defectoBindingSource, BindingSource tipoDefectoBindingSource)
        {
            this._vista = vista;
            this._gestor = new GestorRegistrarInspeccion(this, numOP, codSup);
            this._bindingEmpleado = empleadoBindingSource;
            this._bindingOP = oPBindingSource;
            this._bindingDefectos = defectoBindingSource;
            this._bindingTipoDefecto = tipoDefectoBindingSource;
            //this._inspeccion = new Inspeccion() { ListaDefectos = new List<Defecto>() }; //pasar al gestor
        }

        internal void Actualizar()
        {
            _bindingEmpleado.DataSource = _gestor.Supervisor;
            _bindingOP.DataSource = _gestor.OP;
            _bindingTipoDefecto.DataSource = _gestor.ListarTiposDefectos();//RepositorioTiposDefecto.Instancia._tiposdefecto;
            _bindingDefectos.DataSource = null;
            _bindingDefectos.DataSource = _gestor.Inspeccion.ListaDefectos;
        }

        internal void AgregarDefecto(Modelo.Pie pie)
        {
            _gestor.AgregarDefecto(pie, _bindingTipoDefecto.Current as Modelo.TipoDefecto);//_inspeccion.ListaDefectos.Add(new Defecto() { Codigo = (_inspeccion.ListaDefectos.Count()), Pie = pie, TipoDefecto = _bindingTipoDefecto.Current as TipoDefecto });
            Actualizar();
        }

        internal bool Desasociar()
        {
            if (_gestor.Desasociar())    //revisar op pausada, desasociar de periodo
            {
                MessageBox.Show("Desasociado de op", "Aviso");
                //_vista.Close();
                return true;
            }
            else
            {
                MessageBox.Show("No se puede desasociar de una op activa", "Aviso");
                return false;
            }        
        }

        internal void RegistrarInspeccion()
        {
            switch (_gestor.RegistrarInspeccion())
            {
                case 0:
                    MessageBox.Show("Inspeccion registrada.\nResultado: PRIMERA.", "Aviso");
                    break;
                case 1:
                    MessageBox.Show("Inspeccion registrada.\nResultado: OBSERVADO.", "Aviso");
                    break;
                case 2:
                    MessageBox.Show("Inspeccion registrada.\nResultado: REPROCESO.", "Aviso");
                    break;
                case 99:
                    MessageBox.Show("Inspeccion NO registrada.", "Aviso");
                    break;
                default:
                    MessageBox.Show("Como llegue aqui?", "ERROR");
                    break;
            } 
            Actualizar();
        }
    }
}
