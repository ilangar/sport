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
    public partial class CrearPerfil1 : Form
    {
        public Inicio formInicio;
        public string nombre;
        public int deporte;
        public int rol;
        public CrearPerfil1()
        {
            InitializeComponent();
        }

        private void BtnAceptarPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            formInicio.pasarDatos(nombre);
            formInicio.Show();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            
            
        }

        private void CmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            rol = cmbRol.SelectedIndex;
            rol++;
        }

        private void CmbDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            deporte = cmbDeporte.SelectedIndex;
            deporte++;
        }
    }
}
