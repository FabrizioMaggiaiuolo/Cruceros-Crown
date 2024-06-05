using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruceros_Crown
{
    public class Pasaporte
    {
        private int numero;
        private string nacionalidad;
        private string ciudad;

        public Pasaporte(int numero,string nacionalidad, string ciudad)
        {
            this.nacionalidad = nacionalidad;
            this.ciudad = ciudad;
            this.numero = numero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero de pasaporte: {this.numero}");
            sb.AppendLine($"Nacionalidad: {this.nacionalidad} ");
            sb.AppendLine($"Direccion: {this.ciudad} ");
            return sb.ToString();
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        public string Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
        }

        public string Ciudad
        {
            get
            {
                return this.ciudad;
            }
        }
    }
}
