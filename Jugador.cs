using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_3
{
    class Jugador
    {
        private string nombre_Jugador { set; get; }
        private string posicion { set; get; }
        private int numero_playera { set; get; } 
        private string nacionalidad { set; get; }
        private int edad { set; get; }

        public Jugador(string NombreJugador, string Posicion, int NumeroPlayera, string Nacionalidad, int Edad)
        {
            NombreJugador = nombre_Jugador;
            Posicion= posicion;
            Nacionalidad= nacionalidad;
            Edad = edad;
            NumeroPlayera = numero_playera;
        }
        public override string ToString()
        {
            return "Nombre del jugador: " + nombre_Jugador + Environment.NewLine
                + "Edad:" + edad + Environment.NewLine + "Número del jugador" + numero_playera + Environment.NewLine
                + "Posición: " + posicion + Environment.NewLine 
                + "Nacionalidad: " + nacionalidad + Environment.NewLine;
        }
    }
}
