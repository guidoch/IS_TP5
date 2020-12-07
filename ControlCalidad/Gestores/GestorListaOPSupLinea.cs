using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Datos;
using TP1_ElControlDeCalidad.Modelo;
using TP1_ElControlDeCalidad.Presentadores;

namespace TP1_ElControlDeCalidad.Gestores
{
    public class GestorListaOPSupLinea
    {
        private PresentadorListaOpSupLinea _presentador;

        public GestorListaOPSupLinea(PresentadorListaOpSupLinea presentador, int codSup)
        {
            this._presentador = presentador;
            this.Supervisor = RepositorioEmpleados.Instancia.BuscarCodigo(codSup);
            RepositorioOP.Suscribe(Actualizar); //me suscribo para recibir aaactualizaciones del repo
        }

        public Empleado Supervisor { get; set; }
        private void Actualizar()
        {
            _presentador.Actualizar();
        }
        internal List<OP> ListarOPs()
        {
            return RepositorioOP.Instancia.BuscarSupervisorLinea(Supervisor);
        }

        internal bool ControlarTodasFinalizadas()
        {
            return RepositorioOP.Instancia.TodasFinalizadas(Supervisor);
        }

        public bool ReanudarOP(int numero)
        {
            var op = (RepositorioOP.Instancia.BuscarCodigo(numero));
            if (op.Estado != Estado.PAUSADA) 
                return false; // MessageBox.Show("OP no se puede reanudar", "Aviso");
            else
            {
                op.Reanudar();
                RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true; // MessageBox.Show("OP reanudada", "Aviso");
            }
        }

        public bool FinalizarOP(int numero)
        {
            var op = RepositorioOP.Instancia.BuscarCodigo(numero);
            if (op.Estado != Estado.PAUSADA)
                return false; // MessageBox.Show("OP no se puede finalizar", "Aviso");
            else
            {
                op.Finalizar();
                RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true; // MessageBox.Show("OP finalizada", "Aviso");
            }
        }

        public bool PausarOP (int numero)
        {
            var op = RepositorioOP.Instancia.BuscarCodigo(numero);
            if (op.Estado != Estado.EN_PROCESO)
                return false; // MessageBox.Show("OP no se puede pausar", "Aviso");
            else
            {
                op.Pausar();
                RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true; // MessageBox.Show("OP pausada", "Aviso");
            }
        }
    }
}
