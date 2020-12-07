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
    public partial class VistaListaColores : Form
    {
        private PresentadorListaColores _presentador;
        public VistaListaColores(int codigoEmpleado)
        {
            InitializeComponent();
            _presentador = new PresentadorListaColores(this, this.colorBindingSource);
            ///_presentador.Actualizar();
            ///this.bindingSource1.SuspendBinding();
            ///this.dataGridView1.Columns.Clear();
            /////this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;
            ///this.dataGridView1.Enabled = false;
            ///this.dataGridView1.Invalidate();
            ///this.bindingSource1.ResumeBinding();
            ///this.dataGridView1.Enabled = true;
            ///this.dataGridView1.Refresh();
            ///
            this.WindowState = FormWindowState.Maximized;
            //this.ControlBox = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.Agregar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presentador.Editar();
        }

        private void VistaListaColores_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }
    }
}
