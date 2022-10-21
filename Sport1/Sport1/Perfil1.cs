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
    public partial class Perfil1 : Form
    {
        public CrearPerfil1 formCrearPerfil1;
        public Inicio formInicio;
        public IngresarEstadisticas formIngrEst;
        public perfilEnt formPerfilEnt;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        DataSet ds = new DataSet();
        int lbl = 0;
        int txt = 0;
        int posLblX = 30;
        int posLblY = 70;
        public Perfil1()
        {
            InitializeComponent();
        }

        private void Perfil1_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand info;
            info = new OleDbCommand("Select Deporte FROM Perfil WHERE Nombre ='" + formInicio.idPerfil + "'", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            da.Fill(ds, "Perfil");
            /*switch (Convert.ToString(ds.Tables["Perfil"].Rows[0][0]))
            {
                case "1":
                    formIngrEst.lblBasket();
                    break;
                case "2":
                    formIngrEst.lblFutbol();
                    break;
                case "3":
                    formIngrEst.lblHandball();
                    break;
                case "4":
                    formIngrEst.lblHockey();
                    break;
                case "5":
                    formIngrEst.lblRugby();
                    break;
                case "6":
                    formIngrEst.lblTenis();
                    break;
                case "7":
                    formIngrEst.lblVoley();
                    break;
            }*/
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
    }
}
