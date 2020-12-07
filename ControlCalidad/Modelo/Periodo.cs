using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Datos;

namespace TP1_ElControlDeCalidad.Modelo
{
    public class Periodo
    {
        public Periodo(int codigo, bool iniciar)
        {
            Codigo = codigo;
            if (iniciar) { Inicio = RepositorioHora.Instancia.HoraActual(); } //BUSCAR DE REPO
            ListaInspeecciones = new List<Inspeccion>();
            Turno = RepositorioTurnos.Instancia.TurnoActual(); ///ojo hardcodeado
        }
        public int Codigo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public Turno Turno { get; set; }
        public Empleado Supervisor { get; set; }
        public List<Inspeccion> ListaInspeecciones { get; set; }
    }
}
