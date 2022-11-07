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
        string[] nombres = new string[20];
        DataSet ds = new DataSet();
        int a = 0;
        public CrearPerfil1(string caller)
        {
            InitializeComponent();
            i = caller;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb";
        }

        private void BtnAceptarPerfil_Click(object sender, EventArgs e)
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
            OleDbCommand info;
            info = new OleDbCommand("Select Nombre FROM Perfil", connection);
            OleDbDataAdapter da1 = new OleDbDataAdapter(info);
            da1.Fill(ds, "Perfil");
            while (a < ds.Tables["Perfil"].Rows.Count)
            {
                nombres[a] = Convert.ToString(ds.Tables["Perfil"].Rows[0][a]);

            }
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
    }
}
