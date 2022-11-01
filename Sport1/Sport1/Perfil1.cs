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
using static System.Windows.Forms.LinkLabel;

namespace Sport1
{
    public partial class Perfil1 : Form
    {
        public CrearPerfil1 formCrearPerfil1;
        public Inicio formInicio = new Inicio();
        public IngresarEstadisticas formIngrEst = new IngresarEstadisticas();
        public perfilEnt formPerfilEnt;
        public progresos formProgresos;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        int lbl = 0;
        int txt = 0;
        int lblEst = 0;
        int posLblX = 30;
        int posLblY = 70;
        int posEstLblX = 250;
        int posEstLblY = 70;
        int puntos, asist, faltas, minJug, tirFal, bloq, rebotes, pelRec, amon = 0;
        string[] arrBask = new string[9] { "Puntos", "Asistencias", "Faltas", "Minutos Jugados", "Tiros fallados", "Bloqueos", "Rebotes", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrFut = new string[8] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Tiros al arco", "Tiros fallados", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrHand = new string[9] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Amonestaciones", "Excluciones", "Pelotas perdidas", "Tiros fallados", "Pelotas recuperadas" };
        string[] arrHock = new string[10] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Pelotas perdidas", "Tiros fallados", "Pelotas recuperadas", "Tarjetas verdes", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrRugby = new string[9] { "Tries", "Tackles", "Minutos jugados", "Lines ganados", "Pelotas perdidas", "Conversiones", "Pelotas recuperadas", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrTenis = new string[6] { "Aces", "Errores no forzados", "Faltas", "Doble faltas", "Winners", "Quiebres" };
        string[] arrVoley = new string[7] { "Aces", "Errores no forzados", "Remates logrados", "Saques errados", "Recepciones", "Armados", "Bloqueos" };
        public void lblBasket()
        {
            while (lbl < 9)
            {

                Label lblBasket = new Label();
                this.Controls.Add(lblBasket);
                lblBasket.Location = new Point(posLblX, posLblY);
                lblBasket.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblBasket.AutoSize = true;
                lblBasket.TextAlign = ContentAlignment.MiddleCenter;
                lblBasket.Text = arrBask[lbl];

                lbl++;
                posLblY += 40;
                posEstLblY += 40;
            }
            while (lblEst < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                Label lblEstBasket = new Label();
                this.Controls.Add(lblEstBasket);
                lblEstBasket.Location = new Point(posEstLblX, posEstLblY);
                lblEstBasket.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblEstBasket.AutoSize = true;
                lblEstBasket.TextAlign = ContentAlignment.MiddleCenter;
                { }
                if (ds2.Tables["IngresarEstadisticas"].Rows.Count > 0 && lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
                {
                    lblEstBasket.Text = Convert.ToString(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][0]);
                }
                else
                {
                    lblEstBasket.Text = "0";
                }

            }
        }


        
        public void lblFutbol()
        {
            while (lbl < 8)
            {
                Label lblFutbol = new Label();
                this.Controls.Add(lblFutbol);
                lblFutbol.Location = new Point(posLblX, posLblY);
                lblFutbol.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblFutbol.AutoSize = true;
                lblFutbol.TextAlign = ContentAlignment.MiddleCenter;
                lblFutbol.Text = arrFut[lbl];
                lbl++;
                posLblY += 40;
            }
        }


        public void lblHandball()
        {
            while (lbl < 9)
            {
                Label lblHandball = new Label();
                this.Controls.Add(lblHandball);
                lblHandball.Location = new Point(posLblX, posLblY);
                lblHandball.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblHandball.AutoSize = true;
                lblHandball.TextAlign = ContentAlignment.MiddleCenter;
                lblHandball.Text = arrHand[lbl];
                lbl++;
                posLblY += 40;
            }
        }

        public void lblHockey()
        {
            while (lbl < 10)
            {
                Label lblHockey = new Label();
                this.Controls.Add(lblHockey);
                lblHockey.Location = new Point(posLblX, posLblY);
                lblHockey.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblHockey.AutoSize = true;
                lblHockey.TextAlign = ContentAlignment.MiddleCenter;
                lblHockey.Text = arrHock[lbl];
                lbl++;
                posLblY += 40;
            }
        }


        public void lblRugby()
        {
            while (lbl < 9)
            {
                Label lblRugby = new Label();
                this.Controls.Add(lblRugby);
                lblRugby.Location = new Point(posLblX, posLblY);
                lblRugby.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblRugby.AutoSize = true;
                lblRugby.TextAlign = ContentAlignment.MiddleCenter;
                lblRugby.Text = arrRugby[lbl];
                lbl++;
                posLblY += 40;
            }
        }

        public void lblTenis()
        {
            while (lbl < 6)
            {
                Label lblTenis = new Label();
                this.Controls.Add(lblTenis);
                lblTenis.Location = new Point(posLblX, posLblY);
                lblTenis.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblTenis.AutoSize = true;
                lblTenis.TextAlign = ContentAlignment.MiddleCenter;
                lblTenis.Text = arrTenis[lbl];
                lbl++;
                posLblY += 40;
            }
        }

        public void lblVoley()
        {
            while (lbl < 7)
            {
                Label lblVoley = new Label();
                this.Controls.Add(lblVoley);
                lblVoley.Location = new Point(posLblX, posLblY);
                lblVoley.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblVoley.AutoSize = true;
                lblVoley.TextAlign = ContentAlignment.MiddleCenter;
                lblVoley.Text = arrVoley[lbl];
                lbl++;
                posLblY += 40;
            }
        }

        public Perfil1()
        {
            InitializeComponent();
        }

        private void Perfil1_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand info;
            OleDbCommand info2;
            info = new OleDbCommand("Select Deporte FROM Perfil WHERE Nombre = '" + Program.idPerfil + "'", connection);
            info2 = new OleDbCommand("Select Estd FROM IngresarEstadisticas WHERE Per = '" + Program.idPerfil + "'" , connection);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            da.Fill(ds, "Perfil");
            da2.Fill(ds2, "IngresarEstadisticas");
            switch (Convert.ToString(ds.Tables["Perfil"].Rows[0][0]))
            {
                case "1":
                    lblBasket();
                    break;
                case "2":
                    lblFutbol();
                    break;
                case "3":
                    lblHandball();
                    break;
                case "4":
                    lblHockey();
                    break;
                case "5":
                    lblRugby();
                    break;
                case "6":
                    lblTenis();
                    break;
                case "7":
                    lblVoley();
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            formInicio = new Inicio();
            formInicio.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void LblNomPerfil_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresarEstadisticas_Click(object sender, EventArgs e)
        {
            
            formIngrEst = new IngresarEstadisticas();
            formIngrEst.formInicio = formInicio;
            this.Hide();
            formIngrEst.Show();
        }

        private void BtnVerProgresos_Click(object sender, EventArgs e)
        {
            formProgresos = new progresos();
            this.Hide();
            formProgresos.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            objetivos f3 = new objetivos();
            f3.ShowDialog();
        }
    }
}
