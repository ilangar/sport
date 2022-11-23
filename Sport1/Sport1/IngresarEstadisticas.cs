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
        int posLblY = 200;
        int posLblX = 60;
        int posTxtY = 200;
        int posTxtX = 220;
        int nom = 0;
        int x = 0;
        int d = 0;
        int j = 0;
        int p = 0;
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
        string[] arrHandId = new string[9] { "2", "3", "4", "5", "8", "10", "11", "12","13"};
        string[] arrHock = new string[10] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Pelotas perdidas", "Tiros fallados", "Pelotas recuperadas", "Tarjetas verdes", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrHockId = new string[10] { "2", "3", "4", "5", "8", "10", "13", "14", "15", "16" };
        string[] arrRugby = new string[9] { "Tries", "Tackles", "Minutos jugados", "Lines ganados", "Pelotas perdidas", "Conversiones", "Pelotas recuperadas", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrRugbyId = new string[9] { "4", "10", "13", "15", "16", "17", "18", "19", "20" };
        string[] arrTenis = new string[6] { "Aces", "Errores no forzados", "Faltas", "Doble faltas", "Winners", "Quiebres"};
        string[] arrTenisId = new string[6] {"3", "21", "22",  "23", "24", "25" };
        string[] arrVoley = new string[7] { "Aces", "Errores no forzados", "Remates logrados", "Saques errados", "Recepciones","Armados", "Bloqueos" };
        string[] arrVoleyId = new string[7] {"6", "21", "22", "26", "27", "28", "29" };
        public void lblBasket()
        {
            while (lbl < 9)
            {

                Label lblBasket = new Label();
                this.Controls.Add(lblBasket);
                lblBasket.Text = arrBask[lbl];
                tableLayoutPanelEst.Controls.Add(lblBasket);
                lblBasket.Font = new Font("Montserrat Alternate Medium", 16f);
                lblBasket.AutoSize = true;
                lblBasket.TextAlign = ContentAlignment.MiddleCenter;
                TextBox txtBasket = new TextBox();
                listaTXTDeportes.Add(txtBasket);
                this.Controls.Add(txtBasket);
                tableLayoutPanelEst.Controls.Add(txtBasket);
                txtBasket.Tag = arrBaskId[lbl];
                txtBasket.Font = new Font("Montserrat Alternate Medium", 16f);
                lbl++;
            }
        }


        public void lblFutbol()
        {
            while(lbl < 8)
            {
                Label lblFutbol = new Label();
                this.Controls.Add(lblFutbol);
                lblFutbol.Text = arrFut[lbl];
                tableLayoutPanelEst.Controls.Add(lblFutbol);
                lblFutbol.Font = new Font("Montserrat Alternate Medium", 16f);
                lblFutbol.AutoSize = true;
                lblFutbol.TextAlign = ContentAlignment.MiddleCenter;
                TextBox txtFutbol = new TextBox();
                listaTXTDeportes.Add(txtFutbol);
                this.Controls.Add(txtFutbol);
                tableLayoutPanelEst.Controls.Add(txtFutbol);
                txtFutbol.Tag = arrFutId[lbl];
                txtFutbol.Font = new Font("Montserrat Alternate Medium", 16f);
                lbl++;
            }
        }


        public void lblHandball()
        {
            while (lbl < 9)
            {
                Label lblHand = new Label();
                this.Controls.Add(lblHand);
                lblHand.Text = arrHand[lbl];
                tableLayoutPanelEst.Controls.Add(lblHand);
                lblHand.Font = new Font("Montserrat Alternate Medium", 16f);
                lblHand.AutoSize = true;
                lblHand.TextAlign = ContentAlignment.MiddleCenter;
                TextBox txtHand = new TextBox();
                listaTXTDeportes.Add(txtHand);
                this.Controls.Add(txtHand);
                tableLayoutPanelEst.Controls.Add(txtHand);
                txtHand.Tag = arrHandId[lbl];
                txtHand.Font = new Font("Montserrat Alternate Medium", 16f);
                lbl++;
            }
        }
        public void txtHandball()
        {
        }

        public void lblHockey()
        {
            while (lbl < 10)
            {
                Label lblHockey = new Label();
                this.Controls.Add(lblHockey);
                lblHockey.Text = arrHock[lbl];
                tableLayoutPanelEst.Controls.Add(lblHockey);
                lblHockey.Font = new Font("Montserrat Alternate Medium", 16f);
                lblHockey.AutoSize = true;
                lblHockey.TextAlign = ContentAlignment.MiddleCenter;
                TextBox txtHockey = new TextBox();
                listaTXTDeportes.Add(txtHockey);
                this.Controls.Add(txtHockey);
                tableLayoutPanelEst.Controls.Add(txtHockey);
                txtHockey.Tag = arrHockId[lbl];
                txtHockey.Font = new Font("Montserrat Alternate Medium", 16f);
                lbl++;

            }
        }
        public void txtHockey()
        {

        }

        public void lblRugby()
        {
            while (lbl < 9)
            {
                Label lblRugby = new Label();
                this.Controls.Add(lblRugby);
                lblRugby.Text = arrRugby[lbl];
                tableLayoutPanelEst.Controls.Add(lblRugby);
                lblRugby.Font = new Font("Montserrat Alternate Medium", 16f);
                lblRugby.AutoSize = true;
                lblRugby.TextAlign = ContentAlignment.MiddleCenter;
                TextBox txtRugby = new TextBox();
                listaTXTDeportes.Add(txtRugby);
                this.Controls.Add(txtRugby);
                tableLayoutPanelEst.Controls.Add(txtRugby);
                txtRugby.Tag = arrRugbyId[lbl];
                txtRugby.Font = new Font("Montserrat Alternate Medium", 16f);
                lbl++;
            }
        }
        public void txtRugby()
        {
 
        }

        public void lblTenis()
        {
            while (lbl < 6)
            {
                Label lblTenis = new Label();
                this.Controls.Add(lblTenis);
                lblTenis.Text = arrTenis[lbl];
                tableLayoutPanelEst.Controls.Add(lblTenis);
                lblTenis.Font = new Font("Montserrat Alternate Medium", 16f);
                lblTenis.AutoSize = true;
                lblTenis.TextAlign = ContentAlignment.MiddleCenter;
                TextBox txtTenis = new TextBox();
                listaTXTDeportes.Add(txtTenis);
                this.Controls.Add(txtTenis);
                tableLayoutPanelEst.Controls.Add(txtTenis);
                txtTenis.Tag = arrTenisId[lbl];
                txtTenis.Font = new Font("Montserrat Alternate Medium", 16f);
                lbl++;
            }
        }

        public void lblVoley()
        {
            while (lbl < 7)
            {
                Label lblVoley = new Label();
                this.Controls.Add(lblVoley);
                lblVoley.Text = arrVoley[lbl];
                tableLayoutPanelEst.Controls.Add(lblVoley);
                lblVoley.Font = new Font("Montserrat Alternate Medium", 16f);
                lblVoley.AutoSize = true;
                lblVoley.TextAlign = ContentAlignment.MiddleCenter;
                TextBox txtVoley = new TextBox();
                listaTXTDeportes.Add(txtVoley);
                this.Controls.Add(txtVoley);
                tableLayoutPanelEst.Controls.Add(txtVoley);
                txtVoley.Tag = arrVoleyId[lbl];
                txtVoley.Font = new Font("Montserrat Alternate Medium", 16f);
                lbl++;
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
        public void dbHandball()
        {
            x = 0;
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
        public void dbHock()
        {
            x = 0;
            while (x < 10)
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
        public void dbRugby()
        {
            x = 0;
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
        public void dbTenis()
        {
            x = 0;
            while (x < 6)
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
        public void dbVoley()
        {
            x = 0;
            while (x < 7)
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
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
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
            if (Convert.ToInt32(ds2.Tables["JugadorEquipo"].Rows.Count) > 0)
            {
                switch (Convert.ToString(ds2.Tables["JugadorEquipo"].Rows[0][0]))
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
                    case "3":
                        dbHandball();
                        break;
                    case "4":
                        dbHock();
                        break;
                    case "5":
                        dbRugby();
                        break;
                    case "6":
                        dbTenis();
                        break;
                    case "7":
                        dbVoley();
                        break;
                }
                formPerfil1 = new Perfil1();
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
                    case "3":
                        dbHandball();
                        break;
                    case "4":
                        dbHock();
                        break;
                    case "5":
                        dbRugby();
                        break;
                    case "6":
                        dbTenis();
                        break;
                    case "7":
                        dbVoley();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Perfil1 formPerfil1 = new Perfil1();
            this.Hide();
            formPerfil1.Show();
        }
    }
}
