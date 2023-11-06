using System;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;
using MemoramaLis_Cliente.AutentificacionServicio;
using static MemoramaLis_Cliente.Utilidades;
using Logica;
using System.Runtime.Remoting.Contexts;

namespace MemoramaLis_Cliente
{
    public partial class MainWindow : Page, IAutentificacionServicioCallback
    {
        private IAutentificacionServicio _servicio;
        private InstanceContext context;
        public MainWindow()
        {
            InitializeComponent();
            
            context = new InstanceContext(this);
          
        }
        public void RespuestaAutentificacion(JugadoresDTO jugador)
        {
            if (jugador.Email != null)
            {
                JugadorSingleton.ObtenerInstancia().Email= jugador.Email;
                JugadorSingleton.ObtenerInstancia().EstadoJugador = true;
                JugadorSingleton.ObtenerInstancia().NombreJugador = jugador.NombreJugador;
                MenuInicial menuInicial = new MenuInicial();
                this.NavigationService.Navigate(menuInicial);

            }
            else
            {
                MessageBox.Show("El email o el usuario es erróneo.");
            }
        }

        public void RespuestaEmail(string codigoVerificacíon)
        {
            throw new NotImplementedException();
        }

        public void Respuestaregistro(bool estado)
        {
            throw new NotImplementedException();
        }

        public void RespuestaUsuarioExistente(bool status)
        {
            throw new NotImplementedException();
        }


        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            string usuario = TBEmail.Text;
            string contrasenia = PBContrasenia.Password;
            try
            {
                _servicio = new AutentificacionServicioClient(context);
                _servicio.AutentificacionUsuario(usuario, HashContrasenia(contrasenia));
                _servicio = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Registrarse_Click(object sender, RoutedEventArgs e)
        {
            RegistroDeJugadores registroDeJugadores = new RegistroDeJugadores();
            this.NavigationService.Navigate(registroDeJugadores);
        }
    }
}
