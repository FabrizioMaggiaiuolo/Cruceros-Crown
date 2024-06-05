using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruceros_Crown
{
    public partial class FrmHistorial : FrmBase
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            CalcularDestinoMasVendido();
            txtGananciaRegional.Text = CalcularGanancia(true).ToString();
            txtGananciaExtraRegional.Text = CalcularGanancia(false).ToString();
            ListarDestinosPorFactura();
            ListarPasajeroFrecuentes();

            foreach (Crucero crucero in ListaCruceros.cruceros)
            {
                cboCrucerosHorasTotales.Items.Add(crucero.Matricula);
            }
        }
        
        private void ListarPasajeroFrecuentes()
        {
            int frecuencia;
            
            foreach(Pasajero pasajero in ListaPasajeros.pasajeros)
            {
                frecuencia = 0;
                foreach (Viaje viajeaux in ListaViajes.viajes)
                {
                    foreach (Pasajero pasajeroaux in viajeaux.Pasajeros)
                    {
                        if(pasajero ==  pasajeroaux)
                        {
                            frecuencia++;
                        }
                    }
                }
                lstPasajerosFrecuentes.Items.Add(pasajero.Apellidos + ", " + pasajero.Nombres + " - " + frecuencia);
            }

            string[] aux = lstPasajerosFrecuentes.Items.Cast<string>().ToArray();
            lstPasajerosFrecuentes.Items.Clear();


            var aux2 = aux.OrderByDescending(item => int.Parse(item.Substring(item.ToString().IndexOf("- ") + 2)));

            foreach (var item in aux2)
            {
                lstPasajerosFrecuentes.Items.Add(item.ToString());
            }
        }
        private void ListarDestinosPorFactura()
        {
            double facturacion;
            foreach(Destino destino in ListaDestinos.destinos)
            {
                facturacion = 0;
                foreach(Viaje viaje in ListaViajes.viajes)
                {
                    if(destino.Nombre == viaje.Destino)
                    {
                        foreach (Pasajero pasajero in viaje.Pasajeros)
                        {
                            if (pasajero.TipoDePasajero == ETipoDePasajero.Turista)
                            {
                                facturacion += viaje.PrecioTurista;
                            }
                            else
                            {
                                facturacion += viaje.PrecioPremium;
                            }
                        }
                    }
                }
                lstDestinoPorFacturacion.Items.Add(destino.Nombre + " - " + facturacion);
            }

            
            string[] aux = lstDestinoPorFacturacion.Items.Cast<string>().ToArray();
            lstDestinoPorFacturacion.Items.Clear();

            
            var aux2 = aux.OrderByDescending(item => double.Parse(item.Substring(item.ToString().IndexOf("- ") + 2)));

            foreach(var item in aux2)
            {
                lstDestinoPorFacturacion.Items.Add(item.ToString());
            }
        }

        private double CalcularGanancia(bool esRegional)
        {
            double ganancia = 0;
            foreach(Viaje viaje in ListaViajes.viajes)
            {
                foreach(Destino destino in ListaDestinos.destinos)
                {
                    if (destino.Nombre == viaje.Destino)
                    {
                        if(destino.EsRegional == esRegional)
                        {
                            foreach(Pasajero pasajero in viaje.Pasajeros)
                            {
                                if(pasajero.TipoDePasajero == ETipoDePasajero.Turista)
                                {
                                    ganancia += viaje.PrecioTurista;
                                }
                                else
                                {
                                    ganancia += viaje.PrecioPremium;
                                }
                            }
                        }
                    }
                }
            }
            return ganancia;
        }
        private void CalcularDestinoMasVendido()
        {
            string destinoMasVentas = "";
            int cantidadDeVentas = 0;
            int cantidadDeVentasAux;

            foreach(Destino destino in ListaDestinos.destinos)
            {
                cantidadDeVentasAux = 0;

                foreach(Viaje viaje in ListaViajes.viajes)
                {
                    if(destino.Nombre == viaje.Destino)
                    {
                        cantidadDeVentasAux += viaje.Pasajeros.Count();
                        if(cantidadDeVentasAux > cantidadDeVentas)
                        {
                            cantidadDeVentas = cantidadDeVentasAux;
                            destinoMasVentas = destino.Nombre;
                        }
                    }
                }
            }

            txtDestinoMasVendido.Text = destinoMasVentas;
        }

        private void cboCrucerosHorasTotales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidadDeHoras = 0;
            foreach (Crucero crucero in ListaCruceros.cruceros)
            {
                if(crucero.Matricula == cboCrucerosHorasTotales.SelectedItem.ToString())
                {

                    foreach(Viaje viaje in ListaViajes.viajes)
                    { 
                        if(crucero.Matricula == viaje.Matricula)
                        {
                            cantidadDeHoras += viaje.DuracionViaje;
                        }
                    }

                    break;

                }
            }
            txtHorasTotalesCrucero.Text = cantidadDeHoras.ToString();
        }

    }
}
