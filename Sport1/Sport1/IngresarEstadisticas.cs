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
                txtPuntos.Location = new Point(260, 120);

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
                txtAsistencias.Location = new Point(260, 160);

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
                txtFaltas.Location = new Point(260, 200);

                Label lblMinJug = new Label();
                this.Controls.Add(lblMinJug);
                lblMinJug.Location = new Point(90, 240);
                lblMinJug.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblMinJug.AutoSize = true;
                lblMinJug.TextAlign = ContentAlignment.MiddleCenter;
                lblMinJug.Text = "Minutos jugados";
                lblMinJug.Show();

                TextBox txtMinJug = new TextBox();
                this.Controls.Add(txtMinJug);
                txtMinJug.Location = new Point(260, 240);

                Label lblTirosFal = new Label();
                this.Controls.Add(lblTirosFal);
                lblTirosFal.Location = new Point(90, 280);
                lblTirosFal.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblTirosFal.AutoSize = true;
                lblTirosFal.TextAlign = ContentAlignment.MiddleCenter;
                lblTirosFal.Text = "Tiros fallados";
                lblTirosFal.Show();

                TextBox txtTirosFal = new TextBox();
                this.Controls.Add(txtTirosFal);
                txtTirosFal.Location = new Point(260, 280);

                Label lblBloqueos = new Label();
                this.Controls.Add(lblBloqueos);
                lblBloqueos.Location = new Point(90, 320);
                lblBloqueos.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblBloqueos.AutoSize = true;
                lblBloqueos.TextAlign = ContentAlignment.MiddleCenter;
                lblBloqueos.Text = "Bloqueos";
                lblBloqueos.Show();

                TextBox txtBloqueos = new TextBox();
                this.Controls.Add(txtBloqueos);
                txtBloqueos.Location = new Point(260, 320);

                Label lblRebotes = new Label();
                this.Controls.Add(lblRebotes);
                lblRebotes.Location = new Point(90, 360);
                lblRebotes.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblRebotes.AutoSize = true;
                lblRebotes.TextAlign = ContentAlignment.MiddleCenter;
                lblRebotes.Text = "Rebotes";
                lblRebotes.Show();

                TextBox txtRebotes = new TextBox();
                this.Controls.Add(txtRebotes);
                txtRebotes.Location = new Point(260, 360);

                Label lblPelRec = new Label();
                this.Controls.Add(lblPelRec);
                lblPelRec.Location = new Point(90, 400);
                lblPelRec.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblPelRec.AutoSize = true;
                lblPelRec.TextAlign = ContentAlignment.MiddleCenter;
                lblPelRec.Text = "Pelotas recuperadas";
                lblPelRec.Show();

                TextBox txtPelRec = new TextBox();
                this.Controls.Add(txtPelRec);
                txtPelRec.Location = new Point(260, 400);

                Label lblAmon = new Label();
                this.Controls.Add(lblAmon);
                lblAmon.Location = new Point(90, 440);
                lblAmon.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblAmon.AutoSize = true;
                lblAmon.TextAlign = ContentAlignment.MiddleCenter;
                lblAmon.Text = "Amonestaciones";
                lblAmon.Show();

                TextBox txtAmon = new TextBox();
                this.Controls.Add(txtAmon);
                txtAmon.Location = new Point(260, 440);
            }
            if (Convert.ToString(ds.Tables["Perfil"].Rows[1][0]) == "2")
            {
                Label lblGoles = new Label();
                this.Controls.Add(lblGoles);
                lblGoles.Location = new Point(90, 120);
                lblGoles.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblGoles.AutoSize = true;
                lblGoles.TextAlign = ContentAlignment.MiddleCenter;
                lblGoles.Text = "Goles";
                lblGoles.Show();

                TextBox txtGoles = new TextBox();
                this.Controls.Add(txtGoles);
                txtGoles.Location = new Point(260, 120);

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
                txtAsistencias.Location = new Point(260, 160);

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
                txtFaltas.Location = new Point(260, 200);

                Label lblMinJug = new Label();
                this.Controls.Add(lblMinJug);
                lblMinJug.Location = new Point(90, 240);
                lblMinJug.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblMinJug.AutoSize = true;
                lblMinJug.TextAlign = ContentAlignment.MiddleCenter;
                lblMinJug.Text = "Minutos jugados";
                lblMinJug.Show();

                TextBox txtMinJug = new TextBox();
                this.Controls.Add(txtMinJug);
                txtMinJug.Location = new Point(260, 240);

                Label lblTirosFal = new Label();
                this.Controls.Add(lblTirosFal);
                lblTirosFal.Location = new Point(90, 280);
                lblTirosFal.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblTirosFal.AutoSize = true;
                lblTirosFal.TextAlign = ContentAlignment.MiddleCenter;
                lblTirosFal.Text = "Tiros fallados";
                lblTirosFal.Show();

                TextBox txtTirosFal = new TextBox();
                this.Controls.Add(txtTirosFal);
                txtTirosFal.Location = new Point(260, 280);

                Label lblTirosArco = new Label();
                this.Controls.Add(lblTirosArco);
                lblTirosArco.Location = new Point(90, 320);
                lblTirosArco.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblTirosArco.AutoSize = true;
                lblTirosArco.TextAlign = ContentAlignment.MiddleCenter;
                lblTirosArco.Text = "Tiros al arco";
                lblTirosArco.Show();

                TextBox txtTirosArco = new TextBox();
                this.Controls.Add(txtTirosArco);
                txtTirosArco.Location = new Point(260, 320);

                Label lblRebotes = new Label();
                this.Controls.Add(lblRebotes);
                lblRebotes.Location = new Point(90, 360);
                lblRebotes.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblRebotes.AutoSize = true;
                lblRebotes.TextAlign = ContentAlignment.MiddleCenter;
                lblRebotes.Text = "Rebotes";
                lblRebotes.Show();

                TextBox txtRebotes = new TextBox();
                this.Controls.Add(txtRebotes);
                txtRebotes.Location = new Point(260, 360);

                Label lblPelRec = new Label();
                this.Controls.Add(lblPelRec);
                lblPelRec.Location = new Point(90, 400);
                lblPelRec.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblPelRec.AutoSize = true;
                lblPelRec.TextAlign = ContentAlignment.MiddleCenter;
                lblPelRec.Text = "Pelotas recuperadas";
                lblPelRec.Show();

                TextBox txtPelRec = new TextBox();
                this.Controls.Add(txtPelRec);
                txtPelRec.Location = new Point(260, 400);

                Label lblAmon = new Label();
                this.Controls.Add(lblAmon);
                lblAmon.Location = new Point(90, 440);
                lblAmon.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblAmon.AutoSize = true;
                lblAmon.TextAlign = ContentAlignment.MiddleCenter;
                lblAmon.Text = "Amonestaciones";
                lblAmon.Show();

                TextBox txtAmon = new TextBox();
                this.Controls.Add(txtAmon);
                txtAmon.Location = new Point(260, 440);
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
