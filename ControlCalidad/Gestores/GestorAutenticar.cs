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
    class GestorAutenticar
    {
        private PresentadorAutenticar _presentador;
        public Sesion _sesion { get; set; }

        public GestorAutenticar(PresentadorAutenticar presentador)
        {
            this._presentador = presentador;
        }

        internal int Login(string user, string pass)
        {
            var usuario = RepositorioUsuarios.Instancia.BuscarUsername(user);
            if (usuario != null)
            {
                if (RepositorioSesiones.Instancia.ConsultarUsuarioLibre(user))
                {
                    if (usuario.Password == pass)
                    {

                        this._sesion = new Sesion(RepositorioSesiones.Instancia._sesiones.Count(), usuario);
                        RepositorioSesiones.Instancia.Guardar(_sesion);
                        return 0;
                    }
                    else return 1;
                }
                else return 2;
            }
            return 1;
            
        }
        internal void Desvincular()
        {
            this._sesion = null;
        }
    }
}
