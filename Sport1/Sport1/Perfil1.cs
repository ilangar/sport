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
        public Objetivos formObj;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        int lbl = 0;
        int txt = 0;
        int lblEst = 0;
        int posLblX = 60;
        int posLblY = 200;
        int posEstLblX = 320;
        int posEstLblY = 200;
        int x = 0;
        int car = 0;
        int puntos, asist, faltas, minJug, tirFal, bloq, rebotes, pelRec, amon = 0;
        string[] arrBask = new string[9] { "Puntos", "Asistencias", "Faltas", "Minutos Jugados", "Tiros fallados", "Bloqueos", "Rebotes", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrFut = new string[8] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Tiros al arco", "Tiros fallados", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrHand = new string[9] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Amonestaciones", "Excluciones", "Pelotas perdidas", "Tiros fallados", "Pelotas recuperadas" };
        string[] arrHock = new string[10] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Pelotas perdidas", "Tiros fallados", "Pelotas recuperadas", "Tarjetas verdes", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrRugby = new string[9] { "Tries", "Tackles", "Minutos jugados", "Lines ganados", "Pelotas perdidas", "Conversiones", "Pelotas recuperadas", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrTenis = new string[6] { "Aces", "Errores no forzados", "Faltas", "Doble faltas", "Winners", "Quiebres" };
        string[] arrVoley = new string[7] { "Aces", "Errores no forzados", "Remates logrados", "Saques errados", "Recepciones", "Armados", "Bloqueos" };
        int[] estBask = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] estFut = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0, };
        int[] estHand = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] estHockey = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] estRugby = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] estTenis = new int[6] { 0, 0, 0, 0, 0, 0 };
        int[] estVoley= new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        public void lblBasket()
        {
            while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
            {                
                estBask[lblEst % estBask.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][0]);
                lblEst++;
            }
            while (lbl < 9)
            {

                Label lblBasket = new Label();
                this.Controls.Add(lblBasket);
                lblBasket.Location = new Point(posLblX, posLblY);
                lblBasket.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblBasket.AutoSize = true;
                lblBasket.TextAlign = ContentAlignment.MiddleCenter;
                lblBasket.Text = arrBask[lbl];

                posLblY += 50;

                Label lblEstBasket = new Label();
                this.Controls.Add(lblEstBasket);
                lblEstBasket.Location = new Point(posEstLblX, posEstLblY);
                lblEstBasket.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblEstBasket.AutoSize = true;
                lblEstBasket.TextAlign = ContentAlignment.MiddleCenter;
                lblEstBasket.Text = Convert.ToString(estBask[lbl]);
                lbl++;
                posEstLblY += 50;
            }

        }



        public void lblFutbol()
        {
            while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
            {
                estFut[lblEst % estFut.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][0]);
                lblEst++;
            }
            while (lbl < 8)
            {
                Label lblFutbol = new Label();
                this.Controls.Add(lblFutbol);
                lblFutbol.Location = new Point(posLblX, posLblY);
                lblFutbol.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblFutbol.AutoSize = true;
                lblFutbol.TextAlign = ContentAlignment.MiddleCenter;
                lblFutbol.Text = arrFut[lbl];
                posLblY += 40;
                Label lblEstFutbol = new Label();
                this.Controls.Add(lblEstFutbol);
                lblEstFutbol.Location = new Point(posEstLblX, posEstLblY);
                lblEstFutbol.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblEstFutbol.AutoSize = true;
                lblEstFutbol.TextAlign = ContentAlignment.MiddleCenter;
                lblEstFutbol.Text = Convert.ToString(estFut[lbl]);
                lbl++;
                posEstLblY += 40;
            }
        }


        public void lblHandball()
        {
            while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
            {
                estHand[lblEst % estHand.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][0]);
                lblEst++;
            }
            while (lbl < 9)
            {
                Label lblHandball = new Label();
                this.Controls.Add(lblHandball);
                lblHandball.Location = new Point(posLblX, posLblY);
                lblHandball.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblHandball.AutoSize = true;
                lblHandball.TextAlign = ContentAlignment.MiddleCenter;
                lblHandball.Text = arrHand[lbl];
                posLblY += 40;
                Label lblEstHand = new Label();
                this.Controls.Add(lblEstHand);
                lblEstHand.Location = new Point(posEstLblX, posEstLblY);
                lblEstHand.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblEstHand.AutoSize = true;
                lblEstHand.TextAlign = ContentAlignment.MiddleCenter;
                lblEstHand.Text = Convert.ToString(estHand[lbl]);
                lbl++;
                posEstLblY += 40;
            }
        }

        public void lblHockey()
        {
            while (lbl < 10)
            {
                while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
                {
                    estHockey[lblEst % estHockey.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][0]);
                    lblEst++;
                }
                Label lblHockey = new Label();
                this.Controls.Add(lblHockey);
                lblHockey.Location = new Point(posLblX, posLblY);
                lblHockey.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblHockey.AutoSize = true;
                lblHockey.TextAlign = ContentAlignment.MiddleCenter;
                lblHockey.Text = arrHock[lbl];
                posLblY += 40;
                Label lblEstHockey = new Label();
                this.Controls.Add(lblEstHockey);
                lblEstHockey.Location = new Point(posEstLblX, posEstLblY);
                lblEstHockey.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblEstHockey.AutoSize = true;
                lblEstHockey.TextAlign = ContentAlignment.MiddleCenter;
                lblEstHockey.Text = Convert.ToString(estHockey[lbl]);
                lbl++;
                posEstLblY += 40;
            }
        }


        public void lblRugby()
        {
            while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
            {
                estRugby[lblEst % estRugby.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][0]);
                lblEst++;
            }
            while (lbl < 9)
            {
                Label lblRugby = new Label();
                this.Controls.Add(lblRugby);
                lblRugby.Location = new Point(posLblX, posLblY);
                lblRugby.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblRugby.AutoSize = true;
                lblRugby.TextAlign = ContentAlignment.MiddleCenter;
                lblRugby.Text = arrRugby[lbl];
                posLblY += 40;
                Label lblEstRugby = new Label();
                this.Controls.Add(lblEstRugby);
                lblEstRugby.Location = new Point(posEstLblX, posEstLblY);
                lblEstRugby.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblEstRugby.AutoSize = true;
                lblEstRugby.TextAlign = ContentAlignment.MiddleCenter;
                lblEstRugby.Text = Convert.ToString(estRugby[lbl]);
                lbl++;
                posEstLblY += 40;
            }
        }

        public void lblTenis()
        {
            while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
            {
                estTenis[lblEst % estTenis.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][0]);
                lblEst++;
            }
            while (lbl < 6)
            {
                Label lblTenis = new Label();
                this.Controls.Add(lblTenis);
                lblTenis.Location = new Point(posLblX, posLblY);
                lblTenis.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblTenis.AutoSize = true;
                lblTenis.TextAlign = ContentAlignment.MiddleCenter;
                lblTenis.Text = arrTenis[lbl];
                posLblY += 40;
                Label lblEstTenis = new Label();
                this.Controls.Add(lblEstTenis);
                lblEstTenis.Location = new Point(posEstLblX, posEstLblY);
                lblEstTenis.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblEstTenis.AutoSize = true;
                lblEstTenis.TextAlign = ContentAlignment.MiddleCenter;
                lblEstTenis.Text = Convert.ToString(estTenis[lbl]);
                lbl++;
                posEstLblY += 40;
            }
        }

        public void lblVoley()
        {
            while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
            {
                estVoley[lblEst % estVoley.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][0]);
                lblEst++;
            }
            while (lbl < 7)
            {
                Label lblVoley = new Label();
                this.Controls.Add(lblVoley);
                lblVoley.Location = new Point(posLblX, posLblY);
                lblVoley.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblVoley.AutoSize = true;
                lblVoley.TextAlign = ContentAlignment.MiddleCenter;
                lblVoley.Text = arrVoley[lbl];
                posLblY += 40;
                Label lblEstVoley = new Label();
                this.Controls.Add(lblEstVoley);
                lblEstVoley.Location = new Point(posEstLblX, posEstLblY);
                lblEstVoley.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblEstVoley.AutoSize = true;
                lblEstVoley.TextAlign = ContentAlignment.MiddleCenter;
                lblEstVoley.Text = Convert.ToString(estVoley[lbl]);
                lbl++;
                posEstLblY += 40;
            }
        }

        private void EliminarPerfil_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("¿Estás seguro que quieres eliminar este perfil?", "Confirmar", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                OleDbCommand command = new OleDbCommand();
                OleDbCommand command2 = new OleDbCommand();

                if (Program.jugador == true)
                {
                    connection.Open();
                    command.Connection = connection;
                    command2.Connection = connection;
                    command.CommandText = "DELETE FROM JugadorEquipo WHERE Nombre = ('" + Program.idPerfil + "')";
                    command2.CommandText = "DELETE FROM IngresarEstadisticas WHERE Per = ('" + Program.idPerfil + "')";
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connection.Close();

                    formPerfilEnt = new perfilEnt();
                    this.Hide();
                }
                if (!Program.jugador)
                {
                    connection.Open();
                    command.Connection = connection;
                    command2.Connection = connection;
                    command.CommandText = "DELETE FROM Perfil WHERE IdUser = (" + Program.idUser + ")";
                    command2.CommandText = "DELETE FROM IngresarEstadisticas WHERE Per = ('" + Program.idPerfil + "')";
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    connection.Close();
                }

                MessageBox.Show("Se eliminó este perfil");
                formInicio = new Inicio();
                this.Hide();
                formInicio.Show();
            }

        }

        private void LblNomUser_Click(object sender, EventArgs e)
        {

        }

        public Perfil1()
        {
            InitializeComponent();
        }

        private void Perfil1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            lblNomUser.Text = Program.idPerfil;
            connection.Open();
            OleDbCommand info;
            OleDbCommand info2;
            OleDbCommand info3;
            info = new OleDbCommand("SELECT Deporte FROM Perfil WHERE Nombre = '" + Program.idPerfil + "'", connection);
            info2 = new OleDbCommand("SELECT Estd, IdCar FROM IngresarEstadisticas WHERE Per = '" + Program.idPerfil + "'" , connection);
            info3 = new OleDbCommand("SELECT Deporte FROM JugadorEquipo WHERE Nombre = '" + Program.idPerfil + "'", connection);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            OleDbDataAdapter da3 = new OleDbDataAdapter(info3);
            da.Fill(ds, "Perfil");
            da2.Fill(ds2, "IngresarEstadisticas");
            da3.Fill(ds3, "JugadorEquipo");
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
            if (Convert.ToInt32(ds3.Tables["JugadorEquipo"].Rows.Count) > 0)
            {
                switch (Convert.ToString(ds3.Tables["JugadorEquipo"].Rows[0][0]))
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
            connection.Close();
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
            Objetivos formObj = new Objetivos();
            formObj.Show();
            this.Hide();
        }
    }
}
