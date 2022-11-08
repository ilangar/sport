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
        string deporte;
        perfilEnt formPerfilEnt;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        bool nombreRepe = false;
        public nuevoJug()
        {
            InitializeComponent();

        }

        private void BtnNuevoJug_Click(object sender, EventArgs e)
        {
            string[] nombresPer = new string[ds.Tables["Perfil"].Rows.Count];
            string[] nombresJug = new string[ds2.Tables["JugadorEquipo"].Rows.Count];
            string nom = txtNomJug.Text;
            for (int a = 0; a < nombresPer.Length; a++)
            {
                nombresPer[a] = Convert.ToString(ds.Tables["Perfil"].Rows[a][0]);
                if (nom == nombresPer[a])
                {
                    nombreRepe = true;
                }
            }
            for (int c = 0; c < nombresJug.Length; c++)
            {
                nombresJug[c] = Convert.ToString(ds2.Tables["JugadorEquipo"].Rows[c][0]);
                if (nom == nombresJug[c])
                {
                    nombreRepe = true;
                }
            }
            if (nombreRepe)
            {
                MessageBox.Show("Ya usaste este nombre");

            }
            if (!nombreRepe)
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO JugadorEquipo (Nombre, Deporte, IdUser) values ('" + txtNomJug.Text + "','" + deporte + "'," + Program.idUser + ")";
                command.ExecuteNonQuery();
                connection.Close();
                this.Hide();
                perfilEnt formPerfilEnt = new perfilEnt();
                formPerfilEnt.Show();
            }
            nombreRepe = false;
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
            OleDbCommand info2;
            OleDbCommand info3;
            info = new OleDbCommand("Select Nombre FROM Perfil", connection);
            info2 = new OleDbCommand("SELECT Nombre FROM JugadorEquipo", connection);
            info3 = new OleDbCommand("SELECT Deporte FROM Perfil WHERE Nombre = '" + Program.idPerfil + "'", connection);
            OleDbDataAdapter da1 = new OleDbDataAdapter(info);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            OleDbDataAdapter da3 = new OleDbDataAdapter(info3);
            da1.Fill(ds, "Perfil");
            da2.Fill(ds2, "JugadorEquipo");
            da3.Fill(ds3, "Deporte");
            deporte = Convert.ToString(ds3.Tables["Deporte"].Rows[0][0]);
        }

        private void TxtNomJug_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNomJug.Text;
        }

    }
}   
