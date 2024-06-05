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
    public partial class FrmMenu : FrmBase
    {

        public static void Hardcodeo()
        {
            //Lista Cruceros
            ListaCruceros.cruceros.Add(new Crucero("ASDFW01", "Crustacio I", 50, 1, 0, 500));
            ListaCruceros.cruceros.Add(new Crucero("ASDFW02", "Crustacio III", 100, 2, 1, 1000));
            ListaCruceros.cruceros.Add(new Crucero("ASDFW03", "Crustacio III", 200, 4, 1, 3500));
            ListaCruceros.cruceros.Add(new Crucero("ASDFW04", "Crustacio IV", 500, 6, 2, 8000));
            ListaCruceros.cruceros.Add(new Crucero("BSDFW01", "Arenita I", 20, 1, 0, 300));
            ListaCruceros.cruceros.Add(new Crucero("BSDFW02", "Arenita II", 80, 2, 0, 1200));
            ListaCruceros.cruceros.Add(new Crucero("BSDFW03", "Arenita III", 290, 3, 2, 2000));
            ListaCruceros.cruceros.Add(new Crucero("BSDFW04", "Arenita IV", 800, 6, 3, 10200));

            //Lista Viajes
                //Crustacio
            ListaViajes.viajes.Add(new Viaje("A001", ListaDestinos.destinos[1].Nombre, ListaDestinos.destinos[8].Nombre, new DateTime(2020,2,20), "ASDFW01", ListaCruceros.cruceros[0].Camarotes, true, ListaCruceros.cruceros[0].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("A002", ListaDestinos.destinos[4].Nombre, ListaDestinos.destinos[5].Nombre, new DateTime(2021, 3, 5), "ASDFW01", ListaCruceros.cruceros[0].Camarotes, true, ListaCruceros.cruceros[0].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("A003", ListaDestinos.destinos[5].Nombre, ListaDestinos.destinos[7].Nombre, new DateTime(2022, 12, 2), "ASDFW01", ListaCruceros.cruceros[0].Camarotes, true, ListaCruceros.cruceros[0].BodegaKG));

            ListaViajes.viajes.Add(new Viaje("A021", ListaDestinos.destinos[1].Nombre, ListaDestinos.destinos[2].Nombre, new DateTime(2020, 6, 28), "ASDFW02", ListaCruceros.cruceros[1].Camarotes, true, ListaCruceros.cruceros[1].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("A022", ListaDestinos.destinos[4].Nombre, ListaDestinos.destinos[1].Nombre, new DateTime(2019, 5, 3), "ASDFW02", ListaCruceros.cruceros[1].Camarotes, true, ListaCruceros.cruceros[1].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("A023", ListaDestinos.destinos[5].Nombre, ListaDestinos.destinos[3].Nombre, new DateTime(2022, 12, 24), "ASDFW02", ListaCruceros.cruceros[1].Camarotes, true, ListaCruceros.cruceros[1].BodegaKG));

            ListaViajes.viajes.Add(new Viaje("A031", ListaDestinos.destinos[1].Nombre, ListaDestinos.destinos[3].Nombre, new DateTime(2023, 2, 20), "ASDFW03", ListaCruceros.cruceros[2].Camarotes, true, ListaCruceros.cruceros[2].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("A032", ListaDestinos.destinos[4].Nombre, ListaDestinos.destinos[6].Nombre, new DateTime(2023, 6, 3), "ASDFW03", ListaCruceros.cruceros[2].Camarotes, true, ListaCruceros.cruceros[2].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("A033", ListaDestinos.destinos[5].Nombre, ListaDestinos.destinos[6].Nombre, new DateTime(2020, 2, 6), "ASDFW03", ListaCruceros.cruceros[2].Camarotes, true, ListaCruceros.cruceros[2].BodegaKG));

            ListaViajes.viajes.Add(new Viaje("A041", ListaDestinos.destinos[1].Nombre, ListaDestinos.destinos[3].Nombre, new DateTime(2022, 12, 20), "ASDFW04", ListaCruceros.cruceros[3].Camarotes, true, ListaCruceros.cruceros[3].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("A042", ListaDestinos.destinos[4].Nombre, ListaDestinos.destinos[6].Nombre, new DateTime(2022, 12, 28), "ASDFW04", ListaCruceros.cruceros[3].Camarotes, true, ListaCruceros.cruceros[3].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("A043", ListaDestinos.destinos[5].Nombre, ListaDestinos.destinos[6].Nombre, new DateTime(2020, 5, 20), "ASDFW04", ListaCruceros.cruceros[3].Camarotes, true, ListaCruceros.cruceros[3].BodegaKG));

            //Arenita
            ListaViajes.viajes.Add(new Viaje("B001", ListaDestinos.destinos[3].Nombre, ListaDestinos.destinos[11].Nombre, new DateTime(2018, 2, 25), "BSDFW01", ListaCruceros.cruceros[4].Camarotes, false, ListaCruceros.cruceros[4].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("B002", ListaDestinos.destinos[4].Nombre, ListaDestinos.destinos[15].Nombre, new DateTime(2020, 2, 15), "BSDFW01", ListaCruceros.cruceros[4].Camarotes, false, ListaCruceros.cruceros[4].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("B003", ListaDestinos.destinos[5].Nombre, ListaDestinos.destinos[17].Nombre, new DateTime(2023, 6, 20), "BSDFW01", ListaCruceros.cruceros[4].Camarotes, false, ListaCruceros.cruceros[4].BodegaKG));

            ListaViajes.viajes.Add(new Viaje("B021", ListaDestinos.destinos[1].Nombre, ListaDestinos.destinos[16].Nombre, new DateTime(2026, 2, 23), "BSDFW02", ListaCruceros.cruceros[5].Camarotes, false, ListaCruceros.cruceros[5].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("B022", ListaDestinos.destinos[3].Nombre, ListaDestinos.destinos[12].Nombre, new DateTime(2024, 3, 15), "BSDFW02", ListaCruceros.cruceros[5].Camarotes, false, ListaCruceros.cruceros[5].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("B023", ListaDestinos.destinos[5].Nombre, ListaDestinos.destinos[13].Nombre, new DateTime(2023, 2, 4), "BSDFW02", ListaCruceros.cruceros[5].Camarotes, false, ListaCruceros.cruceros[5].BodegaKG));

            ListaViajes.viajes.Add(new Viaje("B031", ListaDestinos.destinos[6].Nombre, ListaDestinos.destinos[13].Nombre, new DateTime(2022, 2, 20), "BSDFW03", ListaCruceros.cruceros[6].Camarotes, false, ListaCruceros.cruceros[6].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("B032", ListaDestinos.destinos[5].Nombre, ListaDestinos.destinos[16].Nombre, new DateTime(2022, 5, 28), "BSDFW03", ListaCruceros.cruceros[6].Camarotes, false, ListaCruceros.cruceros[6].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("B033", ListaDestinos.destinos[7].Nombre, ListaDestinos.destinos[16].Nombre, new DateTime(2022, 12, 20), "BSDFW03", ListaCruceros.cruceros[6].Camarotes, false, ListaCruceros.cruceros[6].BodegaKG));

            ListaViajes.viajes.Add(new Viaje("B041", ListaDestinos.destinos[9].Nombre, ListaDestinos.destinos[14].Nombre, new DateTime(2020, 2, 20), "BSDFW04", ListaCruceros.cruceros[7].Camarotes, false, ListaCruceros.cruceros[7].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("B042", ListaDestinos.destinos[4].Nombre, ListaDestinos.destinos[15].Nombre, new DateTime(2022, 2, 20), "BSDFW04", ListaCruceros.cruceros[7].Camarotes, false, ListaCruceros.cruceros[7].BodegaKG));
            ListaViajes.viajes.Add(new Viaje("B043", ListaDestinos.destinos[11].Nombre, ListaDestinos.destinos[9].Nombre, new DateTime(2026, 2, 20), "BSDFW04", ListaCruceros.cruceros[7].Camarotes, false, ListaCruceros.cruceros[7].BodegaKG));

            //Listas de pasajeros
            List<Equipaje> equipajes = new List<Equipaje> { new EquipajeDeMano(), new Valija(20) };
            List<Equipaje> equipajes2 = new List<Equipaje> { new EquipajeDeMano(), new Valija(20) };

            ListaPasajeros.pasajeros += new Pasajero("German", "Garmendia", "Italia", "Roma 1008", 20003947, 20, equipajes, ETipoDePasajero.Turista);
            ListaPasajeros.pasajeros += new Pasajero("German", "Garmendia", "Italia", "Roma 1008", 20003947, 20, equipajes, ETipoDePasajero.Turista);
            ListaPasajeros.pasajeros += new Pasajero("Manuel", "Gonzalez", "Argentina", "Rivadavia 1008", 25005347, 20, equipajes2, ETipoDePasajero.Premium);
            ListaPasajeros.pasajeros += new Pasajero("Martin", "Gomez", "Italia", "Roma 1658", 20003447, 20, equipajes, ETipoDePasajero.Turista);
            ListaPasajeros.pasajeros += new Pasajero("Marcela", "Gonzalez", "Argentina", "Rivadavia 1408", 235353947, 20, equipajes, ETipoDePasajero.Turista);
            
            ListaPasajeros.pasajeros += new Pasajero("Osmar", "Gomez", "Italia", "Roma 288", 20003427, 20, equipajes2, ETipoDePasajero.Premium);
            ListaPasajeros.pasajeros += new Pasajero("Omar", "Gonzalez", "Argentina", "Rivadavia 1029", 20003437, 20, equipajes, ETipoDePasajero.Turista);
            ListaPasajeros.pasajeros += new Pasajero("Maximo", "Gomez", "Italia", "Roma 18", 20003537, 20, equipajes, ETipoDePasajero.Turista);
            ListaPasajeros.pasajeros += new Pasajero("Mauro", "Lombardo", "Italia", "Roma 8", 2000353547, 20, equipajes2, ETipoDePasajero.Premium);
            ListaPasajeros.pasajeros += new Pasajero("Martin", "Gonzalez", "Argentina", "Rivadavia 188", 20003217, 20, equipajes2, ETipoDePasajero.Premium);
            
            ListaPasajeros.pasajeros += new Pasajero("Gonzalo", "Gonzalez", "Argentina", "Rivadavia 1238", 20032947, 20, equipajes, ETipoDePasajero.Turista);
            ListaPasajeros.pasajeros += new Pasajero("Marisa", "Suarez", "Italia", "Roma 108", 20003647, 20, equipajes, ETipoDePasajero.Turista);
            ListaPasajeros.pasajeros += new Pasajero("Martina", "Gonzalez", "Argentina", "Rivadavia 4008", 232003947, 20, equipajes, ETipoDePasajero.Turista);

            foreach(Viaje viaje in ListaViajes.viajes)
            {
                for(int i = 0; i<5;i++)
                {
                    viaje.Pasajeros += ListaPasajeros.pasajeros[i];
                }
            }

            for(int j = 6; j<22;j++)
            {
                for (int i = 5; i < 10; i++)
                {
                    ListaViajes.viajes[j].Pasajeros += ListaPasajeros.pasajeros[i];
                }
            }

            for (int j = 15; j < 23; j++)
            {
                for (int i = 10; i < 12; i++)
                {
                    ListaViajes.viajes[j].Pasajeros += ListaPasajeros.pasajeros[i];
                }
            }


        }

        public FrmMenu(string Usuario)
        {
            InitializeComponent();
            lblUsuario.Text += Usuario;

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            ListaDestinos.CargarLista();
            Hardcodeo();
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            FrmViajes frm = new FrmViajes();
            frm.Show();
        }

        private void btnVenderViaje_Click(object sender, EventArgs e)
        {
            FrmVenderViaje frm = new FrmVenderViaje();
            frm.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frm = new FrmHistorial();
            frm.Show();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
