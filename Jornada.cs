using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_3
{
    class Jornada
    {
        public int numero { get; }

        public List<Enfrentamiento> enfrentamientos { get;  }
        public  Jornada(int Numero)
        {
            numero = Numero;
            enfrentamientos = new List<Enfrentamiento>();
        }


        public void agregarEnfrentamiento (Enfrentamiento enfrentamiento)
        {
            enfrentamientos.Add(enfrentamiento);
        }

        public override string ToString()
        {
            return "Jornada: " + numero;
        }
    }
}
