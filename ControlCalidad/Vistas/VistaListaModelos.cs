using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_ElControlDeCalidad.Modelo;
using TP1_ElControlDeCalidad.Presentadores;

namespace TP1_ElControlDeCalidad.Vistas
{
    public partial class VistaListaModelos : Form
    {
        private PresentadorListaModelos _presentador;

        public VistaListaModelos(int codigoEmpleado)
        {
            InitializeComponent();
            _presentador = new PresentadorListaModelos(this, this.modeloBindingSource);

            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AllowUserToAddRows = false;

            this.WindowState = FormWindowState.Maximized;

        }

        private void VistaListaModelos_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
            
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
            _presentador.Agregar();
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            _presentador.Editar();
        }
    }
}
