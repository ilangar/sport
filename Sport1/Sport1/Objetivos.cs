﻿using System;
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
        int nom = 0;
        Inicio formInicio;

        string[] arrObjBask = new string[6] { "Puntos", "Asistencias", "Faltas", "Minutos jugados", "Rebotes", "Pelotas recuperadas" };
        string[] arrObjFut = new string[6] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Pelotas recuperadas", "Amonestaciones" };
        string[] arrObjHand = new string[7] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Amonestaciones", "Pelotas perdidas", "Pelotas recuperadas" };
        string[] arrObjHock = new string[6] { "Goles", "Asistencias", "Faltas", "Minutos Jugados", "Tiros fallados", "Pelotas recuperadas" };
        string[] arrObjRugby = new string[7] { "Tries", "Tackles", "Scrums ganados", "Lines ganados", "Pelotas perdidas", "Conversiones", "Pelotas recuperadas" };
        string[] arrObjTenis = new string[6] { "Aces", "Errores no forzados", "Faltas", "Doble faltas", "Winners", "Quiebres" };
        string[] arrObjVoley = new string[7] { "Aces", "Errores no forzados", "Remates logrados", "Saques errados", "Recepciones", "Armados", "Bloqueos" };

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

        public void txtObjHandball()
        {
            while (txt < 7)
            {
                TextBox txtObjHand = new TextBox();
                this.Controls.Add(txtObjHand);
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
                txtObjVoley.Location = new Point(posTxtX, posTxtY);
                txtObjVoley.Name += Convert.ToString(nom);
                txt++;
                posTxtY += 40;
                nom++;
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

            switch (Convert.ToString(ds.Tables["Perfil"].Rows[0][0]))
            {
                case "1":
                    lblObjBasket(); txtObjBasket();
                    break;
                case "2":
                    lblObjFutbol(); txtObjFutbol();
                    break;
                case "3":
                    lblObjHandball(); txtObjHandball();
                    break;
                case "4":
                    lblObjHockey(); txtObjHockey();
                    break;
                case "5":
                    lblObjRugby(); txtObjRugby();
                    break;
                case "6":
                    lblObjTenis(); txtObjTenis();
                    break;
                case "7":
                    lblObjVoley(); txtObjVoley();
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

            
              connection.Open();
              OleDbCommand command = new OleDbCommand();
              command.Connection = connection;
              command.CommandText = "INSERT INTO (FechaLimite) FROM Obj values ('" + cmbAñoBasket + "','" + cmbMesBasket + "','" + cmbAñoBasket + "')";
                  command.ExecuteNonQuery();
                  connection.Close();
                  this.Hide();
                  Inicio f2 = new Inicio();
            f2.ShowDialog();
        }

        private void BtnVolverAEnt_Click(object sender, EventArgs e)
        {
            formInicio = new Inicio();
            this.Hide();
            formInicio.Show();
        }

        private void CmbMesBasket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    