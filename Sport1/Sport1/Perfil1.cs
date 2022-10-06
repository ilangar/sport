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
    public partial class Perfil1 : Form
    {
        public CrearPerfil1 formCrearPerfil1;
        public Inicio formInicio;
        public IngresarEstadisticas formIngrEst;
        
        public Perfil1()
        {
            InitializeComponent();
        }

        private void Perfil1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            formInicio.Show();
            this.Hide();

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void LblNomPerfil_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresarEstadisticas_Click(object sender, EventArgs e)
        {
            
            formIngrEst = new IngresarEstadisticas();
            formIngrEst.formInicio = formInicio;
            this.Hide();
            formIngrEst.Show();
        }
    }
}
