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
    public partial class VistaListaOP : Form
    {
        public PresentadorListaOpSupLinea _presentador;
        public VistaListaOP(int codSup)
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            _presentador = new PresentadorListaOpSupLinea(this, codSup, empleadoBindingSource, oPBindingSource);
            /*if (supervisor.Cargo == Cargo.SUP_LINEA) ///lo del if era para ver que sup era y en base a eso usar presentadores distintos
            {
                _presentador = new PresentadorListaOpSupLinea(this, supervisor, empleadoBindingSource, oPBindingSource);
            }*/
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
        }

        private void VistaListaOP_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }

        private void btn_iniaciar_Click(object sender, EventArgs e)
        {
            _presentador.IniciarOP();
        }

        private void btn_pausar_Click(object sender, EventArgs e)
        {
            _presentador.PausarOP();
        }

        private void btn_reanudar_Click(object sender, EventArgs e)
        {
            _presentador.ReanudarOP();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            _presentador.FinalizarOP();
        }

        private void btn_vizualizar_Click(object sender, EventArgs e)
        {
            _presentador.VisualizarOP();
            //MessageBox.Show("No implementado aun :)", "Disculpas");
        }
    }
}
