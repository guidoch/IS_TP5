using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Modelo;
using TP1_ElControlDeCalidad.Presentadores;
using TP1_ElControlDeCalidad.Datos;

namespace TP1_ElControlDeCalidad.Gestores
{
    class GestorRegistrarInspeccion
    {
        private PresentadorRegistrarInspeccion _presentador;
        public OP OP { get; set; }
        public Empleado Supervisor { get; set; }
        public Inspeccion Inspeccion { get; set; }

        public GestorRegistrarInspeccion(PresentadorRegistrarInspeccion presentador, int numOP, int codSup)
        {
            this._presentador = presentador;
            this.OP = RepositorioOP.Instancia.BuscarCodigo(numOP);
            this.Supervisor = RepositorioEmpleados.Instancia.BuscarCodigo(codSup);
            this.Inspeccion = new Inspeccion() { ListaDefectos = new List<Defecto>() };
        }

        internal object ListarTiposDefectos()
        {
            return RepositorioTiposDefecto.Instancia._tiposdefecto;
        }

        internal void AgregarDefecto(Pie pie, TipoDefecto tipoDefecto)
        {
            Inspeccion.ListaDefectos.Add(new Defecto() { Codigo = (Inspeccion.ListaDefectos.Count()), Pie = pie, TipoDefecto = tipoDefecto });
        }

        internal int RegistrarInspeccion()
        {
            if (OP.AgregarInspeccion(Inspeccion))
            {
                var n = 0;
                RepositorioOP.Instancia.Actualizar(OP); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                if (Inspeccion.ListaDefectos.Count == 0)
                {
                    n = 0;
                }//MessageBox.Show("Inspeccion registrada./nResultado: PRIMERA.", "Aviso");
                else
                {
                    n = 1;//MessageBox.Show("Inspeccion registrada./nResultado: OBSERVADO.", "Aviso");
                    foreach (var d in Inspeccion.ListaDefectos)
                    {
                        if (d.TipoDefecto.Tipo.Equals(TipoClaseDefecto.REPROCESO)) n = 2;//MessageBox.Show("Inspeccion registrada./nResultado: REPROCESO.", "Aviso");
                    }
                }
                this.Inspeccion = new Inspeccion() { ListaDefectos = new List<Defecto>() };
                return n;
            }
            else
                return 99;//MessageBox.Show("Inspeccion no registrada", "Error");
        }
        internal bool Desasociar()
        {
            if (OP.Desasociar())   //revisar op pausada, desasociar de periodo
            {
                RepositorioOP.Instancia.Actualizar(OP); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true;
                //_vista.Close();
                //MessageBox.Show("Desasociado de op", "Aviso");
            }
            else
                return false; //MessageBox.Show("No se puede desasociar de una op activa", "Aviso");
        }
    }
}
