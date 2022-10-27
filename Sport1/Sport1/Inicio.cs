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
    public partial class Inicio : Form
    {
        int pos = 38;
        int cantPerfiles;
        string[] nombres = new string[1000];
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        int x = 0;
        int k = 0;
        public Perfil1 formPerfil1;
        public perfilEnt formPerfilEnt;
        public Inicio formInicio;
        public string caller = "";
        string nomPerfil;

        DataSet ds = new DataSet();
        public Form pasarFormInicio()
        {
            
            formInicio = this;
            return formInicio;
        }

        public string pasarIdPerfil()
        {
            return Program.idPerfil;
        }




        public void pasarDatos(string hola)
        {
            nombres[cantPerfiles] = hola;
            cantPerfiles++;
            Inicio_Load(null, null);
        }


        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnCrearPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearPerfil1 formCrearPerfil = new CrearPerfil1(caller);
            formCrearPerfil.formInicio = this;
            formCrearPerfil.Show();
        }

        private void click_btn_perfil(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Program.idPerfil = btn.Text;
             
            if ((Convert.ToInt32(ds.Tables["Perfil"].Rows[(Convert.ToInt32((btn.Tag)))][2])) == 2)
            {
                formPerfil1 = new Perfil1();
                formPerfil1.formInicio = this;
                formPerfil1.Show();
                this.Hide();
                
            }
            if ((Convert.ToInt32(ds.Tables["Perfil"].Rows[(Convert.ToInt32(((Button)sender).Tag))][2])) == 1)
            {
                formPerfilEnt = new perfilEnt();
                formPerfilEnt.Show();
                this.Hide();
                Program.idPerfil = formPerfilEnt.entIdPerfil();
            }
            

            connection.Close();


        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            connection.Open(); 

            OleDbCommand info;
            info = new OleDbCommand("Select IdUser, Nombre, Rol FROM Perfil", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);

            da.Fill(ds, "Perfil");


            for (int i = 0; i<ds.Tables["Perfil"].Rows.Count; i++)
            {
                while (k < 6 && k < ds.Tables["Perfil"].Rows.Count)
                {
                    Button btnPerfil1 = new Button();
                    btnPerfil1.DialogResult = DialogResult.OK;
                    btnPerfil1.Text = Convert.ToString(ds.Tables["Perfil"].Rows[k][1]);
                    btnPerfil1.Location = new Point(pos, 150);
                    pos += 100;
                    btnPerfil1.Size = new Size(160, 70);
                    btnPerfil1.Click += new System.EventHandler(this.click_btn_perfil);
                    btnPerfil1.Tag = x;
                    Controls.Add(btnPerfil1);
                    x++;
                    k++;
                }
                pos = 38;

                while (k >= 6 && k < 12 && k < ds.Tables["Perfil"].Rows.Count)
                {

                    Button btnPerfil1 = new Button();
                    btnPerfil1.DialogResult = DialogResult.OK;
                    btnPerfil1.Text = Convert.ToString(ds.Tables["Perfil"].Rows[k][1]);
                    btnPerfil1.Location = new Point(pos, 240);
                    pos += 3000;
                    btnPerfil1.Size = new Size(160, 70);
                    btnPerfil1.Click += new System.EventHandler(this.click_btn_perfil);
                    btnPerfil1.Tag = x;
                    Controls.Add(btnPerfil1);

                    x++;
                    k++;
                    
                }

                pos = 38;

                //while
            }




        }
    }
}
