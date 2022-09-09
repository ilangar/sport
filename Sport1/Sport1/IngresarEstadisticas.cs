using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport1
{
    public partial class IngresarEstadisticas : Form
    {
        public int[] fechaBasket = new int[2000];
        public int dia;
        public int mes;
        public int año;
        public int fecha;
        public int puntos;
        public int asistencias;
        public int faltas;
        public int minJugados;
        public int tirosFal;
        public int bloqueos;
        Perfil1 formPerfil1;

        public IngresarEstadisticas()
        {
            InitializeComponent();
        }

        private void IngresarEstadisticas_Load(object sender, EventArgs e)
        {
            
        }

        private void CmbDiaBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            dia = cmbDiaBasket.SelectedIndex;
        }

        private void CmbMesBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            mes = cmbDiaBasket.SelectedIndex;
        }

        private void CmbAñoBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            año = cmbDiaBasket.SelectedIndex;
        }

        private void TxtPuntosBasket_TextChanged(object sender, EventArgs e)
        {
            puntos = Convert.ToInt32(txtPuntosBasket.Text);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            asistencias = Convert.ToInt32(txtaAsistenicasBasket.Text);
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            faltas = Convert.ToInt32(txtFaltasBasket.Text);
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            minJugados = Convert.ToInt32(txtMinJugBasket.Text);
        }

        private void TxtTirosFal_TextChanged(object sender, EventArgs e)
        {
            tirosFal = Convert.ToInt32(txtTirosFal.Text);
        }

        private void TxtBloqueosBasket_TextChanged(object sender, EventArgs e)
        {
            bloqueos = Convert.ToInt32(txtBloqueosBasket.Text);
        }

        private void BtnIngresarBasket_Click(object sender, EventArgs e)
        {
            formPerfil1 = new Perfil1();
            formPerfil1.Show();
            this.Hide();
        }
    }
}
