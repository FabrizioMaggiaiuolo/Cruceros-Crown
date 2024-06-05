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
    public partial class FrmViajes : FrmBase
    {

        public FrmViajes()
        {
            InitializeComponent();

            foreach (Viaje viaje in ListaViajes.viajes)
            {
                lstViajes.Items.Add(viaje.CodigoDeViaje);
            }
        }

        private void lstViajes_SelectedIndexChanged(object sender,EventArgs e)
        {
            foreach (Viaje viaje in ListaViajes.viajes)
            {
                if(lstViajes.SelectedIndex != -1)
                {
                    if (viaje.CodigoDeViaje == lstViajes.Items[lstViajes.SelectedIndex].ToString())
                    {
                        txtDestino.Text = viaje.Destino;
                        txtOrigen.Text = viaje.Origen;
                        txtPrecioPremium.Text = viaje.PrecioPremium.ToString();
                        txtPrecioTurista.Text = viaje.PrecioTurista.ToString();
                        txtHoraDePartida.Text = viaje.Fecha.ToShortDateString();
                        if(viaje.Fecha.Date > DateTime.Now.Date)
                        {
                            txtEstado.Text = "Disponible";
                        }
                        else
                        {
                            if(viaje.Fecha.AddHours(viaje.DuracionViaje).Date < DateTime.Now.Date)
                            {
                                txtEstado.Text = "Finalizado";
                            }
                            else
                            {
                                txtEstado.Text = "En viaje";
                            }
                        }
                    }
                }
            }
        }

        private void btnVerPasajeros_Click(object sender, EventArgs e)
        {
            if (lstViajes.SelectedIndex != -1)
            {
                FrmPasajeros frm = new FrmPasajeros();

                foreach (Viaje viaje in ListaViajes.viajes)
                {
                    if (viaje.CodigoDeViaje == lstViajes.Items[lstViajes.SelectedIndex].ToString())
                    {
                        frm.pasajeros = viaje.Pasajeros;
                    }
                }
                frm.Show();
            }
            else
            {
                MessageBox.Show("Seleccione un viaje para ver los pasajeros", "Atencion vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            FrmAgregarViaje frm = new FrmAgregarViaje();
            frm.Show();
        }

        private void btnRecargarListaViajes_Click(object sender, EventArgs e)
        {
            lstViajes.Items.Clear();
            foreach (Viaje viaje in ListaViajes.viajes)
            {
                lstViajes.Items.Add(viaje.CodigoDeViaje);
            }
        }

        private void FrmViajes_Load(object sender, EventArgs e)
        {

        }
    }
}
