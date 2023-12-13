using Logica;
using MemoramaLis_Cliente.ServicioPartida;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    /// Lógica de interacción para Partida.xaml
    /// </summary>
    public partial class Partida : Window, IServicioPartidaCallback
    {
        IServicioPartida _servicioPartida;
        string comparador = null;
        int movimientoAnterior = 0;
        private int turno = 0;
        private int cartasSeleccionada = 0;
        int turnoPartida = 0;
        public Partida()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
            InstanceContext context = new InstanceContext(this);
            _servicioPartida = new ServicioPartidaClient(context);
            JugadoresDTO jugador = new JugadoresDTO();
            jugador.NombreJugador = JugadorSingleton.ObtenerInstancia().NombreJugador;
            _servicioPartida.ActualizarInformacionDeJugador(jugador, PartidaSingleton.ObtenerInstancia().codigoDePartida);
        }

       
        private void SeleccionarCarta(int numero)
        {
            string direccionRelativa = @"../../Imagenes/";
            string path = System.IO.Path.Combine(direccionRelativa, PartidaSingleton.ObtenerInstancia().tablero.ElementAt(numero-1).Value);

            Image imgCarta = (Image)this.FindName("ImgCarta" + numero);

            if (imgCarta != null)
            {
                imgCarta.Source = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
            }
            else
            {

            }
        }
        
        private void TaparCartas(int movimiento1, int movimiento2)
        {
            string direccionRelativa = @"../../Imagenes/";
            string path = System.IO.Path.Combine(direccionRelativa, "ReversoCarta.png");
            Image imgCarta = (Image)this.FindName("ImgCarta" + movimiento1);
            Image imgCarta2 = (Image)this.FindName("ImgCarta" + movimiento2);
            Button button = (Button)this.FindName("Btn"+movimiento1);
            Button button2 = (Button)this.FindName("Btn" + movimiento2);
            if (imgCarta != null && imgCarta2 != null)
            {
                imgCarta.Source = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
                imgCarta2.Source = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
                button.IsEnabled = true;
                button2.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (turno == turnoPartida && cartasSeleccionada < 2)
            {
                    cartasSeleccionada++;
                    Button clickedButton = sender as Button;

                    if (clickedButton != null)
                    {

                        string nombreDeBoton = clickedButton.Name;
                        string numeroDeBoton = new string(nombreDeBoton.Where(char.IsDigit).ToArray());
                        if (int.TryParse(numeroDeBoton, out int numeroDeCarta))
                        {
                            string cartaSeleccionada = PartidaSingleton.ObtenerInstancia().tablero.ElementAt(numeroDeCarta - 1).Value;
                            if (comparador == null)
                            {
                                comparador = cartaSeleccionada;
                                _servicioPartida.EnviarMovimiento(numeroDeCarta, JugadorSingleton.ObtenerInstancia().NombreJugador, PartidaSingleton.ObtenerInstancia().codigoDePartida, "Espera", "A");
                            }
                            else
                            {
                                if (comparador.Equals(cartaSeleccionada))
                                {
                                    _servicioPartida.EnviarMovimiento(numeroDeCarta, JugadorSingleton.ObtenerInstancia().NombreJugador, PartidaSingleton.ObtenerInstancia().codigoDePartida, "Asertado", "B");
                                    comparador = null;
                                }
                                else
                                {
                                    _servicioPartida.EnviarMovimiento(numeroDeCarta, JugadorSingleton.ObtenerInstancia().NombreJugador, PartidaSingleton.ObtenerInstancia().codigoDePartida, "Fallado", "C");
                                    comparador = null;
                                }
                            }
                            clickedButton.IsEnabled = false;
                        }

                    }              
            }
            else
            {
                MessageBox.Show("Ha acabado tu turno");

            }
        }

        public void RecibirTablero(Dictionary<int, string> tablero)
        {
            throw new NotImplementedException();
        }

        

        public void ExpulsarJugador(string nombreJugador)
        {
            throw new NotImplementedException();
        }

        public void ObtenerListaDeJugadores(JugadoresDTO[] jugadores)
        {
            for (int i = 1; i <= jugadores.Length; i++)
            {
                Image imgJugador = (Image)this.FindName("ImgJugador" + i);
                imgJugador.Source = new BitmapImage(new Uri(jugadores.ElementAt(i - 1).Fotos, UriKind.Relative));
                Label lbJugador = (Label)this.FindName("LBNombreJugador" + i);
                lbJugador.Content = jugadores.ElementAt(i - 1).NombreJugador;
                if (jugadores.ElementAt(i-1).NombreJugador == JugadorSingleton.ObtenerInstancia().NombreJugador)
                {
                    turno = i - 1;
                }
            }
        }

        public void ObtenerJugadorReportado(bool estado)
        {
            throw new NotImplementedException();
        }

        public void RespuestaDeUnirseAPartida(string codigoDeRespuesta)
        {
            throw new NotImplementedException();
        }

        public void MostrarTerminarPartida(string[] ganadores, int puntos)
        {
            throw new NotImplementedException();
        }

        public void RecibirEstadoDePartida(string codigoDeRespuesta)
        {
            throw new NotImplementedException();
        }

        public async void RecibirMovimiento(string nombreJugador, int movimiento, string resultado)
        {
            if (resultado.Equals("Asertado"))
            {
                SeleccionarCarta(movimiento);
                MessageBox.Show(nombreJugador + " suma un punto.", "Punto", MessageBoxButton.OK, MessageBoxImage.Information);
                movimientoAnterior = 0;
                cartasSeleccionada = 0;
            }
            else 
            {
                if (resultado.Equals("Fallado"))
                {
                    SeleccionarCarta(movimiento);

                    await Task.Delay(2000);

                    TaparCartas(movimiento, movimientoAnterior);
                    if (turno == turnoPartida && movimientoAnterior != 0)
                    {
                        _servicioPartida.PasarTurno(turno, PartidaSingleton.ObtenerInstancia().codigoDePartida);

                    }
                    movimientoAnterior = 0;
                    
                }
                else
                {
                    SeleccionarCarta(movimiento);
                    movimientoAnterior = movimiento;
                }
            }
            
        }

        public void RecibirTurno(int turno)
        {
            turnoPartida = turno;
            cartasSeleccionada = 0;
            
   //       MessageBox.Show("Es tú turno");
            
            //Iniciar el timer
        }

        public void RecibirGanador(JugadoresDTO ganador)
        {
            ;
        }
    }
}
