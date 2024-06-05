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
    public partial class FrmVenderPasajero : FrmBase
    {
        private List<Pasajero> lista;
        public FrmVenderPasajero(List<Pasajero> pasajeros)
        {
            InitializeComponent();
            lista = pasajeros;
        }
        public List<Pasajero> Pasajeros
        {
            get
            {
                return this.lista;
            }
        }
        private void FrmVenderPasajero_Load(object sender, EventArgs e)
        {
            radTurista.Checked = true;
        }

        private void radTurista_CheckedChanged(object sender, EventArgs e)
        {
            if(radTurista.Checked)
            {
                txtValija2.Visible = false;
                chbValija2.Visible = false;
                lblValija2.Visible = false;
                chbValija2.Checked = false;
                txtValija2.Clear();
            }
        }

        private void radPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (radPremium.Checked)
            {
                txtValija2.Visible = true;
                chbValija2.Visible = true;
                lblValija2.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int aux;
            if(txtApellido.Text != "" && txtNombre.Text != "" && txtNacionalidad.Text != "" && txtCiudad.Text != "" && txtPasaporte.Text != "" && txtEdad.Text != "")
            {
                if(int.TryParse(txtEdad.Text,out aux) && aux<125 && int.TryParse(txtPasaporte.Text,out aux) && (aux>9999999 && aux<100000000))
                {
                    if(!(chbValija1.Checked == false || txtValija1.Text == "" || !int.TryParse(txtValija1.Text,out aux)) || !(chbValija2.Checked == false || txtValija2.Text == "" || !int.TryParse(txtValija2.Text, out aux)) || ((chbValija1.Checked == false && txtValija1.Text == "") && (chbValija2.Checked == false && txtValija2.Text == "")))
                    {
                        ETipoDePasajero tipoDePasajero = ETipoDePasajero.Turista;
                        List<Equipaje> equipaje = new List<Equipaje>();

                        if (radPremium.Checked)
                        {
                            tipoDePasajero = ETipoDePasajero.Premium;
                        }

                        if (chbBolsoDeMano.Checked)
                        {
                            equipaje.Add(new EquipajeDeMano());
                        }
                        if (chbValija1.Checked)
                        {
                            equipaje.Add(new Valija(int.Parse(txtValija1.Text)));
                        }
                        if (chbValija2.Checked)
                        {
                            equipaje.Add(new Valija(int.Parse(txtValija2.Text)));
                        }

                        lista.Add(new Pasajero(txtNombre.Text, txtApellido.Text, txtNacionalidad.Text, txtCiudad.Text, int.Parse(txtPasaporte.Text), short.Parse(txtEdad.Text), equipaje, tipoDePasajero));
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Revise los datos de su equipaje", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Asegurese de que su edad o pasaporte sean datos numericos validos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se lleno alguno de los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
