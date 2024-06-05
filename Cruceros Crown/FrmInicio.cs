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
    public partial class FrmInicio : Form
    {
        private List<Vendedor> Vendedores;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vendedores = new List<Vendedor>();
            Vendedores.Add(new Vendedor("Roman", "1234"));
            Vendedores.Add(new Vendedor("Marcelo", "4321"));
            Vendedores.Add(new Vendedor("Juan", "111"));
            Vendedores.Add(new Vendedor("Marcos", "666"));
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            bool ok = false;

            foreach(Vendedor vendedor in this.Vendedores)
            {
                if(vendedor.Usuario == txtNombre.Text && vendedor.Contraseña == txtContraseña.Text)
                {
                    FrmMenu frm = new FrmMenu(vendedor.Usuario);
                    frm.Show();
                    ok = true;
                    this.Hide();
                }
            }
            if(ok == false && txtContraseña.Text.Length > 0 && txtNombre.Text.Length > 0)
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
