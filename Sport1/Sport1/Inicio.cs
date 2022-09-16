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
        OleDbConnection BaseDeDatosProyecto = new OleDbConnection;
        
        SqlCommand command;
        SqlDataReader dataReader;
        String sql, Output = "";
        BaseDeDatosProyecto.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\47575158\\Desktop\\Proyecto\\sport\\Sport1-DB.accdb";


        public void pasarDatos (string hola)
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
            sql = "Select IdCrear, Nombre from Crear";
            command = new SqlCommand(sql, BaseDeDatosProyecto);

        }
    }
}
