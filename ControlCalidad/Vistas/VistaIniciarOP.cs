﻿using System;
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
    public partial class VistaIniciarOP : Form
    {
        private PresentadorIniciarOP _presentador;
        public VistaIniciarOP(int codSup)
        {
            InitializeComponent();
            _presentador = new PresentadorIniciarOP(this, codSup, empleadoBindingSource, modeloBindingSource, colorBindingSource, lineaTrabajoBindingSource);
            cBoxModelo.DataSource = modeloBindingSource;
            cBoxModelo.DisplayMember = "Denominacion";
            cBoxModelo.ValueMember = "SKU";
            cBoxColor.DataSource = colorBindingSource;
            cBoxColor.DisplayMember = "Descripcion";
            cBoxColor.ValueMember = "Codigo";
            cBoxLinea.DataSource = lineaTrabajoBindingSource;
            cBoxLinea.DisplayMember = "Descripcion";
            cBoxLinea.ValueMember = "Numero";

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            _presentador.IniciarOP(int.Parse(textNumeroOP.Text), Convert.ToInt32(cBoxLinea.SelectedValue), 
                Convert.ToInt32(cBoxModelo.SelectedValue), Convert.ToInt32(cBoxColor.SelectedValue));
            this.Close();
        }

        private void VistaIniciarOP_Load(object sender, EventArgs e)
        {
            _presentador.Actualizar();
        }
    }
}
