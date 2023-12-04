using Logica;
using MemoramaLis_Cliente.ServicioChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MemoramaLis_Cliente
{
    /// <summary>
    /// Lógica de interacción para MenuInicial.xaml
    /// </summary>
    public partial class MenuInicial : Page
    {
      
        public MenuInicial()
        {
            InitializeComponent();
            string nombreChat = JugadorSingleton.ObtenerInstancia().NombreJugador;
            LNombreJugador.Content = nombreChat;
            
        }


        private void BtnCrearChat_Click(object sender, RoutedEventArgs e)
        {      
            ChatVentana chatVentana = new ChatVentana(null);
            this.NavigationService.Navigate(chatVentana);

        }

        private void BtnUnirseAChat_Click(object sender, RoutedEventArgs e)
        {
            VentanaIngresaCodigo ventanaIngresaCodigo = new VentanaIngresaCodigo();
            ventanaIngresaCodigo.ShowDialog();
            if (ventanaIngresaCodigo.CodigoSala != null)
            {
                string codigoSala = ventanaIngresaCodigo.CodigoSala;
                ChatVentana chatVentana = new ChatVentana(codigoSala);
                this.NavigationService.Navigate(chatVentana);
            }

        }

        private void BtnCrearPartida_Click(object sender, RoutedEventArgs e)
        {
            SalaDeEspera salaDeEspera = new SalaDeEspera(null);
            this.NavigationService.Navigate(salaDeEspera);

        }

        private void BtnUniserAPartida_Click(object sender, RoutedEventArgs e)
        {
            VentanaIngresaCodigo ventanaIngresaCodigo = new VentanaIngresaCodigo();
            ventanaIngresaCodigo.ShowDialog();
            if (ventanaIngresaCodigo.CodigoSala != null)
            {
                string codigoSala = ventanaIngresaCodigo.CodigoSala;
                SalaDeEspera salaDeEspera = new SalaDeEspera(codigoSala);
                this.NavigationService.Navigate(salaDeEspera);
            }
        }
    }
}
