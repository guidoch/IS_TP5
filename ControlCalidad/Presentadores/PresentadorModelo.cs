using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Vistas;
using TP1_ElControlDeCalidad.Modelo;
using TP1_ElControlDeCalidad.Datos;
using System.Windows.Forms;

namespace TP1_ElControlDeCalidad.Presentadores
{
    class PresentadorModelo
    {
        private VistaModelo _vista;
        private BindingSource _binding;
        private Modelo.Modelo _modelo;

      

        public PresentadorModelo(VistaModelo vista, BindingSource binding, int codigo)
        {
            this._vista = vista;
            this._binding = binding;
            if (codigo == 9999)
            {
                _modelo = new Modelo.Modelo { SKU = 0, Denominacion = "nuevo modelo", Objetivo = 0 };
            }
            else
            {
                _modelo = RepositorioModelos.Instancia.BuscarCodigo(codigo);
                _vista.DeshabilitarGuardar();
            }
        }

        public void Guardar()
        {
            RepositorioModelos.Instancia.Guardar(_modelo);
        }

        public void Actualizar()
        {
            _binding.DataSource = _modelo;
        }
    }
}
