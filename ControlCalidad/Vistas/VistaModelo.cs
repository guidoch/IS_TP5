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
    public partial class VistaModelo : Form
    {
        private PresentadorModelo _presentador;

        public VistaModelo(int codigo)
        {
            InitializeComponent();
            _presentador = new PresentadorModelo(this, this.bsModelo, codigo);
            
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.WindowState = FormWindowState.Maximized;
            //this.ControlBox = false;
        }

        internal void DeshabilitarGuardar()
        {
            butBus.Enabled = false;
        }

        private void butBus_Click(object sender, EventArgs e)
        {
            _presentador.Guardar();
        }

        private void VistaModelo_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }
    }
}
