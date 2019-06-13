using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_3
{
    class Equipo
    {
        public string Nombre { get; }
        List<Jugador> jugadores;
        
        public Equipo(string nombre)
        {
            nombre = Nombre;
            jugadores = new List<Jugador>();
        }

        public override string ToString()
        {
            return Nombre;
        }

        public void agregarJugador (Jugador jugador)
        {
            jugadores.Add(jugador);
        }
        public void eliminarJugador (int indice)
        {
            jugadores.RemoveAt(indice);
        }
        
    }
}
