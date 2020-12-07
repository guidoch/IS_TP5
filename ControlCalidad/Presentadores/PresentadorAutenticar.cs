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
    class PresentadorAutenticar
    {
        private VistaAutenticar _vista;
        private GestorAutenticar _gestor;

        public PresentadorAutenticar(VistaAutenticar vista)
        {
            this._vista = vista;
            this._gestor = new GestorAutenticar(this);
        }

        internal void Login(string user, string pass)
        {
            switch (_gestor.Login(user, pass))
            {
                case 0:
                    MessageBox.Show("Login exitoso.", "Aviso");
                    new VistaPrincipal(_gestor._sesion.Codigo).Show();
                    _gestor.Desvincular();
                    _vista.Actualizar();
                    break;
                case 2:
                    MessageBox.Show("Usuario en sesion existente.", "Aviso");
                    _vista.Actualizar();
                    break;
                case 1:
                    MessageBox.Show("Credenciales erroneas.", "Aviso");
                    _vista.Actualizar();
                    break;
                default:
                    MessageBox.Show("Como llegue aqui?", "ERROR");
                    break;
            }
        }
    }
}
