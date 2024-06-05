using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruceros_Crown
{
    public class Vendedor
    {
        private string usuario;
        private string contraseña;

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
        }

        public string Contraseña
        {
            get
            {
                return this.contraseña;
            }
        }

        public Vendedor(string usuario, string contraseña)
        {
            this.contraseña = contraseña;
            this.usuario = usuario;
        }
    }
}
