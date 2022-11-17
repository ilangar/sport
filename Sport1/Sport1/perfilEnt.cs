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
    public partial class perfilEnt : Form
    {
        public string caller = "Nuevo jugador";
        public Inicio formInicio;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        int k = 0;
        int pos = 38;
        //public string idPerfil;
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
        int[] estVoley = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        int lbl = 0;
        int lblEst = 0;
        int posLblX = 60;
        int posLblY = 200;
        int posEstLblX = 320;
        int posEstLblY = 200;

        public void lblEnt()
        {

            switch (Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[0][8]))
            {
                case 1:
                    while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
                    {
                        estBask[lblEst % estBask.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][1]);
                        lblEst++;
                    }
                    while (lbl < 9)
                    {
                        Label lblDep = new Label();
                        this.Controls.Add(lblDep);
                        lblDep.Location = new Point(posLblX, posLblY);
                        lblDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblDep.AutoSize = true;
                        lblDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblDep.Text = arrBask[lbl];

                        posLblY += 50;

                        Label lblEstDep = new Label();
                        this.Controls.Add(lblEstDep);
                        lblEstDep.Location = new Point(posEstLblX, posEstLblY);
                        lblEstDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblEstDep.AutoSize = true;
                        lblEstDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblEstDep.Text = Convert.ToString(estBask[lbl]);
                        lbl++;
                        posEstLblY += 50;
                    }
                    break;
                case 2:
                    while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
                    {
                        estBask[lblEst % estFut.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][1]);
                        lblEst++;
                    }
                    while (lbl < 8)
                    {
                        Label lblDep = new Label();
                        this.Controls.Add(lblDep);
                        lblDep.Location = new Point(posLblX, posLblY);
                        lblDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblDep.AutoSize = true;
                        lblDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblDep.Text = arrFut[lbl];

                        posLblY += 50;

                        Label lblEstDep = new Label();
                        this.Controls.Add(lblEstDep);
                        lblEstDep.Location = new Point(posEstLblX, posEstLblY);
                        lblEstDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblEstDep.AutoSize = true;
                        lblEstDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblEstDep.Text = Convert.ToString(estFut[lbl]);
                        lbl++;
                        posEstLblY += 50;
                    }
                    break;
                case 3:
                    while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
                    {
                        estBask[lblEst % estHand.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][1]);
                        lblEst++;
                    }
                    while (lbl < 9)
                    {
                        Label lblDep = new Label();
                        this.Controls.Add(lblDep);
                        lblDep.Location = new Point(posLblX, posLblY);
                        lblDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblDep.AutoSize = true;
                        lblDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblDep.Text = arrHand[lbl];

                        posLblY += 50;

                        Label lblEstDep = new Label();
                        this.Controls.Add(lblEstDep);
                        lblEstDep.Location = new Point(posEstLblX, posEstLblY);
                        lblEstDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblEstDep.AutoSize = true;
                        lblEstDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblEstDep.Text = Convert.ToString(estHand[lbl]);
                        lbl++;
                        posEstLblY += 50;
                    }
                    break;
                case 4:
                    while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
                    {
                        estBask[lblEst % estHockey.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][1]);
                        lblEst++;
                    }
                    while (lbl < 10)
                    {
                        Label lblDep = new Label();
                        this.Controls.Add(lblDep);
                        lblDep.Location = new Point(posLblX, posLblY);
                        lblDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblDep.AutoSize = true;
                        lblDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblDep.Text = arrHock[lbl];

                        posLblY += 50;

                        Label lblEstDep = new Label();
                        this.Controls.Add(lblEstDep);
                        lblEstDep.Location = new Point(posEstLblX, posEstLblY);
                        lblEstDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblEstDep.AutoSize = true;
                        lblEstDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblEstDep.Text = Convert.ToString(estHockey[lbl]);
                        lbl++;
                        posEstLblY += 50;
                    }
                    break;
                case 5:
                    while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
                    {
                        estBask[lblEst % estRugby.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][1]);
                        lblEst++;
                    }
                    while (lbl < 9)
                    {
                        Label lblDep = new Label();
                        this.Controls.Add(lblDep);
                        lblDep.Location = new Point(posLblX, posLblY);
                        lblDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblDep.AutoSize = true;
                        lblDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblDep.Text = arrRugby[lbl];

                        posLblY += 50;

                        Label lblEstDep = new Label();
                        this.Controls.Add(lblEstDep);
                        lblEstDep.Location = new Point(posEstLblX, posEstLblY);
                        lblEstDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblEstDep.AutoSize = true;
                        lblEstDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblEstDep.Text = Convert.ToString(estRugby[lbl]);
                        lbl++;
                        posEstLblY += 50;
                    }
                    break;
                case 6:
                    while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
                    {
                        estBask[lblEst % estTenis.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][1]);
                        lblEst++;
                    }
                    while (lbl < 6)
                    {
                        Label lblDep = new Label();
                        this.Controls.Add(lblDep);
                        lblDep.Location = new Point(posLblX, posLblY);
                        lblDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblDep.AutoSize = true;
                        lblDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblDep.Text = arrTenis[lbl];

                        posLblY += 50;

                        Label lblEstDep = new Label();
                        this.Controls.Add(lblEstDep);
                        lblEstDep.Location = new Point(posEstLblX, posEstLblY);
                        lblEstDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblEstDep.AutoSize = true;
                        lblEstDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblEstDep.Text = Convert.ToString(estTenis[lbl]);
                        lbl++;
                        posEstLblY += 50;
                    }
                    break;
                case 7:
                    while (lblEst < ds2.Tables["IngresarEstadisticas"].Rows.Count)
                    {
                        estBask[lblEst % estVoley.Length] += Convert.ToInt32(ds2.Tables["IngresarEstadisticas"].Rows[lblEst][1]);
                        lblEst++;
                    }
                    while (lbl < 7)
                    {
                        Label lblDep = new Label();
                        this.Controls.Add(lblDep);
                        lblDep.Location = new Point(posLblX, posLblY);
                        lblDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblDep.AutoSize = true;
                        lblDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblDep.Text = arrVoley[lbl];

                        posLblY += 50;

                        Label lblEstDep = new Label();
                        this.Controls.Add(lblEstDep);
                        lblEstDep.Location = new Point(posEstLblX, posEstLblY);
                        lblEstDep.Font = new Font("Montserrat Alternate Medium", 13f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                        lblEstDep.AutoSize = true;
                        lblEstDep.TextAlign = ContentAlignment.MiddleCenter;
                        lblEstDep.Text = Convert.ToString(estVoley[lbl]);
                        lbl++;
                        posEstLblY += 50;
                    }
                    break;
            }
        }

        public perfilEnt()
        {
            InitializeComponent();
        }

        private void click_btn_jugador(object sender, EventArgs e)
        {
            Program.idJugador = Program.idPerfil;
            Program.idPerfil = ((Button)sender).Text;
            Program.jugador = true;
            Perfil1 formPerfil1 = new Perfil1();
            this.Hide();
            formPerfil1.Show();

        }
        public string entIdPerfil()
        {
            return Program.idPerfil;
        }
        private void PerfilEnt_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            connection.Open();
            OleDbCommand info;
            OleDbCommand info2;
            info = new OleDbCommand("Select Nombre FROM JugadorEquipo WHERE IdUser = " + Program.idUser, connection);
            info2 = new OleDbCommand("SELECT *  FROM IngresarEstadisticas INNER JOIN JugadorEquipo ON IngresarEstadisticas.Per = JugadorEquipo.Nombre WHERE JugadorEquipo.IdUser =" + Program.idUser, connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            da.Fill(ds, "JugadorEquipo");
            da2.Fill(ds2, "IngresarEstadisticas");
            
            for (int i = 0; i < ds.Tables["JugadorEquipo"].Rows.Count; i++)
            {
                while (k < ds.Tables["JugadorEquipo"].Rows.Count)
                {
                    Button btnJugador = new Button();
                    btnJugador.DialogResult = DialogResult.OK;
                    btnJugador.Text = Convert.ToString(ds.Tables["JugadorEquipo"].Rows[k][0]);
                    //btnJugador.Location = new Point(24, pos);
                    pos +=20;
                    //btnJugador.Size = new Size(160, 20);
                    btnJugador.Click += new System.EventHandler(this.click_btn_jugador);
                    Controls.Add(btnJugador);
                    flowLayoutJug.Controls.Add(btnJugador);
                    
                    k++;

                }

                
            }
            lblEnt();
        }

        private void BtnAgregarJug_Click(object sender, EventArgs e)
        {
            nuevoJug formNuevoJug = new nuevoJug();
            this.Hide();
            formNuevoJug.Show();
        }

        private void BtnVolverAtras_Click(object sender, EventArgs e)
        {
            formInicio = new Inicio();
            this.Hide();
            formInicio.Show();
        }

        private void EliminarPerfil_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("¿Estás seguro que quieres eliminar este perfil?", "Confirmar", MessageBoxButtons.YesNo);
            OleDbCommand command = new OleDbCommand();
            OleDbCommand command2 = new OleDbCommand();

            if (dr == DialogResult.Yes)
            {
                command.Connection = connection;
                command2.Connection = connection;
                command.CommandText = "DELETE FROM Perfil WHERE IdUser = (" + Program.idUser + ")";
                command2.CommandText = "DELETE FROM IngresarEstadisticas WHERE Per = ('" + Program.idPerfil + "')";
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                connection.Close(); 

                MessageBox.Show("Se eliminó este perfil");
                formInicio = new Inicio();
                this.Hide();
                formInicio.Show();
            }
        }
    }
}
