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
        int l = 0;
        int t = 0;
        int posLbl = 120;
        int posTxt = 120;
        Perfil1 formPerfil1;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        string[] arrBask = new string[9] { "Puntos", "Asistencias", "Faltas", "Minutos Jugados", "Tiros fallados", "Bloqueos", "Rebotes", "Pelotas recuperadas", "Amonestaciones" };
        public void lblBasket()
        {
            while (l < 9)
            {
                Label lblBasket = new Label();
                this.Controls.Add(lblBasket);
                lblBasket.Location = new Point(90, posLbl);
                lblBasket.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblBasket.AutoSize = true;
                lblBasket.TextAlign = ContentAlignment.MiddleCenter;
                lblBasket.Text = arrBask [l];
                l++;
                posLbl += 40;
            }
        }
        public void txtBasket()
        {
            while (t < 9)
            {
                TextBox txtBasket = new TextBox();
                this.Controls.Add(txtBasket);
                txtBasket.Location = new Point(260, posTxt);
                t++;
                posTxt += 40;
            }
        }
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

            if (Convert.ToString(ds.Tables["Perfil"].Rows[1][0]) == "1")
            {
                lblBasket();
                txtBasket();
            }
            if (Convert.ToString(ds.Tables["Perfil"].Rows[1][0]) == "2")

        }



        private void BtnIngresarBasket_Click(object sender, EventArgs e)
        {
            formPerfil1 = new Perfil1();
            formPerfil1.Show();
            this.Hide();
        }
    }
}
