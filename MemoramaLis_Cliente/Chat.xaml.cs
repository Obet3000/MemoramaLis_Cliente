using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using Logica;
using MemoramaLis_Cliente.ServicioChat;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace MemoramaLis_Cliente
{
    /// <summary>
    /// Lógica de interacción para Chat.xaml
    /// </summary>
    public partial class ChatVentana : Page, IServicioChatCallback
    {
        IServicioChat _chat;
        public ChatVentana(string codigoSala)
        {

            InitializeComponent();
            if (codigoSala == null) 
            {
                 
                string nombreChat = JugadorSingleton.ObtenerInstancia().NombreJugador;
                InstanceContext context = new InstanceContext(this);
                PartidaSingleton partidaSingleton = PartidaSingleton.ObtenerInstancia();
                partidaSingleton.codigoDePartida = nombreChat;
                _chat = new ServicioChatClient(context);
                _chat.CrearChat(nombreChat);
                _chat.UnirseAChat(JugadorSingleton.ObtenerInstancia().NombreJugador,nombreChat);
            }
            else
            {
                InstanceContext context = new InstanceContext(this);
                _chat = new ServicioChatClient(context);
                PartidaSingleton partidaSingleton = PartidaSingleton.ObtenerInstancia();
                partidaSingleton.codigoDePartida = codigoSala;
                _chat.UnirseAChat(JugadorSingleton.ObtenerInstancia().NombreJugador,codigoSala);
            }
        }

        public void RecibirMensaje(string nombreJugador, string mensaje)
        {
            TBChat.Text = (TBChat.Text+"\n"+ nombreJugador + ": "+ mensaje);   
        }

        private void BtnEnviar_Click(object sender, RoutedEventArgs e)
        {

            string nombreJugador = JugadorSingleton.ObtenerInstancia().NombreJugador;
            string codigoPartida = PartidaSingleton.ObtenerInstancia().codigoDePartida;
            string mensajeJugador = TBMensaje.Text;
            TBMensaje.Text = "";
            if (!string.IsNullOrEmpty(mensajeJugador))
            {
                try
                {
                    _chat.EnviarMensaje(mensajeJugador, nombreJugador, codigoPartida);
                }
                catch (EndpointNotFoundException)
                {
                    MessageBox.Show("Ha ocurrido un error, inicia tu sesión");  
                }
                catch (CommunicationObjectFaultedException)
                {
                    MessageBox.Show("Ha ocurrido un error al enviar el mensaje");
                }

            }

        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            _chat.SalirDelChat(JugadorSingleton.ObtenerInstancia().NombreJugador, PartidaSingleton.ObtenerInstancia().codigoDePartida);
        }


    }
}
