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
            chartProgresos.Series["Puntos"].BorderWidth = 10;
            chartProgresos.Series["Asistencias"].BorderWidth = 10;
            chartProgresos.Series["Faltas"].BorderWidth = 10;
            chartProgresos.Series["Minutos jugados"].BorderWidth = 10;
            chartProgresos.Series["Tiros fallados"].BorderWidth = 10;
            chartProgresos.Series["Bloqueos"].BorderWidth = 10;
            chartProgresos.Series["Rebotes"].BorderWidth = 10;
            chartProgresos.Series["Pelotas recuperadas"].BorderWidth = 10;
            chartProgresos.Series["Amonestaciones"].BorderWidth = 10;

            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows[prog][0])));
                prog++;
            }
            prog = 0;

            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0: chartProgresos.Series["Puntos"].Points.AddXY((Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2])), estdProgresos[prog]);
                        break;
                    case 1: chartProgresos.Series["Asistencias"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 2: chartProgresos.Series["Faltas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 3: chartProgresos.Series["Minutos jugados"].Points.AddY(estdProgresos[prog]); 
                        break;
                    case 4: chartProgresos.Series["Tiros fallados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 5: chartProgresos.Series["Bloqueos"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 6: chartProgresos.Series["Rebotes"].Points.AddY(estdProgresos[prog]); 
                        break;
                    case 7: chartProgresos.Series["Pelotas recuperadas"].Points.AddY(estdProgresos[prog]); 
                        break;
                    case 8: chartProgresos.Series["Amonestaciones"].Points.AddY(estdProgresos[prog]);
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
            chartProgresos.Series.Add("Minutos jugados");
            chartProgresos.Series.Add("Tiros al arco");
            chartProgresos.Series.Add("Tiros fallados");
            chartProgresos.Series.Add("Pelotas recuperadas");
            chartProgresos.Series.Add("Amonestaciones");
            chartProgresos.Series["Goles"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Asistencias"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Faltas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Minutos jugados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tiros al arco"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tiros fallados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Pelotas recuperadas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Amonestaciones"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Goles"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Asistencias"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Faltas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Minutos jugados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tiros al arco"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tiros fallados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Pelotas recuperadas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Amonestaciones"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Goles"].BorderWidth = 10;
            chartProgresos.Series["Asistencias"].BorderWidth = 10;
            chartProgresos.Series["Faltas"].BorderWidth = 10;
            chartProgresos.Series["Minutos jugados"].BorderWidth = 10;
            chartProgresos.Series["Tiros al arco"].BorderWidth = 10;
            chartProgresos.Series["Tiros fallados"].BorderWidth = 10;
            chartProgresos.Series["Pelotas recuperadas"].BorderWidth = 10;
            chartProgresos.Series["Amonestaciones"].BorderWidth = 10;

            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows[prog][0])));
                prog++;
            }
            prog = 0;

            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Goles"].Points.AddXY((Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2])), estdProgresos[prog]);
                        break;
                    case 1:
                        chartProgresos.Series["Asistencias"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 2:
                        chartProgresos.Series["Faltas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 3:
                        chartProgresos.Series["Minutos jugados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 4:
                        chartProgresos.Series["Tiros al arco"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 5:
                        chartProgresos.Series["Tiros fallados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 6:
                        chartProgresos.Series["Pelotas recuperadas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 7:
                        chartProgresos.Series["Amonestaciones"].Points.AddY(estdProgresos[prog]);
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
            chartProgresos.Series["Goles"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Asistencias"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Faltas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Minutos jugados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Amonestaciones"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Exclusiones"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Pelotas perdidas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tiros fallados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Pelotas recuperadas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Goles"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Asistencias"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Faltas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Minutos jugados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Amonestaciones"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Exclusiones"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Pelotas perdidas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tiros fallados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Pelotas recuperadas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Goles"].BorderWidth = 10;
            chartProgresos.Series["Asistencias"].BorderWidth = 10;
            chartProgresos.Series["Faltas"].BorderWidth = 10;
            chartProgresos.Series["Minutos jugados"].BorderWidth = 10;
            chartProgresos.Series["Amonestaciones"].BorderWidth = 10;
            chartProgresos.Series["Exclusiones"].BorderWidth = 10;
            chartProgresos.Series["Pelotas perdidas"].BorderWidth = 10;
            chartProgresos.Series["Tiros fallados"].BorderWidth = 10;
            chartProgresos.Series["Pelotas recuperadas"].BorderWidth = 10;

            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows[prog][0])));
                prog++;
            }
            prog = 0;

            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Goles"].Points.AddXY((Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2])), estdProgresos[prog]);
                        break;
                    case 1:
                        chartProgresos.Series["Asistencias"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 2:
                        chartProgresos.Series["Faltas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 3:
                        chartProgresos.Series["Minutos jugados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 4:
                        chartProgresos.Series["Amonestaciones"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 5:
                        chartProgresos.Series["Exclusiones"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 6:
                        chartProgresos.Series["Pelotas perdidas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 7:
                        chartProgresos.Series["Tiros fallados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 8:
                        chartProgresos.Series["Pelotas recuperadas"].Points.AddY(estdProgresos[prog]);
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
            chartProgresos.Series.Add("Asistencias");
            chartProgresos.Series.Add("Faltas");
            chartProgresos.Series.Add("Minutos Jugados");
            chartProgresos.Series.Add("Pelotas perdidas");
            chartProgresos.Series.Add("Tiros fallados");
            chartProgresos.Series.Add("Pelotas recuperadas");
            chartProgresos.Series.Add("Tarjetas verdes");
            chartProgresos.Series.Add("Tarjetas amarillas");
            chartProgresos.Series.Add("Tarjetas rojas");
            chartProgresos.Series["Goles"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Asistencias"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Faltas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Minutos jugados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Pelotas perdidas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tiros fallados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Pelotas recuperadas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tarjetas verdes"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tarjetas amarillas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tarjetas rojas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Goles"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Asistencias"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Faltas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Minutos jugados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Pelotas perdidas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tiros fallados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Pelotas recuperadas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tarjetas verdes"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tarjetas amarillas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tarjetas rojas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Goles"].BorderWidth = 10;
            chartProgresos.Series["Asistencias"].BorderWidth = 10;
            chartProgresos.Series["Faltas"].BorderWidth = 10;
            chartProgresos.Series["Minutos jugados"].BorderWidth = 10;
            chartProgresos.Series["Pelotas perdidas"].BorderWidth = 10;
            chartProgresos.Series["Tiros fallados"].BorderWidth = 10;
            chartProgresos.Series["Pelotas recuperadas"].BorderWidth = 10;
            chartProgresos.Series["Tarjetas verdes"].BorderWidth = 10;
            chartProgresos.Series["Tarjetas amarillas"].BorderWidth = 10;
            chartProgresos.Series["Tarjetas rojas"].BorderWidth = 10;

            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows[prog][0])));
                prog++;
            }
            prog = 0;

            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Goles"].Points.AddXY((Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2])), estdProgresos[prog]);
                        break;
                    case 1:
                        chartProgresos.Series["Asistencias"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 2:
                        chartProgresos.Series["Faltas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 3:
                        chartProgresos.Series["Minutos jugados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 4:
                        chartProgresos.Series["Pelotas perdidas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 5:
                        chartProgresos.Series["Tiros fallados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 6:
                        chartProgresos.Series["Pelotas recuperadas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 7:
                        chartProgresos.Series["Tarjetas verdes"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 8:
                        chartProgresos.Series["Tarjetas amarillas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 9:
                        chartProgresos.Series["Tarjetas rojas"].Points.AddY(estdProgresos[prog]);
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
            chartProgresos.Series.Add("Tarjetas amarillas");
            chartProgresos.Series.Add("Tarjetas rojas");
            chartProgresos.Series["Tries"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tackles"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Minutos jugados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Lines ganados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Pelotas perdidas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Conversiones"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Pelotas recuperadas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tarjetas amarillas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Taretas rojas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Tries"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tackles"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Minutos jugados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Lines ganados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Pelotas perdidas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Conversiones"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Pelotas recuperadas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tarjetas amarillas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tarjetas rojas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Tries"].BorderWidth = 10;
            chartProgresos.Series["Tackles"].BorderWidth = 10;
            chartProgresos.Series["Minutos jugados"].BorderWidth = 10;
            chartProgresos.Series["Lines ganados"].BorderWidth = 10;
            chartProgresos.Series["Pelotas perdidas"].BorderWidth = 10;
            chartProgresos.Series["Conversiones"].BorderWidth = 10;
            chartProgresos.Series["Pelotas recuperadas"].BorderWidth = 10;
            chartProgresos.Series["Tarjetas amarillas"].BorderWidth = 10;
            chartProgresos.Series["Tarjetas rojas"].BorderWidth = 10;

            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows[prog][0])));
                prog++;
            }
            prog = 0;

            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Tries"].Points.AddXY((Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2])), estdProgresos[prog]);
                        break;
                    case 1:
                        chartProgresos.Series["Tackles"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 2:
                        chartProgresos.Series["Minutos jugados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 3:
                        chartProgresos.Series["Lines ganados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 4:
                        chartProgresos.Series["Pelotas perdidas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 5:
                        chartProgresos.Series["Conversiones"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 6:
                        chartProgresos.Series["Pelotas recuperadas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 7:
                        chartProgresos.Series["Tarjetas amarillas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 8:
                        chartProgresos.Series["Tarjetasa rojas"].Points.AddY(estdProgresos[prog]);
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
            chartProgresos.Series["Aces"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Errores no forzados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Faltas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Doble faltas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Winners"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Quiebres"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Aces"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Errores no forzados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Faltas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Doble faltas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Winners"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Quiebres"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Aces"].BorderWidth = 10;
            chartProgresos.Series["Errores no forzados"].BorderWidth = 10;
            chartProgresos.Series["Faltas"].BorderWidth = 10;
            chartProgresos.Series["Doble faltas"].BorderWidth = 10;
            chartProgresos.Series["Winners"].BorderWidth = 10;
            chartProgresos.Series["Quiebres"].BorderWidth = 10;

            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows[prog][0])));
                prog++;
            }
            prog = 0;

            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Aces"].Points.AddXY((Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2])), estdProgresos[prog]);
                        break;
                    case 1:
                        chartProgresos.Series["Errores no forzados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 2:
                        chartProgresos.Series["Faltas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 3:
                        chartProgresos.Series["Doble faltas"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 4:
                        chartProgresos.Series["Winners"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 5:
                        chartProgresos.Series["Quiebres"].Points.AddY(estdProgresos[prog]);
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
            chartProgresos.Series["Aces"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Errores no forzados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Remates logrados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Saques errados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Recepciones"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Armados"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Bloqueos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartProgresos.Series["Aces"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Errores no forzados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Remates logrados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Saques errados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Recepciones"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Armados"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Bloqueos"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartProgresos.Series["Aces"].BorderWidth = 10;
            chartProgresos.Series["Errores no forzados"].BorderWidth = 10;
            chartProgresos.Series["Remates logrados"].BorderWidth = 10;
            chartProgresos.Series["Saques errados"].BorderWidth = 10;
            chartProgresos.Series["Recepciones"].BorderWidth = 10;
            chartProgresos.Series["Armados"].BorderWidth = 10;
            chartProgresos.Series["Bloqueos"].BorderWidth = 10;

            while (prog < Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows.Count)))
            {
                estdProgresos.Add(Convert.ToInt32((ds.Tables["IngresarEstadisticas"].Rows[prog][0])));
                prog++;
            }
            prog = 0;

            while (prog < estdProgresos.Count)
            {
                switch (x)
                {
                    case 0:
                        chartProgresos.Series["Aces"].Points.AddXY((Convert.ToString(ds.Tables["IngresarEstadisticas"].Rows[prog][2])), estdProgresos[prog]);
                        break;
                    case 1:
                        chartProgresos.Series["Errores no forzados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 2:
                        chartProgresos.Series["Remates logrados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 3:
                        chartProgresos.Series["Saques errados"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 4:
                        chartProgresos.Series["Recepciones"].Points.AddY(estdProgresos[prog]);
                        break;
                    case 5:
                        chartProgresos.Series["Armados"].Points.AddY(estdProgresos[prog]);
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
        public progresos()
        {
            InitializeComponent();
        }

        private void Progresos_Load(object sender, EventArgs e)
        {
           
            connection.Open();
            OleDbCommand info;
            OleDbCommand info2;
            info = new OleDbCommand("Select Estd, IdCar, Fecha FROM IngresarEstadisticas WHERE Per ='" + Convert.ToString(Program.idPerfil) + "'", connection);
            info2 = new OleDbCommand("Select Deporte FROM Perfil WHERE Nombre = '" + Program.idPerfil + "'", connection);
            OleDbDataAdapter da1 = new OleDbDataAdapter(info);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);
            da1.Fill(ds, "IngresarEstadisticas");
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
