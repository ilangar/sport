using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Sport1
{
    public partial class CrearPerfil1 : Form
    {
        public Inicio formInicio;
        public string nombre;
        public int deporte;
        public int rol;
        public perfilEnt formPerfilEnt;
        string i = "";
        OleDbConnection connection = new OleDbConnection();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        int a = 0;
        bool nombreRepe = false;
        public CrearPerfil1(string caller)
        {
            InitializeComponent();
            i = caller;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb";
        }

        private void BtnAceptarPerfil_Click(object sender, EventArgs e)
        {
            string[] nombresPer = new string[ds.Tables["Perfil"].Rows.Count];
            string[] nombresJug = new string[ds2.Tables["JugadorEquipo"].Rows.Count];
            string nom = txtNombre.Text;
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
                command.CommandText = "INSERT INTO Perfil (Nombre, Deporte, Rol) values ('" + nombre + "','" + deporte + "','" + rol + "')";
                command.ExecuteNonQuery();
                connection.Close();

                this.Hide();
                Inicio f2 = new Inicio();
                f2.ShowDialog();
            }
            nombreRepe = false;
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

        private void CrearPerfil1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            OleDbCommand info;
            OleDbCommand info2;
            info = new OleDbCommand("Select Nombre FROM Perfil", connection);
            info2 = new OleDbCommand("SELECT Nombre FROM JugadorEquipo", connection);
            OleDbDataAdapter da1 = new OleDbDataAdapter(info);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            da1.Fill(ds, "Perfil");
            da2.Fill(ds2, "JugadorEquipo");

        }

        private void BtnVolverAEnt_Click(object sender, EventArgs e)
        {

            formInicio = new Inicio();
            this.Hide();
            formInicio.Show();
            
        }

        private void LblNombre_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
