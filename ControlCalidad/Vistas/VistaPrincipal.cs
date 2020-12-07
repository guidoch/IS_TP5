using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_ElControlDeCalidad.Presentadores;

namespace TP1_ElControlDeCalidad.Vistas
{
    public partial class VistaPrincipal : Form
    {
        private PresentadorPrincipal _presentador;
        public Form Child { get; set; }
        /*private VistaListaOPSupCalidad  _vistaCalidad;
        private VistaListaOP _vistaOP;
        private VistaListaColores _vistaColores;
        private VistaListaModelos _vistaModelos;*/

        public VistaPrincipal(int sesion)
        {
            this._presentador = new PresentadorPrincipal(this, sesion);
            InitializeComponent();
            administradorToolStripMenuItem.Enabled = false;
            supervisorDeCalidadToolStripMenuItem.Enabled = false;
            sToolStripMenuItem.Enabled = false;
            datosEnLineaToolStripMenuItem.Enabled = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        public string Empleado { get; set;}

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            switch (_presentador.Actualziar())
            {
                case Modelo.Cargo.SUP_LINEA:
                    this.sToolStripMenuItem.Enabled = true;
                    break;
                case Modelo.Cargo.SUP_CALIDAD:
                    this.supervisorDeCalidadToolStripMenuItem.Enabled = true;
                    break;
                case Modelo.Cargo.ADMIN:
                    this.administradorToolStripMenuItem.Enabled = true;
                    break;
                default:
                    break;
            }
            this.Text = this.Empleado;
        }

        private void autenticarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void supervisorDeCalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.IniciarVistaListaOPSupCalidad();
        }


        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.IniciarVistaListaOP();
        }


        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.IniciarVistaListaModelos();
        }
        
        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _presentador.IniciarVistaListaColores();
        }

        private void datosEnLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado aun.","Aviso");
        }

        private void VistaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.CerrarSesion();
        }

        private void CerrarSesion()
        {
            _presentador.CerrarSesion();
        }
    }
}
