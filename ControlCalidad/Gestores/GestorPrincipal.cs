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
    class GestorPrincipal
    {
        private PresentadorPrincipal _presentador;
        public Sesion Sesion { get; set; }

        public GestorPrincipal(PresentadorPrincipal presentador, int nSesion)
        {
            this._presentador = presentador;
            this.Sesion = RepositorioSesiones.Instancia.BuscarCodigo(nSesion);
        }

        internal void CerrarSesion()
        {
            this.Sesion.Finalizar();
            //RepositorioSesiones.Instancia.Actualizar(Sesion); <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
        }

        internal bool VerificarSupCalidad()
        {
            return this.Sesion.User.Empleado.Cargo.Equals(Cargo.SUP_CALIDAD);
        }
        internal bool VerificarSupLinea()
        {
            return this.Sesion.User.Empleado.Cargo.Equals(Cargo.SUP_LINEA);
        }
        internal bool VerificarAdmin()
        {
            return this.Sesion.User.Empleado.Cargo.Equals(Cargo.ADMIN);
        }
    }
}
