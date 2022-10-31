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
using System.Windows.Forms.DataVisualization.Charting;

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
            chartProgresos.Series.Add("Minutos jugados");
            chartProgresos.Series.Add("Tiros fallados");
            chartProgresos.Series.Add("Bloqueos");
            chartProgresos.Series.Add("Rebotes");
            chartProgresos.Series.Add("Pelotas recuperadas");
            chartProgresos.Series.Add("Amonestaciones");
            chartProgresos.Series["Puntos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Asistencias"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Faltas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Minutos jugados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tiros fallados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Bloqueos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Rebotes"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Pelotas recuperadas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Amonestaciones"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Puntos"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Asistencias"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Faltas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Minutos jugados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tiros fallados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Bloqueos"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Rebotes"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Pelotas recuperadas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Amonestaciones"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows[prog][0])));
                prog++;
            }
            prog = 0;

            while (prog < estdProgresos.Count)
            {
                switch(x)
                {
                    case 0: chartProgresos.Series["Puntos"].Points.AddXY(Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2]), estdProgresos[prog]);
                        break;
                    case 1: chartProgresos.Series["Asistencias"].Points.AddXY(Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2]), estdProgresos[prog]);
                        break;
                    case 2: chartProgresos.Series["Faltas"].Points.AddXY(Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2]), estdProgresos[prog]);
                        break;
                    case 3: chartProgresos.Series["Minutos jugados"].Points.AddXY(Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2]), estdProgresos[prog]); 
                        break;
                    case 4: chartProgresos.Series["Tiros fallados"].Points.AddXY(Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2]), estdProgresos[prog]); ;
                        break;
                    case 5: chartProgresos.Series["Bloqueos"].Points.AddXY(Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2]), estdProgresos[prog]); ;
                        break;
                    case 6: chartProgresos.Series["Rebotes"].Points.AddXY(Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2]), estdProgresos[prog]); ;
                        break;
                    case 7: chartProgresos.Series["Pelotas recuperadas"].Points.AddXY(Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2]), estdProgresos[prog]); ;
                        break;
                    case 8: chartProgresos.Series["Amonestaciones"].Points.AddXY(Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2]), estdProgresos[prog]); ;
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

        public void progresosFutbol()
        {
            chartProgresos.Series.Add("Goles");
            chartProgresos.Series.Add("Asistencias");
            chartProgresos.Series.Add("Faltas");
            chartProgresos.Series.Add("Minutos Jugados");
            chartProgresos.Series.Add("Tiros al arco");
            chartProgresos.Series.Add("Tiros fallados");
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
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Goles"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 1:
                        chartProgresos.Series["Faltas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 2:
                        chartProgresos.Series["Minutos Jugados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 3:
                        chartProgresos.Series["Tiros al arco"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 4:
                        chartProgresos.Series["Tiros fallados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 5:
                        chartProgresos.Series["Pelotas recuperadas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 6:
                        chartProgresos.Series["Rebotes"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 7:
                        chartProgresos.Series["Amonestaciones"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;

                }
                x++;
                prog++;
                if (x == 8)
                {
                    x = 0;
                }
            }
        }

        public void progresosHandball()
        {
            chartProgresos.Series.Add("Goles");
            chartProgresos.Series.Add("Asistencias");
            chartProgresos.Series.Add("Faltas");
            chartProgresos.Series.Add("Minutos Jugados");
            chartProgresos.Series.Add("Amonestaciones");
            chartProgresos.Series.Add("Exclusiones");
            chartProgresos.Series.Add("Pelotas perdidas");
            chartProgresos.Series.Add("Tiros fallados");
            chartProgresos.Series.Add("Pelotas recuperadas");
            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][prog])));
                prog++;
            }
            prog = 0;
            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Goles"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 1:
                        chartProgresos.Series["Asistencias"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 2:
                        chartProgresos.Series["Faltas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 3:
                        chartProgresos.Series["Minutos jugados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 4:
                        chartProgresos.Series["Amonestaciones"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 5:
                        chartProgresos.Series["Exclusiones"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 6:
                        chartProgresos.Series["Pelotas perdidas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 7:
                        chartProgresos.Series["Tiros fallados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 8:
                        chartProgresos.Series["Pelotas recuperadas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;

                }
                x++;
                prog++;
                if (x == 9)
                {
                    x = 0;
                }
            }
        }
        public void progresosHockey()
        {
            chartProgresos.Series.Add("Goles");
           // chartProgresos.Series["Goles"].ChartType = chartProgresos.ChartType.Line;
            chartProgresos.Series.Add("Asistencias");
            chartProgresos.Series.Add("Faltas");
            chartProgresos.Series.Add("Minutos Jugados");
            chartProgresos.Series.Add("Amonestaciones");
            chartProgresos.Series.Add("Exclusiones");
            chartProgresos.Series.Add("Pelotas perdidas");
            chartProgresos.Series.Add("Tiros fallados");
            chartProgresos.Series.Add("Pelotas recuperadas");
            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][prog])));
                prog++;
            }
            prog = 0;
            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Goles"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 1:
                        chartProgresos.Series["Asistencias"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 2:
                        chartProgresos.Series["Faltas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 3:
                        chartProgresos.Series["Minutos jugados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 4:
                        chartProgresos.Series["Pelotas perdidas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 5:
                        chartProgresos.Series["Tirros fallados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 6:
                        chartProgresos.Series["Pelotas recuperadas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 7:
                        chartProgresos.Series["Tarjetas verdes"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 8:
                        chartProgresos.Series["Tarjetas amarillas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 9:
                        chartProgresos.Series["Tarjetas rojas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;

                }
                x++;
                prog++;
                if (x == 10)
                {
                    x = 0;
                }
            }
        }
        public void progresosRugby()
        {
            chartProgresos.Series.Add("Tries");
            chartProgresos.Series.Add("Tackles");
            chartProgresos.Series.Add("Minutos jugados");
            chartProgresos.Series.Add("Lines ganados");
            chartProgresos.Series.Add("Pelotas perdidas");
            chartProgresos.Series.Add("Conversiones");
            chartProgresos.Series.Add("Pelotas recuperadas");
            chartProgresos.Series.Add("Tiros fallados");
            chartProgresos.Series.Add("Pelotas recuperadas");
            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][prog])));
                prog++;
            }
            prog = 0;
            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Tries"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 1:
                        chartProgresos.Series["Tackles"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 2:
                        chartProgresos.Series["Minutos jugados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 3:
                        chartProgresos.Series["Lines ganados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 4:
                        chartProgresos.Series["Pelotas perdidas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 5:
                        chartProgresos.Series["Conversiones"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 6:
                        chartProgresos.Series["Pelotas recuperadas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 7:
                        chartProgresos.Series["Tiros fallados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 8:
                        chartProgresos.Series["Pelotas recuperadas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;

                }
                x++;
                prog++;
                if (x == 9)
                {
                    x = 0;
                }

            }
        }
        public void progresosTenis()
        {
            chartProgresos.Series.Add("Aces");
            chartProgresos.Series.Add("Errores no forzados");
            chartProgresos.Series.Add("Faltas");
            chartProgresos.Series.Add("Doble faltas");
            chartProgresos.Series.Add("Winners");
            chartProgresos.Series.Add("Quiebres");
            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][prog])));
                prog++;
            }
            prog = 0;
            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Aces"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 1:
                        chartProgresos.Series["Errores no forzados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 2:
                        chartProgresos.Series["Faltas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 3:
                        chartProgresos.Series["Doble faltas"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 4:
                        chartProgresos.Series["Winners"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 5:
                        chartProgresos.Series["Quiebres"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                }
                x++;
                prog++;
                if (x == 6)
                {
                    x = 0;
                }
            }
        }
        public void progresosVoley()
        {
            chartProgresos.Series.Add("Aces");
            chartProgresos.Series.Add("Errores no forzados");
            chartProgresos.Series.Add("Remates logrados");
            chartProgresos.Series.Add("Saques errados");
            chartProgresos.Series.Add("Recepciones");
            chartProgresos.Series.Add("Armados");
            chartProgresos.Series.Add("Bloqueos");
            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["Estadisticas"].Rows[0][prog])));
                prog++;
            }
            prog = 0;
            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Aces"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 1:
                        chartProgresos.Series["Errores no forzados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 2:
                        chartProgresos.Series["Remates logrados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 3:
                        chartProgresos.Series["Saques errados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 4:
                        chartProgresos.Series["Recepciones"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 5:
                        chartProgresos.Series["Armados"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                    case 6:
                        chartProgresos.Series["Bloqueos"].Points.AddXY(estdProgresos[prog], Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[2][prog]));
                        break;
                }
                x++;
                prog++;
                if (x == 6)
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
            info = new OleDbCommand("Select Estd, IdCar, Fecha FROM IngresarEstadisticas WHERE User ='" + Convert.ToString(Program.idPerfil) + "'", connection);
            info2 = new OleDbCommand("Select Deporte FROM Perfil WHERE Nombre = '" + Program.idPerfil + "'", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            MessageBox.Show(Program.idPerfil);
            da.Fill(ds, "IngresarEstadisticas");
            da2.Fill(ds2, "Perfil");

            switch ((Convert.ToString(ds2.Tables["Perfil"].Rows[0][0])))
            {
                case "1": progresosBasket();
                    break;
                case "2": progresosFutbol();
                    break;
                case "3": progresosHandball();
                    break;
                case "4": progresosHockey();
                    break;
                case "5": progresosRugby();
                    break;
                case "6": progresosTenis();
                    break;
                case "7": progresosVoley();
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
