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
    public partial class nuevoJug : Form
    {
        perfilEnt formPerfilEnt;
        public nuevoJug()
        {
            InitializeComponent();
        }

        private void BtnNuevoJug_Click(object sender, EventArgs e)
        {
            formPerfilEnt = new perfilEnt();
            this.Hide();
            formPerfilEnt.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            formPerfilEnt = new perfilEnt();
            this.Hide();
            formPerfilEnt.Show();
        }
    }
}
