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
    public partial class FrmPasajeros : FrmBase
    {

        public List<Pasajero> pasajeros;
        public FrmPasajeros()
        {
            InitializeComponent();
        }

        private void FrmPasajeros_Load(object sender, EventArgs e)
        {
            foreach(Pasajero pasajero in pasajeros)
            {
                lstPasajeros.Items.Add(pasajero.Mostrar() + " | " + pasajero.Pasaporte.Numero);
            }
        }

        private void lstPasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPasajeros.SelectedIndex != -1)
            {
                int indice = lstPasajeros.Items[lstPasajeros.SelectedIndex].ToString().IndexOf("| ");

                foreach (Pasajero pasajero in pasajeros)
                {

                    if (pasajero.Pasaporte.Numero.ToString() == lstPasajeros.Items[lstPasajeros.SelectedIndex].ToString().Substring(indice + 2))
                    {
                        txtNombre.Text = pasajero.Nombres;
                        txtApellidos.Text = pasajero.Apellidos;
                        txtPasaporte.Text = pasajero.Pasaporte.Numero.ToString();
                        txtNacionalidad.Text = pasajero.Pasaporte.Nacionalidad;
                        txtCiudad.Text = pasajero.Pasaporte.Ciudad;
                        txtEdad.Text = pasajero.Edad.ToString();
                    }
                }
            }
        }
    }
}
