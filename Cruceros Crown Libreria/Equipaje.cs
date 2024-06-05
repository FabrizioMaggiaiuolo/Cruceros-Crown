using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruceros_Crown
{
    public class Equipaje
    {
        private EEquipajes tipo;

        public Equipaje(EEquipajes tipo)
        {
            this.tipo = tipo;
        }

        public EEquipajes TipoDeEquipaje
        {
            get
            {
                return this.tipo;
            }
        }
    }

    public class EquipajeDeMano : Equipaje
    {
        public EquipajeDeMano() : base(EEquipajes.Mano)
        {

        }
    }

    public class Valija : Equipaje
    {
        private int peso;

        public Valija(int peso) : base(EEquipajes.Bodega)
        {
            this.peso = peso;
        }

        public int Peso
        {
            get
            {
                return this.peso;
            }
        }
    }
}
