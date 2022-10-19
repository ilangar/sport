using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport1
{
    public partial class perfilEnt : Form
    {
        public string caller = "Nuevo jugador";
        public Inicio formInicio;
        public perfilEnt()
        {
            InitializeComponent();
        }

        private void PerfilEnt_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregarJug_Click(object sender, EventArgs e)
        {
            CrearPerfil1 formCrearPerfil1 = new CrearPerfil1(caller);
            this.Hide();
            formCrearPerfil1.Show();
        }

        private void BtnVolverAtras_Click(object sender, EventArgs e)
        {
            formInicio = new Inicio();
            this.Hide();
            formInicio.Show();
        }
    }
}
