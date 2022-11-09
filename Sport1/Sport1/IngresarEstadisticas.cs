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
    public partial class IngresarEstadisticas : Form
    {
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        int lbl = 0;
        int txt = 0;
        int posLblY = 120;
        int posLblX = 90;
        int posTxtY = 120;
        int posTxtX = 250;
        int nom = 0;
        int x = 0;
        int d = 0;
        int j = 0;
        string dia;
        string mes;
        string ano;
        string fecha;
        string prueba = "a";
        Perfil1 formPerfil1;
        perfilEnt formPerfilEnt;
        public Inicio formInicio;
        List<TextBox> listaTXTDeportes = new List<TextBox>();
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        string[] arrBaskId = new string[9] { "1", "2", "3", "4", "5", "6", "7", "10", "11" };
        string[] arrBask = new string[9] { "Puntos", "Asistencias", "Faltas", "Minutos Jugados", "Tiros fallados", "Bloqueos", "Rebotes", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrFut = new string[8] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Tiros al arco", "Tiros fallados", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrFutId = new string[8] { "2", "3", "4", "5", "8", "9", "10", "11" };
        string[] arrHand = new string[9] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Amonestaciones", "Excluciones", "Pelotas perdidas", "Tiros fallados", "Pelotas recuperadas" };
        string[] arrHandId = new string[9] { "8", "2", "3", "4", "11", "12", "13", "5","10"};
        string[] arrHock = new string[10] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Pelotas perdidas", "Tiros fallados", "Pelotas recuperadas", "Tarjetas verdes", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrHockId = new string[10] { "8", "2", "3", "4", "13", "5", "10", "14", "15", "16" };
        string[] arrRugby = new string[9] { "Tries", "Tackles", "Minutos jugados", "Lines ganados", "Pelotas perdidas", "Conversiones", "Pelotas recuperadas", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrRugbyId = new string[9] { "17", "18", "4", "19", "13", "20", "10", "15", "16" };
        string[] arrTenis = new string[6] { "Aces", "Errores no forzados", "Faltas", "Doble faltas", "Winners", "Quiebres"};
        string[] arrTenisId = new string[6] { "21", "22", "3", "23", "24", "25" };
        string[] arrVoley = new string[7] { "Aces", "Errores no forzados", "Remates logrados", "Saques errados", "Recepciones","Armados", "Bloqueos" };
        string[] arrVoleyId = new string[7] { "21", "22", "26", "27", "28", "29", "6"};
        public void lblBasket()
        {
            while (lbl < 9)
            {

                Label lblBasket = new Label();
                this.Controls.Add(lblBasket);
                lblBasket.Location = new Point(posLblX, posLblY);
                lblBasket.Font = new Font("Montserrat Alternate Medium", 16f);
                lblBasket.AutoSize = true;
                lblBasket.TextAlign = ContentAlignment.MiddleCenter;
                lblBasket.Text = arrBask [lbl];
                lbl++;
                posLblY += 40;
            }
        }


        public void txtBasket()
        {
            while (txt < 9)
            {
                TextBox txtBasket = new TextBox();
                listaTXTDeportes.Add(txtBasket);
                this.Controls.Add(txtBasket);
                txtBasket.Location = new Point(posTxtX, posTxtY);
                txtBasket.Tag = arrBaskId[txt];
                txt++;
                posTxtY += 40;
                
            }

        }
        public void lblFutbol()
        {
            while(lbl < 8)
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
        public void txtFutbol()
        {
            while (txt < 8)
            {
                TextBox txtFutbol = new TextBox();
                listaTXTDeportes.Add(txtFutbol);
                this.Controls.Add(txtFutbol);
                txtFutbol.Location = new Point(posTxtX, posTxtY);
                txtFutbol.Tag = arrFutId[txt];
                txt++;
                posTxtY += 40;
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
        public void txtHandball()
        {
            while (txt < 9)
            {
                TextBox txtHand = new TextBox();
                listaTXTDeportes.Add(txtHand);
                this.Controls.Add(txtHand);
                txtHand.Location = new Point(posTxtX, posTxtY);
                txtHand.Tag = arrHandId[txt];
                txt++;
                posTxtY += 40;
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
        public void txtHockey()
        {
            while (txt < 10)
            {
                TextBox txtHockey = new TextBox();
                listaTXTDeportes.Add(txtHockey);
                this.Controls.Add(txtHockey);
                txtHockey.Location = new Point(posTxtX, posTxtY);
                txtHockey.Tag = arrHockId[txt];
                txt++;
                posTxtY += 40;
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
        public void txtRugby()
        {
            while (txt < 9)
            {
                TextBox txtRugby = new TextBox();
                listaTXTDeportes.Add(txtRugby);
                this.Controls.Add(txtRugby);
                txtRugby.Location = new Point(posTxtX, posTxtY);
                txtRugby.Tag = arrRugbyId[txt];
                txt++;
                posTxtY += 40;
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
        public void txtTenis()
        {
            while (txt < 6) 
            {
                TextBox txtTenis = new TextBox();
                listaTXTDeportes.Add(txtTenis);
                this.Controls.Add(txtTenis);
                txtTenis.Location = new Point(posTxtX, posTxtY);
                txtTenis.Tag = arrTenisId[txt];
                txt++;
                posTxtY += 40;
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
        public void txtVoley()
        {
            while (txt < 7)
            {
                TextBox txtVoley = new TextBox();
                listaTXTDeportes.Add(txtVoley);
                this.Controls.Add(txtVoley);
                txtVoley.Location = new Point(posTxtX, posTxtY);
                txtVoley.Tag = arrVoleyId[txt];
                txt++;
                posTxtY += 40;
            }
        }

        public void dbBasket()
        {
            while (x < 9)
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO IngresarEstadisticas (Estd, IdCar, Per, Fecha) values (" + listaTXTDeportes[x].Text + ", " + listaTXTDeportes[x].Tag + ", '" + Program.idPerfil + "', '" + fecha + "')";
                command.ExecuteNonQuery();
                connection.Close();
                x++;
            }
        }
        public void dbFutbol()
        {
            x = 0;
            while (x < 8)
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "INSERT INTO IngresarEstadisticas (Estd, IdCar, Per, Fecha) values (" + listaTXTDeportes[x].Text + ", " + listaTXTDeportes[x].Tag + ", '" + Program.idPerfil + "', '" + fecha + "')";
                command.ExecuteNonQuery();
                connection.Close();
                x++;
            }
        }

        public IngresarEstadisticas()
        {
            InitializeComponent();
        }

        private void IngresarEstadisticas_Load(object sender, EventArgs e)
        {

            OleDbCommand info;
            OleDbCommand info2;
            info = new OleDbCommand("SELECT Deporte FROM Perfil WHERE Nombre = '" + Program.idPerfil + "'" , connection);
            info2 = new OleDbCommand("SELECT Deporte FROM JugadorEquipo Where Nombre = '" + Program.idPerfil + "'", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            da.Fill(ds, "Perfil");
            da2.Fill(ds2, "JugadorEquipo");
            if (Convert.ToInt32(ds.Tables["Perfil"].Rows.Count) > 0)
            {
                switch (Convert.ToString(ds.Tables["Perfil"].Rows[0][0]))
                {
                    case "1":
                        lblBasket(); txtBasket();
                        break;
                    case "2":
                        lblFutbol(); txtFutbol();
                        break;
                    case "3":
                        lblHandball(); txtHandball();
                        break;
                    case "4":
                        lblHockey(); txtHockey();
                        break;
                    case "5":
                        lblRugby(); txtRugby();
                        break;
                    case "6":
                        lblTenis(); txtTenis();
                        break;
                    case "7":
                        lblVoley(); txtVoley();
                        break;
                }
            }
            if (Convert.ToInt32(ds2.Tables["JugadorEquipo"].Rows.Count) > 0)
            {
                switch (Convert.ToString(ds2.Tables["JugadorEquipo"].Rows[0][0]))
                {
                    case "1":
                        lblBasket(); txtBasket();
                        break;
                    case "2":
                        lblFutbol(); txtFutbol();
                        break;
                    case "3":
                        lblHandball(); txtHandball();
                        break;
                    case "4":
                        lblHockey(); txtHockey();
                        break;
                    case "5":
                        lblRugby(); txtRugby();
                        break;
                    case "6":
                        lblTenis(); txtTenis();
                        break;
                    case "7":
                        lblVoley(); txtVoley();
                        break;
                }
            }
        }



        private void BtnIngresarBasket_Click(object sender, EventArgs e)
        {
            fecha = dia + "/" + mes + "/" + ano;
            if (Convert.ToInt32(ds.Tables["Perfil"].Rows.Count) > 0)
            {
                switch (Convert.ToString(ds.Tables["Perfil"].Rows[0][0]))
                {
                    case "1":
                        dbBasket();
                        break;
                    case "2":
                        dbFutbol();
                        break;
                }
                formPerfil1 = formInicio.formPerfil1;
                formPerfil1.Show();
                this.Hide();
            }
            if (Convert.ToInt32(ds2.Tables["JugadorEquipo"].Rows.Count) > 0)
            {
                switch (Convert.ToString(ds2.Tables["JugadorEquipo"].Rows[0][0]))
                {
                    case "1":
                        dbBasket();
                        break;
                    case "2":
                        dbFutbol();
                        break;
                }
                formPerfilEnt = new perfilEnt();
                formPerfilEnt.Show();
                this.Hide();
            }

        }

        private void CmbDiaBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            dia = cmbDiaBasket.Text;
        }

        private void CmbMesBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            mes = cmbMesBasket.Text;
        }

        private void CmbAñoBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            ano = cmbAñoBasket.Text;
        }
    }
}
