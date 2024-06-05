using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cruceros_Crown
{
    public static class ListaDestinos
    {
        public static List<Destino> destinos = new List<Destino>();

        public static void CargarLista()
        {
            ListaDestinos.destinos.Add(new Destino("Montevideo (Uruguay)",true));
            ListaDestinos.destinos.Add(new Destino("Ushuaia (Argentina)", true));
            ListaDestinos.destinos.Add(new Destino("Recife (Brasil)", true));
            ListaDestinos.destinos.Add(new Destino("Santiago (Chile)", true));
            ListaDestinos.destinos.Add(new Destino("Lima (Perú)", true));
            ListaDestinos.destinos.Add(new Destino("Isla de Pascua (Chile)", true));
            ListaDestinos.destinos.Add(new Destino("Isla Galápagos (Ecuador)", true));
            ListaDestinos.destinos.Add(new Destino("Puerto Madryn (Argentina)", true));
            ListaDestinos.destinos.Add(new Destino("Río de Janeiro (Brasil)", true));
            ListaDestinos.destinos.Add(new Destino("Cartagena (Colombia)", true));

            ListaDestinos.destinos.Add(new Destino("La Habana (Cuba)", false));
            ListaDestinos.destinos.Add(new Destino("Venecia (Italia)", false));
            ListaDestinos.destinos.Add(new Destino("Acapulco (México)", false));
            ListaDestinos.destinos.Add(new Destino("Miami (EE.UU.)", false));
            ListaDestinos.destinos.Add(new Destino("Nueva York (EE.UU.)", false));
            ListaDestinos.destinos.Add(new Destino("Bangkok (Tailandia)", false));
            ListaDestinos.destinos.Add(new Destino("Taipei (Taiwán)", false));
            ListaDestinos.destinos.Add(new Destino("Atenas (Grecia)", false));
        }
    }
    public class Destino
    {
        private string nombre;
        private bool esRegional;

        public Destino(string nombre, bool esRegional)
        {
            this.esRegional = esRegional;
            this.nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public bool EsRegional
        {
            get
            {
                return this.esRegional;
            }
        }

         
    }
}
