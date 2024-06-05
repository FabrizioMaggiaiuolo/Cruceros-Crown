using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruceros_Crown
{
    public static class ListaPasajeros
    {
        public static List<Pasajero> pasajeros = new List<Pasajero>();

    }
    public class Pasajero
    {
        private string nombres;
        private string apellidos;
        private Pasaporte pasaporte;
        private short edad;
        private List<Equipaje> equipajes;
        private ETipoDePasajero tipoDePasajero;

        public Pasajero(string nombres, string apellidos, string nacionalidad, string ciudad, int numeroPasaporte, short edad)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.pasaporte = new Pasaporte(numeroPasaporte, nacionalidad, ciudad);
            this.edad = edad;
        }

        public Pasajero(string nombres, string apellidos, string nacionalidad, string ciudad, int numeroPasaporte, short edad, List<Equipaje> equipajes, ETipoDePasajero tipoDePasajero)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.pasaporte = new Pasaporte(numeroPasaporte,nacionalidad, ciudad);
            this.edad = edad;
            this.equipajes = equipajes;
            this.tipoDePasajero = tipoDePasajero;   
        }

        public string Mostrar()
        {
            return this.nombres + " " + this.apellidos;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombres} ");
            sb.AppendLine($"Apellidos: {this.apellidos} ");
            sb.AppendLine($"Pasaporte: {this.pasaporte.ToString()} ");
            sb.AppendLine($"Edad: {this.edad} ");
            sb.AppendLine($"Cantidad de valijas y bolsos de mano: {this.equipajes.Count()} ");
            return sb.ToString();
        }

        public static bool operator ==(Pasajero pasajero1, Pasajero pasajero2)
        {
            bool retorno = false;
            if(pasajero1.nombres == pasajero2.nombres && pasajero1.apellidos == pasajero2.apellidos && pasajero1.pasaporte.Numero == pasajero2.pasaporte.Numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Pasajero pasajero1, Pasajero pasajero2)
        {
            return !(pasajero1 == pasajero2);
        }

        public static List<Pasajero> operator +(List<Pasajero> lista, Pasajero pasajero)
        {
            bool retorno = true;
            foreach(Pasajero pasajeroaux in lista)
            {
                if(pasajeroaux == pasajero)
                {
                    retorno = false;
                }
            }
            if(retorno == true)
            {
                lista.Add(pasajero);
            }
            return lista;
        }

        public string Nombres
        {
            get
            {
                return this.nombres;
            }
        }

        public string Apellidos
        {
            get
            {
                return this.apellidos;
            }
        }

        public Pasaporte Pasaporte
        {
            get
            {
                return this.pasaporte;
            }
        }

        public short Edad
        {
            get
            {
                return this.edad;
            }
        }

        public int EquipajesPeso
        {
            get
            {
                int total = 0;
                foreach(Equipaje equipaje in this.equipajes)
                {
                    if(equipaje.TipoDeEquipaje == EEquipajes.Bodega)
                    {
                        total += ((Valija)equipaje).Peso;
                    }
                }
                return total;
            }
        }

        public ETipoDePasajero TipoDePasajero
        {
            get
            {
                return this.tipoDePasajero;
            }
        }
    }

}
