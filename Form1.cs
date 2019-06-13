using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Examen_Parcial_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            Jugador jugador;
            int numero = Convert.ToInt32(textNumeroJugador.Text);
            string nombre = Convert.ToString(textNombreJugador.Text);
            string posicion = Convert.ToString(textPosicionJugador.Text);
            string nacionalidad = Convert.ToString(textNacionalidadJugador.Text);
            int edad = Convert.ToInt16(textEdadJugador.Text);
            jugador = new Jugador(nombre,posicion,numero,nacionalidad,edad);
            listJugadores.Items.Add(jugador.ToString());
            
        }

        private void textNumeroJugador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            comboEquipos.Items.Add(txtNombreEquipo.Text);
            listEquipos.Items.Add(txtNombreEquipo.Text);
            listLocales.Items.Add(txtNombreEquipo.Text);
            listVisitantes.Items.Add(txtNombreEquipo.Text);
        }

        private void txtNombreEquipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void listEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textNombreJugador_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEdadJugador_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNacionalidadJugador_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPosicionJugador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {

        }

        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listJornadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listEnfrentamientos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listLocales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkSejugo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listVisitantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVisitante_Click(object sender, EventArgs e)
        {

        }
    }
}
