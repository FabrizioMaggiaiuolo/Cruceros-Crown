using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruceros_Crown
{
    public static class ListaViajes
    {
        public static List<Viaje> viajes = new List<Viaje>();
    }

    public class Viaje
    {
        private string codigoDeViaje;
        private string ciudadDePartida;
        private string ciudadDeDestino;
        private DateTime fechaInicio;
        private string matriculaCrucero;
        private int camarotesPremium;
        private int camarotesTurista;
        private int bodegaDisponible;
        private double costoPremium;
        private double costoTurista;
        private int duracionViaje;
        private List<Pasajero> pasajeros;

        public Viaje(string codigoDeViaje,string ciudadDePartida, string ciudadDeDestino, DateTime fecha, string matricula, double camarotesTotales, bool esRegional, int capacidadBodegaKg)
        {
            this.codigoDeViaje = codigoDeViaje;
            this.ciudadDePartida = ciudadDePartida;
            this.ciudadDeDestino = ciudadDeDestino;
            this.fechaInicio = fecha;
            this.matriculaCrucero = matricula;
            this.camarotesTurista = (int)(camarotesTotales * 0.65);
            this.camarotesPremium = (int)(camarotesTotales * 0.35);
            this.bodegaDisponible = capacidadBodegaKg;
            this.Pasajeros = new List<Pasajero>();

            Random random = new Random();
            int precio;

            if(esRegional == true)
            {
                this.duracionViaje = random.Next(72, 360);
                precio = 57;
            }
            else
            {
                this.duracionViaje = random.Next(480, 720);
                precio = 120;
            }

            this.costoTurista = duracionViaje * precio;
            this.costoPremium = this.costoTurista * 1.20;

        }

        public static bool operator ==(Viaje v1, Viaje v2)
        {
            bool ok = false;
            if(v1 is not null && v2 is not null)
            {
                if (v1.codigoDeViaje == v2.codigoDeViaje)
                {
                    ok = true;
                }
            }
            return ok;
        }

        public static bool operator !=(Viaje v1, Viaje v2)
        {
            return !(v1 == v2);
        }

        public List<Pasajero> Pasajeros
        {
            get
            {
                return this.pasajeros;
            }
            
            // Solo para el hardcodeo
            set
            {
                this.pasajeros = value;
            }
        }
        public string Matricula
        {
            get
            {
                return this.matriculaCrucero;
            }
        }
        public int DuracionViaje
        {
            get
            {
                return this.duracionViaje;
            }
        }

        public int CamarotesTurista
        {
            get
            {
                return this.camarotesTurista;
            }
            set
            {
                this.camarotesTurista = value;
            }
        }

        public int CamarotesPremium
        {
            get
            {
                return this.camarotesPremium;
            }
            set
            {
                this.camarotesPremium = value;
            }
        }

        public string CodigoDeViaje
        {
            get
            {
                return this.codigoDeViaje;
            }
        }

        public string Origen
        {
            get
            {
                return this.ciudadDePartida;
            }
        }

        public string Destino
        {
            get
            {
                return this.ciudadDeDestino;
            }
        }

        public DateTime Fecha
        {
            get 
            {
                return this.fechaInicio;
            }
        }

        public double PrecioTurista
        {
            get
            {
                return this.costoTurista;
            }
        }

        public double PrecioPremium
        {
            get
            {
                return this.costoPremium;
            }
        }

        public int Bodega
        {
            get
            {
                return this.bodegaDisponible;
            }
            set
            {
                this.bodegaDisponible = value;
            }
        }
    }
}
