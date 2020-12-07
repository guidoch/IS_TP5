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
    class PresentadorListaOPSupCalidad
    {
        private VistaListaOPSupCalidad _vista;
        private GestorListaOPSupCalidad _gestor;
        private BindingSource _bindingEmpleado;
        private BindingSource _bindingOP;

        public PresentadorListaOPSupCalidad(VistaListaOPSupCalidad vista, int codSup, BindingSource bindingEmpleado, BindingSource bindingOP)
        {
            this._vista = vista;
            this._gestor = new GestorListaOPSupCalidad(this, codSup);
            this._bindingEmpleado = bindingEmpleado;
            this._bindingOP = bindingOP;
            //RepositorioOP.Suscribe(Actualizar); //pasar al gestor (hecho)
        }

        internal void Actualizar()
        {
            ///_bindingEmpleado.DataSource = null;
            _bindingEmpleado.DataSource = _gestor.Supervisor;
            ///_bindingOP.AllowNew = true;
            _bindingOP.DataSource = null;
            _bindingOP.DataSource = _gestor.ListaOPs();//RepositorioOP.Instancia._ops;
        }

        internal void Asociar()
        {
            switch (_gestor.Asociar((_bindingOP.Current as Modelo.OP).Numero))
            {
                case 0:
                    MessageBox.Show("Asociado a OP", "Aviso");
                    break;
                case 1:
                    MessageBox.Show("No se puede asociar a OP, supervisor ya asociado a otra op", "Aviso");
                    break;
                case 2:
                    MessageBox.Show("No se puede asociar, op ya asociada a otro supervisor de calidad.", "Aviso");
                    break;
                case 3:
                    MessageBox.Show("No se puede asociar a OP, OP no esta en proceso", "Aviso");
                    break;
                default:
                    MessageBox.Show("No se como llegue aqui xD", "ERROR");
                    break;
            }
            Actualizar();
        }

        internal void CargarHermanado()
        {
            if(!_gestor.CargarHermanado((_bindingOP.Current as Modelo.OP).Numero))
                    MessageBox.Show("OP Finalizada, no se puede cargar hermanado.","Aviso");
        }

        internal void IniciarVistaRegistrarInspeccion(int numero, int codSup)
        {
            new VistaRegistrarInspeccion(numero,codSup).Show();
        }

        internal void IniciarVistaCargarHermanado(int numero)
        {
            new VistaCargarHermanado(numero).Show();
        }

        internal void Desasociar()
        {
            ///deberiamos eliminar o cambiar por un boton de actualizacion
            Actualizar();
        }
    }
}
