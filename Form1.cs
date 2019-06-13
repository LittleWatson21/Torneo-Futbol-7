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
        int numeroJornada = 0;
        List<Equipo> equipos;
        List<Jugador> jugadores;
        Equipo equiposeleccionado;
        Jugador jugadorseleccionado;
        Jornada jornadaseleccionada;
        List<Jornada> jornadas;
        public Form1()
        {
            InitializeComponent();
            equipos = new List<Equipo>();
            equiposeleccionado = null;
            runTests();
            jornadas = new List<Jornada>();
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
            equiposeleccionado.agregarJugador(jugador);
            listJugadores.Items.Add(jugador.ToString());
            
        }

        private void textNumeroJugador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo(txtNombreEquipo.Text);
            equipos.Add(equipo);
            updateequiposeleccionado(equipo);

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
            updateequiposeleccionado(equipos.ElementAt(listEquipos.SelectedIndex));
            updateListaJugadores(equipos.ElementAt(listEquipos.SelectedIndex));
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
            int indiceJugadorEliminado = listJugadores.SelectedIndex;
            equiposeleccionado.eliminarJugador(indiceJugadorEliminado);
            updateListaJugadores(equiposeleccionado);
            
            
        }

        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateJugadorSeleccionado(jugadores.ElementAt(listEquipos.SelectedIndex));
            updateListaJugadores(equipos.ElementAt(listEquipos.SelectedIndex));
        }

        private void listJornadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listEnfrentamientos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listLocales_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateequiposeleccionado(equipos.ElementAt(listEquipos.SelectedIndex));
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
        

        private void btnVisitante_Click(object sender, EventArgs e)
        {

        }

        private void updateequiposeleccionado(Equipo equipo)
        {
            equiposeleccionado = equipo;
            lblSeleccionado.Text = "Seleccionado: " + equiposeleccionado.ToString();
        }

        private void updateJugadorSeleccionado (Jugador jugador)
        {
            jugadorseleccionado = jugador;
            label16.Text = "Seleccionado: " + jugadorseleccionado.ToString();
        }

        private void updateJornadaSeleccionado (Jornada jornada)
        {

            jornadaseleccionada = jornada;

        }

        private void updateListaJugadores(Equipo equipo)
        {
            equiposeleccionado = equipo;
            updateequiposeleccionado(equiposeleccionado);
            listJugadores.Items.Clear();
            for (int i = 0; i < equiposeleccionado.jugadores.Count; i++)
            {
                listJugadores.Items.Add(equiposeleccionado.jugadores[i]);
            }
        }









        Random aleatorio = new Random();

        public void runTests()
        {
            equipos = obtenerEquiposPruebas();

            for (int i = 0; i < equipos.Count; i++)
            {
                listEquipos.Items.Add(equipos[i]);
            }
        }

        private List<Equipo> obtenerEquiposPruebas(int cantidad = 20, int jugadoresPorEquipo = 15)
        {
            List<Equipo> equipos = new List<Equipo>();

            for (int i = 1; i <= cantidad; i++)
            {
                Equipo equipo = new Equipo("Eq. " + i);

                List<Jugador> jugadores = obtenerJugadoresPrueba(jugadoresPorEquipo);

                for (int j = 0; j < jugadores.Count; j++)
                {
                    equipo.agregarJugador(jugadores[j]);
                }

                equipos.Add(equipo);
            }

            return equipos;
        }

        private List<Jugador> obtenerJugadoresPrueba(int cantidad)
        {
            string[] nacionalidades = new string[] { "México", "Colombia", "Perú", "Argentina", "España"  };
            string[] posiciones = new string[] { "Portero", "Defensa", "Mediocampista", "Delantero"  };

            List<Jugador> jugadores = new List<Jugador>();

            for (int i = 1; i <= cantidad; i++)
            {
                jugadores.Add(new Jugador(
                  "Jugador " + i,
                  posiciones[aleatorio.Next(0, posiciones.Length)],
                  i * aleatorio.Next(0, 5) + 2,
                  nacionalidades[aleatorio.Next(0, nacionalidades.Length )],
                  20 + i * 2 - 2
                ));
            }

            return jugadores;
        }

        private void btnAddJornada_Click(object sender, EventArgs e)
        {
            numeroJornada++;
            Jornada jornada = new Jornada(numeroJornada);
            jornadas.Add(jornada);
            listJornadas.Items.Add(jornada);
        }

      
    }
}
