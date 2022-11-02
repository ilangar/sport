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
        perfilEnt formPerfilEnt;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        DataSet ds = new DataSet();
        public nuevoJug()
        {
            InitializeComponent();

        }

        private void BtnNuevoJug_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "INSERT INTO JugadorEquipo (Nombre, Deporte, NomEnt) values ('" + txtNomJug.Text + "','" + deporte + "','" + Program.idPerfil + "')";
            command.ExecuteNonQuery();
            connection.Close();
            this.Hide();
            perfilEnt formPerfilEnt = new perfilEnt();
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

            OleDbCommand info;
            info = new OleDbCommand("SELECT Deporte FROM Perfil WHERE Nombre = '" + Program.idPerfil + "'", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            da.Fill(ds, "Perfil");
            deporte = Convert.ToString(ds.Tables["Perfil"].Rows[0][0]);
        }

        private void TxtNomJug_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNomJug.Text;
        }

        private void NuevoJug_Load_1(object sender, EventArgs e)
        {

        }
    }
}
