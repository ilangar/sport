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

namespace Sport1
{
    public partial class objetivos : Form
    {

        private OleDbConnection connection = new OleDbConnection();
        public objetivos()
        {
            InitializeComponent();
        }
        
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Objfutbol_Load(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb";

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Deporte from Perfil WHERE Nombre='" + "Mauro" + "'";
            OleDbDataReader reader = command.ExecuteReader();

            reader.Read();
            int Deporte = int.Parse(reader["Deporte"].ToString());

            connection.Close();
            connection.Open();
=======
            OleDbCommand info;
            info = new OleDbCommand("Select Deporte FROM Perfil", BaseDeDatosProyecto);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            DataSet ds = new DataSet();
            da.Fill(ds, "Perfil");
            string var = ds.Tables["Perfil"].Rows[0][0].ToString();
>>>>>>> Stashed changes

        }

        private void Lblobjfutbol_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click_1(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
