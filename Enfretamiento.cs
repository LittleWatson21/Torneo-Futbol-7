using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_3
{
    class Enfrentamiento
    {
        public Equipo local;
        public Equipo visitante;
        public bool sejugo;
        public int goleslocal;
        public int golesvisitante;

        public Enfrentamiento(Equipo Local, Equipo Visitante, bool Sejugo, int Goleslocal, int Golesvisitante)
        {
            local = Local;
            visitante = Visitante;
            sejugo = Sejugo;
            goleslocal = Goleslocal;
            golesvisitante = Golesvisitante;
        }

        public string resultado ()
        {
            if(!sejugo)
            {
                return "No se jugo :c";
            }
            else if (goleslocal > golesvisitante)
            {
                return "Gano Local";
            }
            else if (goleslocal < golesvisitante)
            {
                return "Gano Visitante";
            }
            else 
            {
                return "Empate";
            }
        }

        public override string ToString()
        {
            return local.Nombre + " vs " + visitante.Nombre;
        }

    }
}
