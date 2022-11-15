using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport1
{
    static class Program
    {
        public static string idPerfil;
        internal static int idUser;
        public static string idJugador;
        public static bool jugador = false;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
        }
    }
}
