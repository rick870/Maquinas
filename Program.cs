using System;
using System.Windows.Forms;

namespace Maquinas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Esto lanza tu interfaz gráfica
            Application.Run(new Frm_Maquinas());
        }
    }
}