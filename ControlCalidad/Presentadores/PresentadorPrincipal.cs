using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Gestores;
using TP1_ElControlDeCalidad.Vistas;

namespace TP1_ElControlDeCalidad.Presentadores
{
    class PresentadorPrincipal
    {
        private VistaPrincipal _vista;
        private GestorPrincipal _gestor;
        public PresentadorPrincipal(VistaPrincipal vista, int sesion)
        {
            _vista = vista;
            _gestor = new GestorPrincipal(this, sesion);
        }

        internal void CerrarSesion()
        {
            _gestor.CerrarSesion();
        }

        internal Modelo.Cargo Actualziar()
        {
            _vista.Empleado = _gestor.Sesion.User.Empleado.Nombre;
            return _gestor.Sesion.User.Empleado.Cargo;
        }

        internal void IniciarVistaListaOPSupCalidad()
        {
            if ((_vista.Child == null || _vista.Child.Visible != true) && _gestor.VerificarSupCalidad())
            {
                _vista.Child = new VistaListaOPSupCalidad(_gestor.Sesion.User.Empleado.Codigo); //corregir enviar codigo no empleado
                _vista.Child.MdiParent = this._vista;
                _vista.Child.Show();
            }
        }

        internal void IniciarVistaListaOP()
        {
            if ((_vista.Child == null || _vista.Child.Visible != true) && _gestor.VerificarSupLinea())
            {
                _vista.Child = new VistaListaOP(_gestor.Sesion.User.Empleado.Codigo); //corregir enviar codigo no empleado
                _vista.Child.MdiParent = this._vista;
                _vista.Child.Show();
            }
        }

        internal void IniciarVistaListaModelos()
        {
            if ((_vista.Child == null || _vista.Child.Visible != true) && _gestor.VerificarAdmin())
            {
                _vista.Child = new VistaListaModelos(_gestor.Sesion.User.Empleado.Codigo);
                _vista.Child.MdiParent = this._vista;
                _vista.Child.Show();
            }
        }

        internal void IniciarVistaListaColores()
        {
            if ((_vista.Child == null || _vista.Child.Visible != true) && _gestor.VerificarAdmin())
            {
                _vista.Child = new VistaListaColores(_gestor.Sesion.User.Empleado.Codigo);
                _vista.Child.MdiParent = this._vista;
                _vista.Child.Show();
            }
        }
    }
}
