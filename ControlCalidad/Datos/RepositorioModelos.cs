using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_ElControlDeCalidad.Modelo;

namespace TP1_ElControlDeCalidad.Datos
{
    public class RepositorioModelos : IRepositorio<Modelo.Modelo>
    {
        public static RepositorioModelos Instancia = new RepositorioModelos();
        public List<Modelo.Modelo> _modelos;
        public RepositorioModelos()
        {
            _modelos = new List<Modelo.Modelo>
            {
                new Modelo.Modelo() { SKU = 0, Denominacion = "X0", Objetivo = 80},
                new Modelo.Modelo() { SKU = 1, Denominacion = "X1", Objetivo = 80},
                new Modelo.Modelo() { SKU = 2, Denominacion = "X2", Objetivo = 80},
                new Modelo.Modelo() { SKU = 3, Denominacion = "X3", Objetivo = 80},
                new Modelo.Modelo() { SKU = 4, Denominacion = "X4", Objetivo = 80}
            };
        }
        public Modelo.Modelo BuscarCodigo(int codigo)
        {
            foreach (var modelo in _modelos)
            {
                if (codigo == modelo.SKU)
                {
                    return modelo;
                }
            }
            return null;
        }

        public void Guardar(Modelo.Modelo modelo)
        {
            _modelos.Add(modelo);
        }

        public Modelo.Modelo VerificarExistencia(int codigo)
        {
            foreach (var modelo in _modelos)
            {
                if (codigo == modelo.SKU)
                {
                    return modelo;
                }
            }
            return null;
        }
    }
}
