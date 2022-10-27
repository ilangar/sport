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
        public Perfil1 formPerfil1;
        public Inicio formInicio;
        int prog = 0;
        int x = 0;
        string[] arrBask = new string[9] { "Puntos", "Asistencias", "Faltas", "Minutos Jugados", "Tiros fallados", "Bloqueos", "Rebotes", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrFut = new string[8] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Tiros al arco", "Tiros fallados", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrHand = new string[9] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Amonestaciones", "Excluciones", "Pelotas perdidas", "Tiros fallados", "Pelotas recuperadas" };
        string[] arrHock = new string[10] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Pelotas perdidas", "Tiros fallados", "Pelotas recuperadas", "Tarjetas verdes", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrRugby = new string[9] { "Tries", "Tackles", "Scrums ganados", "Lines ganados", "Pelotas perdidas", "Conversiones", "Pelotas recuperadas", "Tarjetas amarillas", "Tarjetas rojas" };
        string[] arrTenis = new string[6] { "Aces", "Errores no forzados", "Faltas", "Doble faltas", "Winners", "Quiebres" };
        string[] arrVoley = new string[7] { "Aces", "Errores no forzados", "Remates logrados", "Saques errados", "Recepciones", "Armados", "Bloqueos" };
        List<int> estdProgresos = new List<int>();
        public void progresosBasket()
        {
            chartProgresos.Series.Add("Puntos");
            chartProgresos.Series.Add("Asistencias");
            chartProgresos.Series.Add("Faltas");
            chartProgresos.Series.Add("Minutos Jugados");
            chartProgresos.Series.Add("Tiros fallados");
            chartProgresos.Series.Add("Bloqueos");
            chartProgresos.Series.Add("Rebotes");
            chartProgresos.Series.Add("Pelotas recuperadas");
            chartProgresos.Series.Add("Amonestaciones"); 
            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][prog])));
                prog++;
            }
            prog = 0;
            while (prog < estdProgresos.Count)
            {
                switch(x)
                {
                    case 0: chartProgresos.Series["Puntos"].Points.AddXY(estdProgresos[prog], x);
                        break;
                    case 1: chartProgresos.Series["Asistencias"].Points.AddXY(estdProgresos[prog], x);
                        break;
                    case 2: chartProgresos.Series["Faltas"].Points.AddXY(estdProgresos[prog], x);
                        break;
                    case 3: chartProgresos.Series["Minutos jugados"].Points.AddXY(estdProgresos[prog], x);
                        break;
                    case 4: chartProgresos.Series["Tiros fallados"].Points.AddXY(estdProgresos[prog], x);
                        break;
                    case 5: chartProgresos.Series["Bloqueos"].Points.AddXY(estdProgresos[prog], x);
                        break;
                    case 6: chartProgresos.Series["Rebotes"].Points.AddXY(estdProgresos[prog], x);
                        break;
                    case 7: chartProgresos.Series["Pelotas recuperadas"].Points.AddXY(estdProgresos[prog], x);
                        break;
                    case 8: chartProgresos.Series["Amonestaciones"].Points.AddXY(estdProgresos[prog], x);
                        break;

                }
                x++;
                prog++;
                if (x==9)
                {
                    x = 0;
                }
            }



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
            info = new OleDbCommand("Select Estd, IdCar, Fecha FROM IngresarEstadisticas WHERE User ='" + formInicio.pasarIdPerfil() + "'", connection);
            info2 = new OleDbCommand("Select Deporte FROM Perfil WHERE Nombre = '" + formInicio.pasarIdPerfil() + "'", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            da.Fill(ds, "IngresarEstadisticas");
            da2.Fill(ds2, "Perfil");
            MessageBox.Show(formInicio.pasarIdPerfil());
            switch ((Convert.ToString(ds2.Tables["Perfil"].Rows[0][0])))
            {
                case "1": MessageBox.Show("Ok");
                    break;
            }
        


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formPerfil1 = new Perfil1();
            formPerfil1.Show();
            this.Hide();
        }

        private void chartProgresos_Click(object sender, EventArgs e)
        {

        }
    }
}
