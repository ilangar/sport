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
        int k = 0;
        int pos = 38;
        //public string idPerfil;

        public perfilEnt()
        {
            InitializeComponent();
        }

        private void click_btn_jugador(object sender, EventArgs e)
        {
            Program.idPerfil = ((Button)sender).Text;
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
            /*connection.Open();
            OleDbCommand info;
            info = new OleDbCommand("Select IdUser, Nombre FROM Entrenador", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            da.Fill(ds, "Entrenador");
            
            for (int i = 0; i < ds.Tables["Entrenador"].Rows.Count; i++)
            {
                while (k < 6 && k < ds.Tables["Entrenador"].Rows.Count)
                {
                    Button btnJugador = new Button();
                    btnJugador.DialogResult = DialogResult.OK;
                    btnJugador.Text = Convert.ToString(ds.Tables["Entrenador"].Rows[k][1]);
                    btnJugador.Location = new Point(24, pos);
                    pos += 100;
                    btnJugador.Size = new Size(160, 70);
                    btnJugador.Click += new System.EventHandler(this.click_btn_jugador);
                    Controls.Add(btnPerfil1);
                    k++;

                }
                pos = 38;
            

                while (k >= 6 && k < ds.Tables["Entrenador"].Rows.Count)
                {

                    Button btnJugador = new Button();
                    btnJugador.DialogResult = DialogResult.OK;
                    btnJugador.Text = Convert.ToString(ds.Tables["Entrenador"].Rows[k][1]);
                    btnJugador.Location = new Point(240, pos);
                    pos += 100;
                    btnJugador.Size = new Size(160, 70);
                    btnJugador.Click += new System.EventHandler(this.click_btn_jugador);
                    Controls.Add(btnJugador);
                    k++;

                }
                
            }*/
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
    }
}
