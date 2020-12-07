using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_ElControlDeCalidad.Datos;
using TP1_ElControlDeCalidad.Modelo;
using TP1_ElControlDeCalidad.Vistas;

namespace TP1_ElControlDeCalidad.Presentadores
{
    class PresentadorColor
    {
        private VistaColor _vista;
        private BindingSource _binding;
        private Color _color;

        public PresentadorColor(VistaColor vista, BindingSource binding, int codigo)
        {
            this._vista = vista;
            this._binding = binding;
            if (codigo == 9999)
            {
                _color = new Color { Codigo = codigo, Descripcion = "nuevo color" };
            }
            else
            {
                _color = RepositorioColores.Instancia.BuscarCodigo(codigo);
                _vista.DeshabilitarGuardar();
            }
        }

        public void Guardar()
        {
            RepositorioColores.Instancia.Guardar(_color);
        }

        public void Actualizar()
        {
            _binding.DataSource = _color;
        }
    }
}
