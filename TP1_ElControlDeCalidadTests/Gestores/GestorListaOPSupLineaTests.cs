using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP1_ElControlDeCalidad.Gestores;
using TP1_ElControlDeCalidad.Modelo;
using TP1_ElControlDeCalidad.Datos;
using TP1_ElControlDeCalidad.Presentadores;
using TP1_ElControlDeCalidad.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class GestorListaOPSupLineaTests
    {
        [TestMethod()]
        public void PausarOPEnCursoTest()
        {
            var supervisor = new Empleado() { Codigo = 91, Cargo = Cargo.SUP_LINEA, Documento = 111, Nombre = "Sup Linea 91", EMail = "@91" };
            RepositorioEmpleados.Instancia.Guardar(supervisor);

            var op = new OP(91, supervisor, null, null, null);
            RepositorioOP.Instancia.Guardar(op);

            var vista = new VistaListaOP(supervisor.Codigo);

            var resultado = vista._presentador._gestor.PausarOP(op.Numero);

            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void PausarOPNoEnCursoTest()
        {
            var supervisor = new Empleado() { Codigo = 92, Cargo = Cargo.SUP_LINEA, Documento = 111, Nombre = "Sup Linea 92", EMail = "@92" };
            RepositorioEmpleados.Instancia.Guardar(supervisor);

            var op = new OP(92, supervisor, null, null, null);
            RepositorioOP.Instancia.Guardar(op);

            var vista = new VistaListaOP(supervisor.Codigo);

            bool resultado = true;

            if (vista._presentador._gestor.PausarOP(op.Numero))
            {
                resultado = vista._presentador._gestor.PausarOP(op.Numero);
            }

            Assert.IsFalse(resultado);
        }

        [TestMethod()]
        public void FinalizarOPPausadaTest()
        {
            var supervisor = new Empleado() { Codigo = 93, Cargo = Cargo.SUP_LINEA, Documento = 111, Nombre = "Sup Linea 93", EMail = "@93" };
            RepositorioEmpleados.Instancia.Guardar(supervisor);

            var op = new OP(93, supervisor, null, null, null);
            RepositorioOP.Instancia.Guardar(op);

            var vista = new VistaListaOP(supervisor.Codigo);
            
            bool resultado = false;

            if (vista._presentador._gestor.PausarOP(op.Numero))
            {
                resultado = vista._presentador._gestor.FinalizarOP(op.Numero);
            }

            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void FinalizarOPNoPausadaTest()
        {
            var supervisor = new Empleado() { Codigo = 94, Cargo = Cargo.SUP_LINEA, Documento = 111, Nombre = "Sup Linea 94", EMail = "@94" };
            RepositorioEmpleados.Instancia.Guardar(supervisor);

            var op = new OP(94, supervisor, null, null, null);
            RepositorioOP.Instancia.Guardar(op);

            var vista = new VistaListaOP(supervisor.Codigo);

            var resultado = vista._presentador._gestor.FinalizarOP(op.Numero);

            Assert.IsFalse(resultado);
        }

        [TestMethod()]
        public void ReanudarOPPausadaTest()
        {
            var supervisor = new Empleado() { Codigo = 95, Cargo = Cargo.SUP_LINEA, Documento = 111, Nombre = "Sup Linea 95", EMail = "@95" };
            RepositorioEmpleados.Instancia.Guardar(supervisor);

            var op = new OP(95, supervisor, null, null, null);
            RepositorioOP.Instancia.Guardar(op);

            var vista = new VistaListaOP(supervisor.Codigo);

            bool resultado = false;

            if (vista._presentador._gestor.PausarOP(op.Numero))
            {
                resultado = vista._presentador._gestor.ReanudarOP(op.Numero);
            }

            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void ReanudarOPNoPausadaTest()
        {
            var supervisor = new Empleado() { Codigo = 96, Cargo = Cargo.SUP_LINEA, Documento = 111, Nombre = "Sup Linea 96", EMail = "@96" };
            RepositorioEmpleados.Instancia.Guardar(supervisor);

            var op = new OP(96, supervisor, null, null, null);
            RepositorioOP.Instancia.Guardar(op);

            var vista = new VistaListaOP(supervisor.Codigo);

            var resultado = vista._presentador._gestor.ReanudarOP(op.Numero);

            Assert.IsFalse(resultado);
        }
    }
}