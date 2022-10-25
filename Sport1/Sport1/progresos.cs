using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Sport1
{
    public partial class progresos : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb");
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        public Inicio formInicio;
        public void progresosBasket()
        {
            int puntos = Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][0]));
            int asistencias = Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][1]));
            int faltas = Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][2]));
            int minJug = Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][3]));
            int tirosFal = Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][4]));
            int bloqueos = Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][5]));
            int rebotes = Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][6]));
            int pelRec = Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][7]));
            int amonestaciones = Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][8]));
        }
        public progresos()
        {
            InitializeComponent();
        }

        private void Progresos_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand info;
            OleDbCommand info2;
            info = new OleDbCommand("Select Estd FROM Estadisticas", connection);
            info2 = new OleDbCommand("Select Deporte  FROM Perfil WHERE Nombre = Ilan ", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            da.Fill(ds, "Estadisticas");
            da2.Fill(ds2, "Perfil");
            switch ((Convert.ToString(ds.Tables["Estadisticas"].Rows[0][0])))
            { 
            }
        


        }
    }
}
