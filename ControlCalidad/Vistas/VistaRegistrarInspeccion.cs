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
    public partial class VistaRegistrarInspeccion : Form
    {
        private PresentadorRegistrarInspeccion _presentador;
        public VistaRegistrarInspeccion(int numOP, int codSup)
        {
            InitializeComponent();

            dataGridViewOP.AllowUserToAddRows = false;
            dataGridViewOP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOP.ReadOnly = true;
            dataGridViewDefectos.AllowUserToAddRows = false;
            dataGridViewDefectos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDefectos.ReadOnly = true;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;

            cBoxPie.DataSource = Enum.GetValues(typeof(Modelo.Pie));

            cBoxTipoDefecto.DisplayMember = "Descripcion";
            cBoxTipoDefecto.ValueMember = "Codigo";

            _presentador = new PresentadorRegistrarInspeccion(this, numOP, codSup, empleadoBindingSource, oPBindingSource, defectoBindingSource, tipoDefectoBindingSource);
        }

        private void VistaRegistrarInspeeccion_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }

        private void btnAgregarDefecto_Click(object sender, EventArgs e)
        {
            Modelo.Pie pie;
            Enum.TryParse<Modelo.Pie>(cBoxPie.SelectedValue.ToString(), out pie);
            _presentador.AgregarDefecto(pie);
        }

        private void btnRegistrarInsp_Click(object sender, EventArgs e)
        {
            _presentador.RegistrarInspeccion();
        }

        private void btnDesasociar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaRegistrarInspeccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !(_presentador.Desasociar());
        }
    }
}
