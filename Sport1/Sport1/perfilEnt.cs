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
            connection.Open();
            MessageBox.Show("Select Nombre FROM JugadorEquipo WHERE IdUser = '" + Program.idUser + "'");
            OleDbCommand info; 
            info = new OleDbCommand("Select Nombre FROM JugadorEquipo WHERE IdUser = " + Program.idUser, connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            da.Fill(ds, "JugadorEquipo");
            
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
