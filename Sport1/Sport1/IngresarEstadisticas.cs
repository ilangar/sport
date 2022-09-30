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
using System.Data.SqlClient;

namespace Sport1
{
    public partial class IngresarEstadisticas : Form
    {
        public int[] fechaBasket = new int[2000];
        public int dia;
        public int mes;
        public int año;
        public int fecha;
        public int puntos;
        public int asistencias;
        public int faltas;
        public int minJugados;
        public int tirosFal;
        public int bloqueos;
        Label lblPuntos;
        Perfil1 formPerfil1;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");

        public IngresarEstadisticas()
        {
            InitializeComponent();
        }

        private void IngresarEstadisticas_Load(object sender, EventArgs e)
        {
            connection.Open();

            OleDbCommand info;
            info = new OleDbCommand("Select Deporte, Nombre FROM Perfil", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            DataSet ds = new DataSet();
            da.Fill(ds, "Perfil");
            if (Convert.ToString(ds.Tables["Perfil"].Rows[0][0]) == "1")
            {

                lblPuntos = new Label();
                this.Controls.Add(lblPuntos);
                lblPuntos.Location = new Point(115, 119);
                lblPuntos.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point,((Byte)(0)));
                lblPuntos.AutoSize = true;
                lblPuntos.TextAlign = ContentAlignment.MiddleCenter;
                lblPuntos.Text = "Puntos";
                lblPuntos.Show();



            }
        }



        private void BtnIngresarBasket_Click(object sender, EventArgs e)
        {
            formPerfil1 = new Perfil1();
            formPerfil1.Show();
            this.Hide();
        }
    }
}
