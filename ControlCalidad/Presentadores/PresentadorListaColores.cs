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
    class PresentadorListaColores
    {
        private VistaListaColores _vista;
        private BindingSource _binding;

        public PresentadorListaColores(VistaListaColores vista, BindingSource binding)
        {
            _vista = vista;
            _binding = binding;
        }

        public void Actualizar ()
        {
            _binding.DataSource = null;
            _binding.DataSource = RepositorioColores.Instancia._colores;
        }

        internal void Agregar()
        {
            var color = new Color() { Codigo = 9999};
            new VistaColor(color.Codigo).ShowDialog();
            Actualizar();
        }

        internal void Editar()
        {
            var color = _binding.Current as Color;
            new VistaColor(color.Codigo).ShowDialog();
            Actualizar();
        }
    }
}
