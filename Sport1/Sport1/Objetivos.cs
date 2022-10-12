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

namespace Sport1
{
    public partial class objetivos : Form
    {
        int lbl = 0;
        int posLblX = 50;
        int posLblY = 114;
        int txt = 0;
        int posTxtX = 150;
        int posTxtY = 114;

        string[] arrObjBask = new string[6] { "Puntos", "Asistencias", "Faltas", "Minutos jugados", "Rebotes", "Pelotas recuperadas" };
        string[] arrObjFut = new string[6] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Pelotas recuperadas", "Amonestaciones" };
        public void lblObjBasket()
        {
            while (lbl < 6)
            {
                Label lblObjBasket = new Label();
                this.Controls.Add(lblObjBasket);
                lblObjBasket.Location = new Point(posLblX, posLblY);
                lblObjBasket.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblObjBasket.AutoSize = true;
                lblObjBasket.TextAlign = ContentAlignment.MiddleCenter;
                lblObjBasket.Text = arrObjBask[lbl];
                lbl++;
                posLblY += 40;
            }

        }
        public void txtObjBasket()
        {
            while (txt < 6)
            {
                TextBox txtObjBasket = new TextBox();
                this.Controls.Add(txtObjBasket);
                txtObjBasket.Location = new Point(posTxtX, posTxtY);
                txt++;
                posTxtY += 40;
            }
        }
        public void lblObjFutbol()
        {
            while (lbl < 6)
            {
                Label lblObjFutbol = new Label();
                this.Controls.Add(lblObjFutbol);
                lblObjFutbol.Location = new Point(posLblX, posLblY);
                lblObjFutbol.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblObjFutbol.AutoSize = true;
                lblObjFutbol.TextAlign = ContentAlignment.MiddleCenter;
                lblObjFutbol.Text = arrObjFut[lbl];
                lbl++;
                posLblY += 40;
            }
        }
        public void txtObjFutbol()
        {
            while (txt < 6)
            {
                TextBox txtObjFutbol = new TextBox();
                this.Controls.Add(txtObjFutbol);
                txtObjFutbol.Location = new Point(posTxtX, posTxtY);
                txt++;
                posTxtY += 40;
            }
        }

        private OleDbConnection connection = new OleDbConnection();
        public objetivos()
        {
            InitializeComponent();
        }
        
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Objfutbol_Load(object sender, EventArgs e)
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Sport1-DB.accdb";

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "SELECT Deporte from Perfil WHERE Nombre='" + "Mauro" + "'";
            OleDbDataReader reader = command.ExecuteReader();

            reader.Read();
            int Deporte = int.Parse(reader["Deporte"].ToString());

            connection.Close();
            connection.Open();

            OleDbCommand info;
            info = new OleDbCommand("Select Deporte FROM Perfil", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            DataSet ds = new DataSet();
            da.Fill(ds, "Perfil");
            string var = ds.Tables["Perfil"].Rows[0][0].ToString();


            switch ((Convert.ToString(ds.Tables["Perfil"].Rows[0][0])))
            {
                case "1": lblObjBasket();
                    break;
            }
        }

        private void Lblobjfutbol_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click_1(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
