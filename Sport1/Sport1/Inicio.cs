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
            CrearPerfil1 formCrearPerfil = new CrearPerfil1();
            formCrearPerfil.formInicio = this;
            formCrearPerfil.Show();
        }

        private void click_btn_perfil(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Perfil1 formPerfil1 = new Perfil1();
            formPerfil1.formInicio = this;
            formPerfil1.Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            connection.Open(); 




            OleDbCommand info;
            info = new OleDbCommand("Select IdCrear, Nombre FROM Crear", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            DataSet ds = new DataSet();
            da.Fill(ds, "Crear");

            for(int i = 1; i<ds.Tables["Crear"].Rows.Count; i++)
            {

            }
            
            //MessageBox.Show("id: "+ ds.Tables["Crear"].Rows[0][0]  + " texto: " + ds.Tables["Crear"].Rows[0][1]);


        }
    }
}
