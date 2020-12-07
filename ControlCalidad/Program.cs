using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_ElControlDeCalidad.Datos;
using TP1_ElControlDeCalidad.Vistas;

namespace TP1_ElControlDeCalidad
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VistaAutenticar());
        }
    }
}
