using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruceros_Crown
{
    public static class ListaCruceros
    {
        public static List<Crucero> cruceros = new List<Crucero>();
    }

    public class Crucero
    {
        private string matricula;
        private string nombre;
        private int camarotes;
        private short salones;
        private short casinos;
        private int bodegaKG;

        public Crucero(string matricula, string nombre, int camarotes, short salones, short casinos, int bodega)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.camarotes = camarotes;
            this.salones = salones;
            this.casinos = casinos;
            this.bodegaKG = bodega;
        }

        public override string ToString()
        {
            return this.nombre + " | " + this.matricula;
        }

        public string Matricula
        {
            get
            {
                return this.matricula;
            }
        }

        public int Camarotes
        {
            get
            {
                return this.camarotes;
            }
        }

        public int BodegaKG
        {
            get
            {
                return this.bodegaKG;
            }
        }

    }
}
