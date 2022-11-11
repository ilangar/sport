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
using System.Security.Cryptography;

namespace Sport1
{
    public partial class Objetivos : Form
    {
        int lbl = 0;
        int txt = 0;
        int posLblY = 120;
        int posLblX = 45;
        int posTxtY = 120;
        int posTxtX = 250;
        int nom = 0;
        Inicio formInicio;
        int x = 0;
        int dia;
        int mes;
        int ano;
        string FechaLimite;
        Perfil1 formPerfil1;
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        List<TextBox> listaTXTObjDeportes = new List<TextBox>();
        string[] arrObjBask = new string[6] { "Puntos", "Asistencias", "Faltas", "Minutos jugados", "Rebotes", "Pelotas recuperadas" };
        string[] arrObjBaskid = new string[6] { "1", "2", "3", "4", "7", "10" };
        string[] arrObjFut = new string[6] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrObjFutid= new string[6] { "2", "3", "4", "8", "10","11" };
        string[] arrObjHand = new string[7] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Amonestaciones", "Pelotas perdidas", "Pelotas recuperadas" };
        string[] arrObjHandid = new string[7] { "2", "3", "4", "8", "10", "11","13" };
        string[] arrObjHock = new string[6] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Tiros fallados", "Pelotas recuperadas" };
        string[] arrObjHockid = new string[6] { "2", "3", "4", "5", "8", "10"};
        string[] arrObjRugby = new string[7] { "Tries", "Tackles", "Minutos Jugados", "Lines ganados", "Pelotas perdidas", "Conversiones", "Pelotas recuperadas" };
        string[] arrObjRugbyid = new string[7] { "17", "18", "4", "19", "13", "20", "10" };
        string[] arrObjTenis = new string[6] { "Aces", "Errores no forzados", "Faltas", "Doble faltas", "Winners", "Quiebres" };
        string[] arrObjTenisid = new string[6] { "21", "22", "3", "23", "24", "25" };
        string[] arrObjVoley = new string[7] { "Aces", "Errores no forzados", "Remates logrados", "Saques errados", "Recepciones", "Armados", "Bloqueos" };
        string[] arrObjVoleyid = new string[7] { "21", "22", "26", "27", "28", "29", "6" };
        public void lblObjBasket()
        {
            while (lbl < 6)
            {
                Label lblObjBask = new Label();
                this.Controls.Add(lblObjBask);
                lblObjBask.Location = new Point(posLblX, posLblY);
                lblObjBask.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblObjBask.AutoSize = true;
                lblObjBask.TextAlign = ContentAlignment.MiddleCenter;
                lblObjBask.Text = arrObjBask[lbl];
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
                listaTXTObjDeportes.Add(txtObjBasket);
                txtObjBasket.Location = new Point(posTxtX, posTxtY);
                txtObjBasket.Tag = arrObjBaskid[txt];
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
                listaTXTObjDeportes.Add(txtObjFutbol);
                txtObjFutbol.Location = new Point(posTxtX, posTxtY);
                txtObjFutbol.Tag = arrObjBaskid[txt];
                txt++;
                posTxtY += 40;
            }
        }
        public void lblObjHandball()
        {
            while (lbl < 7)
            {
                Label lblObjHandball = new Label();
                this.Controls.Add(lblObjHandball);
                lblObjHandball.Location = new Point(posLblX, posLblY);
                lblObjHandball.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblObjHandball.AutoSize = true;
                lblObjHandball.TextAlign = ContentAlignment.MiddleCenter;
                lblObjHandball.Text = arrObjHand[lbl];
                lbl++;
                posLblY += 40;
            }
        }

        public void txtObjHand()
        {
            while (txt < 7)
            {
                TextBox txtObjHand = new TextBox();
                this.Controls.Add(txtObjHand);
                listaTXTObjDeportes.Add(txtObjHand);
                txtObjHand.Location = new Point(posTxtX, posTxtY);
                txtObjHand.Name += Convert.ToString(nom);
                txt++;
                posTxtY += 40;
                nom++;
            }
        }
        public void lblObjHockey()
        {
            while (lbl < 6)
            {
                Label lblObjHockey = new Label();
                this.Controls.Add(lblObjHockey);
                lblObjHockey.Location = new Point(posLblX, posLblY);
                lblObjHockey.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblObjHockey.AutoSize = true;
                lblObjHockey.TextAlign = ContentAlignment.MiddleCenter;
                lblObjHockey.Text = arrObjHock[lbl];
                lbl++;
                posLblY += 40;
            }
        }
        public void txtObjHockey()
        {
            while (txt < 6)
            {
                TextBox txtObjHockey = new TextBox();
                this.Controls.Add(txtObjHockey);
                listaTXTObjDeportes.Add(txtObjHockey);
                txtObjHockey.Location = new Point(posTxtX, posTxtY);
                txtObjHockey.Name += Convert.ToString(nom);
                txt++;
                posTxtY += 40;
                nom++;
            }
        }
        public void lblObjRugby()
        {
            while (lbl < 7)
            {
                Label lblObjRugby = new Label();
                this.Controls.Add(lblObjRugby);
                lblObjRugby.Location = new Point(posLblX, posLblY);
                lblObjRugby.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblObjRugby.AutoSize = true;
                lblObjRugby.TextAlign = ContentAlignment.MiddleCenter;
                lblObjRugby.Text = arrObjRugby[lbl];
                lbl++;
                posLblY += 40;
            }
        }
        public void txtObjRugby()
        {
            while (txt < 9)
            {
                TextBox txtObjRugby = new TextBox();
                this.Controls.Add(txtObjRugby);
                listaTXTObjDeportes.Add(txtObjRugby);
                txtObjRugby.Location = new Point(posTxtX, posTxtY);
                txtObjRugby.Name += Convert.ToString(nom);
                txt++;
                posTxtY += 40;
                nom++;
            }
        }
        public void lblObjTenis()
        {
            while (lbl < 6)
            {
                Label lblObjTenis = new Label();
                this.Controls.Add(lblObjTenis);
                lblObjTenis.Location = new Point(posLblX, posLblY);
                lblObjTenis.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblObjTenis.AutoSize = true;
                lblObjTenis.TextAlign = ContentAlignment.MiddleCenter;
                lblObjTenis.Text = arrObjTenis[lbl];
                lbl++;
                posLblY += 40;
            }
        }
        public void txtObjTenis()
        {
            while (txt < 6)
            {
                TextBox txtObjTenis = new TextBox();
                this.Controls.Add(txtObjTenis);
                listaTXTObjDeportes.Add(txtObjTenis);
                txtObjTenis.Location = new Point(posTxtX, posTxtY);
                txtObjTenis.Name += Convert.ToString(nom);
                txt++;
                posTxtY += 40;
                nom++;
            }
        }
        public void lblObjVoley()
        {
            while (lbl < 7)
            {
                Label lblObjVoley = new Label();
                this.Controls.Add(lblObjVoley);
                lblObjVoley.Location = new Point(posLblX, posLblY);
                lblObjVoley.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, ((Byte)(0)));
                lblObjVoley.AutoSize = true;
                lblObjVoley.TextAlign = ContentAlignment.MiddleCenter;
                lblObjVoley.Text = arrObjVoley[lbl];
                lbl++;
                posLblY += 40;
            }
        }
        public void txtObjVoley()
        {
            while (txt < 7)
            {
                TextBox txtObjVoley = new TextBox();
                this.Controls.Add(txtObjVoley);
                listaTXTObjDeportes.Add(txtObjVoley);
                txtObjVoley.Location = new Point(posTxtX, posTxtY);
                txtObjVoley.Name += Convert.ToString(nom);
                txt++;
                posTxtY += 40;
                nom++;
            }
        }
         
        public void dbObjBasket()
        {
            x = 0;
            
            if (ds2.Tables["Obj"].Rows.Count == 0)
            {
                while (x < 6)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Obj (Objetivo, IdCar, Per) VALUES (" + Convert.ToInt32(listaTXTObjDeportes[x].Text) + ", " + Convert.ToInt32(listaTXTObjDeportes[x].Tag) + ", " + Program.idUser + ")";
                    command.ExecuteNonQuery();
                    connection.Close();
                    x++;

                }
            }
            if (ds2.Tables["Obj"].Rows.Count > 0)
            {
                while (x < 6)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    OleDbCommand command2 = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE Obj SET Objetivo = " + Convert.ToInt32(listaTXTObjDeportes[x].Text) + " WHERE Per =" + Convert.ToInt32(Program.idUser);
                    command.ExecuteNonQuery();

                    command2.Connection = connection;
                    command2.CommandText = "UPDATE Obj SET IdCar = " + Convert.ToInt32(listaTXTObjDeportes[x].Tag) + " WHERE Per =" + Convert.ToInt32(Program.idUser);
                    command2.ExecuteNonQuery();
                    connection.Close();
                    x++;

                }
            }
        }
        public void dbObjFutbol()
        {
            x = 0;

            if (Convert.ToInt32(ds2.Tables["Obj"].Rows[0][0]) == 0)
            {
                while (x < 6)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Obj (Objetivo, IdCar, Per) VALUES (" + Convert.ToInt32(listaTXTObjDeportes[x].Text) + ", " + Convert.ToInt32(listaTXTObjDeportes[x].Tag) + ", " + Program.idUser + ")";
                    command.ExecuteNonQuery();
                    connection.Close();
                    x++;

                }
            }
            if (Convert.ToInt32(ds2.Tables["Obj"].Rows[0][0]) > 0)
            {
                while (x < 6)
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "UPDATE Obj SET Objetivo, IdCar, Per = (" + Convert.ToInt32(listaTXTObjDeportes[x].Text) + ", " + Convert.ToInt32(listaTXTObjDeportes[x].Tag) + ", " + Convert.ToInt32(Program.idUser) + ")";
                    command.ExecuteNonQuery();
                    connection.Close();
                    x++;

                }
            }
        }

        private OleDbConnection connection = new OleDbConnection();
        public Objetivos()
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
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Sport1-DB.accdb";
            OleDbCommand info;
            OleDbCommand info2;

            info = new OleDbCommand("Select Deporte From Perfil WHERE  Nombre ='" + Convert.ToString(Program.idPerfil) + "'", connection);
            info2 = new OleDbCommand("Select Count(Objetivo) From Obj WHERE Per = " + Program.idUser , connection);

            OleDbDataAdapter da1 = new OleDbDataAdapter(info);
            OleDbDataAdapter da2 = new OleDbDataAdapter(info2);

            da1.Fill(ds, "Perfil");
            da2.Fill(ds2, "Obj");

            // reader.Read();
            // int Deporte = int.Parse(reader["Deporte"].ToString());

            connection.Close();


           
            switch (Convert.ToString(ds.Tables["Perfil"].Rows[0][0]))
            {
                case "1":
                    lblObjBasket();
                    txtObjBasket();
                    break;
                case "2":
                    lblObjFutbol();
                    txtObjFutbol();
                    break;
                case "3":
                    lblObjHandball();
                    txtObjHand();
                    break;
                case "4":
                    lblObjHockey();
                    txtObjHockey();
                    break;
                case "5":
                    lblObjRugby();
                    txtObjRugby();
                    break;
                case "6":
                    lblObjTenis();
                    txtObjTenis();
                    break;
                case "7":
                    lblObjVoley();
                    txtObjVoley();
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

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            switch (Convert.ToString(ds.Tables["Perfil"].Rows[0][0]))
            {
                case "1":
                    dbObjBasket();
                    break;
                case "2":
                    dbObjFutbol();
                    break;
            }
            formPerfil1 = new Perfil1();
            this.Hide();
            formPerfil1.Show();
        }


        private void BtnVolverAEnt_Click(object sender, EventArgs e)
        {
            formPerfil1 = new Perfil1();
            this.Hide();
            formPerfil1.Show();
        }

        
    }
}
    