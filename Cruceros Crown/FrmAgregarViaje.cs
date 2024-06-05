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
    public partial class FrmAgregarViaje : FrmBase
    {
        public FrmAgregarViaje()
        {
            InitializeComponent();
        }

        private void FrmAgregarViaje_Load(object sender, EventArgs e)
        {
            foreach (Crucero crucero in ListaCruceros.cruceros)
            {
                lstCruceros.Items.Add(crucero.ToString());
            }

            foreach(Destino destino in ListaDestinos.destinos)
            {
                cboDestino.Items.Add(destino.Nombre);
                cboPartida.Items.Add(destino.Nombre);
            }
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            if (lstCruceros.SelectedIndex != -1)
            {
                if(cboPartida.Text != "" && cboDestino.Text != "")
                {
                    if (cboDestino.Text != cboPartida.Text)
                    {
                        if(dateTimePicker1.Value.Date > DateTime.Today)
                        {
                            if (MessageBox.Show("Esta seguros que quiere agregar el viaje?", "Atencion vendedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                Crucero cruceroAux;
                                int indice = lstCruceros.Items[lstCruceros.SelectedIndex].ToString().IndexOf("| ");

                                foreach (Crucero crucero in ListaCruceros.cruceros)
                                {

                                    if (crucero.Matricula == lstCruceros.Items[lstCruceros.SelectedIndex].ToString().Substring(indice + 2))
                                    {
                                        cruceroAux = crucero;
                                        bool esRegional = false;
                                        foreach (Destino destino in ListaDestinos.destinos)
                                        {
                                            if (cboDestino.Text == destino.Nombre && destino.EsRegional == true)
                                            {
                                                foreach (Destino partida in ListaDestinos.destinos)
                                                {
                                                    if (cboDestino.Text == partida.Nombre && partida.EsRegional == true)
                                                    {
                                                        esRegional = true;
                                                    }
                                                }
                                            }
                                        }
                                        ListaViajes.viajes.Add(new Viaje(txtCodigoDeViaje.Text, cboPartida.Text, cboDestino.Text, dateTimePicker1.Value.Date, cruceroAux.Matricula, cruceroAux.Camarotes, esRegional, cruceroAux.BodegaKG));
                                        this.Close();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("La fecha de salida no puede ser hoy ni dias anteriores", "Atencion vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un destino distinto al punto de partida", "Atencion vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else 
                {
                MessageBox.Show("Los parametros de 'Destino' y 'Salida' no pueden estar vacios, por favor seleccione alguna opcion", "Atencion vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un crucero para el viaje", "Atencion vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
