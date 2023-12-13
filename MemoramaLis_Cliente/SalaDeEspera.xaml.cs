using Logica;
using MemoramaLis_Cliente.ServicioChat;
using MemoramaLis_Cliente.ServicioPartida;
using System;
using System.Collections.Generic;
using System.IO.Ports;
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
    /// Lógica de interacción para SalaDeEspera.xaml
    /// </summary>
    public partial class SalaDeEspera : Page, IServicioPartidaCallback, IServicioChatCallback
    {
        IServicioChat servicioChat;
        IServicioPartida _servicioPartida;

        public SalaDeEspera(string codigoPartida)
        {
            InitializeComponent();
            if (codigoPartida == null)
            {
                string codigoNuevaPartida = JugadorSingleton.ObtenerInstancia().NombreJugador;
                InstanceContext context = new InstanceContext(this);
                JugadorSingleton.ObtenerInstancia().conexion = context;
                PartidaSingleton partidaSingleton = PartidaSingleton.ObtenerInstancia();
                partidaSingleton.codigoDePartida = codigoNuevaPartida;
                _servicioPartida = new ServicioPartidaClient(context);
                servicioChat = new ServicioChatClient(context);
                
                JugadoresDTO jugador = new JugadoresDTO()

                {
                    Fotos = Properties.Settings.Default.FotoDePerfil
                };
                jugador.NombreJugador = JugadorSingleton.ObtenerInstancia().NombreJugador;
                _servicioPartida.CrearPartida(codigoNuevaPartida);
                _servicioPartida.UnirseAPartida(jugador, codigoNuevaPartida);

                servicioChat.CrearChat(codigoNuevaPartida);
                servicioChat.UnirseAChat(jugador.NombreJugador, codigoNuevaPartida);
            }
            else if(codigoPartida != "")
            {
                InstanceContext context = new InstanceContext(this);
                _servicioPartida = new ServicioPartidaClient(context);
                servicioChat = new ServicioChatClient(context);
                PartidaSingleton partidaSingleton = PartidaSingleton.ObtenerInstancia();
                partidaSingleton.codigoDePartida = codigoPartida;
                JugadoresDTO jugador = new JugadoresDTO()
                {
                    NombreJugador = JugadorSingleton.ObtenerInstancia().NombreJugador,
                    Fotos = Properties.Settings.Default.FotoDePerfil
                };
                BtnIniciarJuego.Visibility = Visibility.Collapsed;
                _servicioPartida.UnirseAPartida(jugador, codigoPartida);
                servicioChat.UnirseAChat(jugador.NombreJugador,codigoPartida);
            }
            
        }

        public void ExpulsarJugador(string nombreJugador)
        {
            throw new NotImplementedException();
        }

        public void MostrarTerminarPartida(string[] ganadores, int puntos)
        {
            throw new NotImplementedException();
        }

        public void ObtenerJugadorReportado(bool estado)
        {
            throw new NotImplementedException();
        }

        public void ObtenerListaDeJugadores(JugadoresDTO[] jugadores)
        {
            PartidaSingleton.ObtenerInstancia().numeroDeJugadores = jugadores.Length;
            for (int i = 1; i <= jugadores.Length; i++) {
                Image imgJugador = (Image)this.FindName("ImgJugador" + i);
                imgJugador.Source = new BitmapImage(new Uri(jugadores.ElementAt(i-1).Fotos, UriKind.Relative));
                Label lbJugador = (Label)this.FindName("LBNombreJugador" + i);
                lbJugador.Content = jugadores.ElementAt(i-1).NombreJugador;
            }
        }

        public void RecibirEstadoDePartida(string codigoDeRespuesta)
        {
            if (codigoDeRespuesta == "Iniciando") 
            {
                Partida partida = new Partida();
                partida.ShowDialog();
            }
        }
        public void RecibirMovimiento(string nombreJugador, int movimiento, string resultado)
        {
            throw new NotImplementedException();
        }

        public void RecibirTablero(Dictionary<int, string> tablero)
        {
            PartidaSingleton.ObtenerInstancia().tablero = tablero;
        }

        public void RecibirTurno(int turno)
        {
            throw new NotImplementedException();
        }

        public void RespuestaDeUnirseAPartida(string codigoDeRespuesta)
        {
            if (codigoDeRespuesta == "200")
            {
                MessageBox.Show("Haz entrado exitosamente");
            }
            else if(codigoDeRespuesta == "409") 
            {
                MessageBox.Show("La partida se encuentra llena");
                this.NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("No fue posible unirse a la partida en estos momentos");
                this.NavigationService.GoBack();
            }
        }

        private void IniciarPartida_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(PartidaSingleton.ObtenerInstancia().numeroDeJugadores > 1) {
                    _servicioPartida.IniciarJuego(PartidaSingleton.ObtenerInstancia().codigoDePartida);
                }
                else
                {
                    MessageBox.Show("Aún faltan jugadores");
                }
            }
            catch (CommunicationObjectAbortedException)
            {
                MessageBox.Show("No fue posible iniciar el juego en esté momento");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _servicioPartida.SalirDePartida(JugadorSingleton.ObtenerInstancia().NombreJugador,PartidaSingleton.ObtenerInstancia().codigoDePartida);
            PartidaSingleton.ObtenerInstancia().codigoDePartida = null;
            PartidaSingleton.ObtenerInstancia().tablero = null;
            PartidaSingleton.ObtenerInstancia().numeroDeJugadores = 0;
            PartidaSingleton.ObtenerInstancia().tipoDeJuego = false;
            this.NavigationService.GoBack();
        }

        public void RecibirMensaje(string nombreJugador, string mensaje)
        {
            TBChat.Text = (TBChat.Text + "\n" + nombreJugador + ": " + mensaje);
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
                    servicioChat.EnviarMensaje(mensajeJugador, nombreJugador, codigoPartida);
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

        public void RecibirGanador(JugadoresDTO ganador)
        {
            throw new NotImplementedException();
        }
    }
}
