using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport1
{
    public partial class nuevoJug : Form
    {
        public string nombre;
        string i = "";
        OleDbConnection connection = new OleDbConnection();
        perfilEnt formPerfilEnt;
        public nuevoJug(string caller)
        {
            InitializeComponent();
            i = caller ;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb";
        }

        private void BtnNuevoJug_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO JugadorEquipo (Nombre, Deporte) values ('" + nombre + "','" +  + "')";
            command.ExecuteNonQuery();
            connection.Close();
            this.Hide();
            Inicio f2 = new Inicio();
            f2.ShowDialog();

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

        private void NuevoJug_Load(object sender, EventArgs e)
        {

        }

        private void TxtNomJug_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNomJug.Text;
        }
    }
}
