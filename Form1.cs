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
        }
    }
}
