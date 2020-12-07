using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Modelo;
using TP1_ElControlDeCalidad.Vistas;
using TP1_ElControlDeCalidad.Datos;
using System.Windows.Forms;

namespace TP1_ElControlDeCalidad.Presentadores
{
    class PresentadorListaModelos

    {
        private VistaListaModelos _vista;
        private BindingSource _binding;

        public PresentadorListaModelos(VistaListaModelos vista, BindingSource binding)
        {
            _vista = vista;
            _binding = binding;
        }

        public void Actualizar()
        {
            _binding.DataSource = null;
            _binding.DataSource = RepositorioModelos.Instancia._modelos;
        }

        internal void Agregar()
        {
            var modelo = new Modelo.Modelo() { SKU = 9999 };
            new VistaModelo(modelo.SKU).ShowDialog();
            Actualizar();
        }

        internal void Editar()
        {
            var modelo = _binding.Current as Modelo.Modelo;
            new VistaModelo(modelo.SKU).ShowDialog();
            Actualizar();
        }
    }
}