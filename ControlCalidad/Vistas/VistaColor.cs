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
    public partial class VistaColor : Form
    {
        private PresentadorColor _presentador;

        public VistaColor(int color)
        {
            InitializeComponent();
            _presentador = new PresentadorColor(this, this.colorBindingSource, color);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.WindowState = FormWindowState.Maximized;
            //this.ControlBox = false;
        }

        internal void DeshabilitarGuardar()
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.Guardar();
        }

        private void VistaColor_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }
    }
}
