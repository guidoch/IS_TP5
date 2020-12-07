using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Presentadores;
using TP1_ElControlDeCalidad.Modelo;
using TP1_ElControlDeCalidad.Datos;
using System.Data;

namespace TP1_ElControlDeCalidad.Gestores
{
    class GestorVisualizarInformacion
    {
        private PresentadorVisualizarInformacion _presentador;
        public OP OP { get; set; }

        public GestorVisualizarInformacion(PresentadorVisualizarInformacion presentador, int op)
        {
            this._presentador = presentador;
            this.OP = RepositorioOP.Instancia.BuscarCodigo(op);
            RepositorioOP.Suscribe(Actualizar); //me suscribo para recibir aaactualizaciones del repo
        }

        private void Actualizar()
        {
            _presentador.Actualizar();
        }

        internal int ContarPrimeraEnTurno()
        {
            return RepositorioOP.Instancia.ContarPrimeraEnTurno(OP);
        }

        internal void Close()
        {
            RepositorioOP.Desuscribe(Actualizar);
        }

        internal int CalcularObjetivo()
        {
            var turno = RepositorioTurnos.Instancia.TurnoActual();
            int hs = turno.Fin.Hour - turno.Inicio.Hour;
            if (hs < 0) hs = hs * -1;
            return OP.Modelo.Objetivo * hs;
        }

        internal DataTable TopDefectos()
        {
            return RepositorioOP.Instancia.TopDefectos(OP);
        }
    }
}
