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
        
        OleDbConnection BaseDeDatosProyecto;
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
            OleDbCommand info;
            info = new OleDbCommand("Select Deporte FROM Usuario WHERE Id = 1", BaseDeDatosProyecto);
            OleDbDataAdapter da = new OleDbDataAdapter(info);
            DataSet ds = new DataSet();
            da.Fill(ds, "Usuario");
            string var = ds.Tables["Usuario"].Rows[0][0].ToString();
            if(var == "Futbol")
            {
                boxBas.Visible = false;
                boxHan.Visible = false;

            }
            if (var == "Handball")
            {
                boxBas.Visible = false;
                boxFut.Visible = false;

            }
            if (var == "Basquetball")
            {
                boxFut.Visible = false;
                boxHan.Visible = false;

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
    }
}
