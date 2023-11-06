using MemoramaLis_Cliente.AutentificacionServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
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
using static MemoramaLis_Cliente.Utilidades;
namespace MemoramaLis_Cliente
{
    /// <summary>
    /// Lógica de interacción para RegistroDeJugadores.xaml
    /// </summary>
    public partial class RegistroDeJugadores : Page, IAutentificacionServicioCallback
    {

        private IAutentificacionServicio _servicio;

        public RegistroDeJugadores()
        {
            InitializeComponent();
            _servicio = new AutentificacionServicioClient(new InstanceContext(this));
        }

        public void RespuestaAutentificacion(JugadoresDTO jugador)
        {
            throw new NotImplementedException();
        }

        public void RespuestaEmail(string codigoVerificacíon)
        {
            throw new NotImplementedException();
        }

        public void Respuestaregistro(bool estado)
        {
            if (estado == true) {
                MessageBox.Show("Usuario registrado exitosamente");
            }
        }

        public void RespuestaUsuarioExistente(bool status)
        {
            throw new NotImplementedException();
        }

        public void RegistrarJugador()
        {
            try
            {
                JugadoresDTO jugador = new JugadoresDTO();
                jugador.Contrasenia = HashContrasenia(PBContrasenia.Password);
                jugador.NombreJugador = TBNombreUsuario.Text;
                string email = TBEmail.Text;

                if (ValidarCorreoElectronico(email))
                {
                    jugador.Email = email;
                    if (PBContrasenia.Password == PBConfirmacionContrasenia.Password && ValidarContraseniaSegura(PBContrasenia.Password))
                    {
                        _servicio.RegistroJugador(jugador);
                    }
                    else
                    {
                        MessageBox.Show("Las contraseña debe tener una longitud mínima de 8 caracteres, incluir al menos una mayúscula, 1 minúscula y 1 signo");
                    }
                }
                else
                {
                    MessageBox.Show("El correo ingresado no es válido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar al jugador: {ex.Message}");
            }
        }

        private bool ValidarContraseniaSegura(string contrasenia)
        {
            return Regex.IsMatch(contrasenia, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$");
        }

        private bool ValidarCorreoElectronico(string email)
        {
            string patronCorreo = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";
            if (Regex.IsMatch(email, patronCorreo))
            {
                return true;
            }
            else
            {
                
                return false;
            }
        }

        private void ButtonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegistrarJugador();
        }
        
    }
}
