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
            if (Convert.ToString(ds.Tables["Perfil"].Rows[1][0]) == "1")
            {
                Label lblPuntos = new Label();
                this.Controls.Add(lblPuntos);
                lblPuntos.Location = new Point(90, 120);
                lblPuntos.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblPuntos.AutoSize = true;
                lblPuntos.TextAlign = ContentAlignment.MiddleCenter;
                lblPuntos.Text = "Puntos";
                lblPuntos.Show();

                TextBox txtPuntos = new TextBox();
                this.Controls.Add(txtPuntos);
                txtPuntos.Location = new Point(200, 120);

                Label lblAsistencias = new Label();
                this.Controls.Add(lblAsistencias);
                lblAsistencias.Location = new Point(90, 160);
                lblAsistencias.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblAsistencias.AutoSize = true;
                lblAsistencias.TextAlign = ContentAlignment.MiddleCenter;
                lblAsistencias.Text = "Asistencias";
                lblAsistencias.Show();

                TextBox txtAsistencias = new TextBox();
                this.Controls.Add(txtAsistencias);
                txtAsistencias.Location = new Point(200, 160);

                Label lblFaltas = new Label();
                this.Controls.Add(lblFaltas);
                lblFaltas.Location = new Point(90, 200);
                lblFaltas.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblFaltas.AutoSize = true;
                lblFaltas.TextAlign = ContentAlignment.MiddleCenter;
                lblFaltas.Text = "Faltas";
                lblFaltas.Show();

                TextBox txtFaltas = new TextBox();
                this.Controls.Add(txtFaltas);
                txtFaltas.Location = new Point(200, 200);

                Label lblMinJug = new Label();
                this.Controls.Add(lblMinJug);
                lblFaltas.Location = new Point(90, 240);
                lblFaltas.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblFaltas.AutoSize = true;
                lblFaltas.TextAlign = ContentAlignment.MiddleCenter;
                lblFaltas.Text = "Minutos jugados";
                lblFaltas.Show();

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
