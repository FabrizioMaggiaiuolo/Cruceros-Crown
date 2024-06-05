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
    public partial class FrmVenderViaje : FrmBase
    {
        private List<Pasajero> lista = new List<Pasajero>();
        public FrmVenderViaje()
        {
            InitializeComponent();

            foreach (Viaje viaje in ListaViajes.viajes)
            {
                if(viaje.Fecha > DateTime.Now.Date)
                {
                    lstViajeVender.Items.Add(viaje.CodigoDeViaje);
                }
            }

        }


        private void lstViajeVender_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Viaje viaje in ListaViajes.viajes)
            {
                if (lstViajeVender.SelectedIndex != -1)
                {
                    if (viaje.CodigoDeViaje == lstViajeVender.Items[lstViajeVender.SelectedIndex].ToString())
                    {
                        txtLugarDestino.Text = viaje.Destino;
                        txtLugarSalida.Text = viaje.Origen;
                        txtFechaSalida.Text = viaje.Fecha.ToShortDateString();
                    }
                }
            }
        }

        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            lstPasajeros.Items.Clear();
            foreach (Pasajero pasajero in lista)
            {
                lstPasajeros.Items.Add(pasajero.Apellidos + " " + pasajero.Nombres);
            }
        }

        private void btnAgregarPasajero_Click(object sender, EventArgs e)
        {
            FrmVenderPasajero frm = new FrmVenderPasajero(lista);

            if(frm.ShowDialog() == DialogResult.OK)
            {
                lista = frm.Pasajeros;
            }
        }

        private void btnEliminarPasajero_Click(object sender, EventArgs e)
        {
            if (lstPasajeros.SelectedIndex == -1)
            {

            }
            else
            {
                int contador = 0;
                foreach (Pasajero pasajero in lista)
                {
                    if (lstPasajeros.SelectedItem.ToString() == (pasajero.Apellidos + " " + pasajero.Nombres))
                    {
                        lista.RemoveAt(contador);
                        break;
                    }
                    contador++;
                }
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int indexViaje = 0;
            foreach(Viaje viaje in ListaViajes.viajes)
            {
                if(viaje.CodigoDeViaje == lstViajeVender.SelectedItem.ToString())
                {
                    break;
                }
                indexViaje++;
            }
            for(int i = 0; i < lista.Count();i++)
            {
                ListaViajes.viajes.ElementAt(indexViaje).Pasajeros.Add(lista.ElementAt(i));
                ListaPasajeros.pasajeros.Add(lista.ElementAt(i));
                ListaViajes.viajes.ElementAt(indexViaje).Bodega -= lista.ElementAt(i).EquipajesPeso;
                if(lista.ElementAt(i).TipoDePasajero == ETipoDePasajero.Turista)
                {
                    ListaViajes.viajes.ElementAt(indexViaje).CamarotesTurista -= 1;
                }
                else
                {
                    ListaViajes.viajes.ElementAt(indexViaje).CamarotesPremium -= 1;
                }
            }
            Close();
        }
    }
}
