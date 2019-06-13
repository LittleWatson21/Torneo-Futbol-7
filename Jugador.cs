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
            nombre_Jugador = NombreJugador ;
            posicion = Posicion;
            nacionalidad =Nacionalidad;
            edad = Edad;
            numero_playera = NumeroPlayera;
        }
        public override string ToString()
        {
            return nombre_Jugador;
           
        }
    }
}
