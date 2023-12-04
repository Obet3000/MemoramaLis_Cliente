using System;
using System.ServiceModel;

namespace Logica
{
    public class JugadorSingleton
    {
        private static JugadorSingleton _jugadorIniciado;
        private static readonly object bloqueo = new object();

        public string NombreJugador { get; set; }
        public string Email { get; set; }
        public int Puntuacion { get; set; }
        public bool EstadoJugador { get; set; }

        public InstanceContext conexion { get; set; } 
        private JugadorSingleton()
        {
        }

        public static JugadorSingleton ObtenerInstancia()
        {
            if (_jugadorIniciado == null)
            {
                lock (bloqueo)
                {
                    if (_jugadorIniciado == null)
                    {
                        _jugadorIniciado = new JugadorSingleton();
                    }
                }
            }
            return _jugadorIniciado;
        }
    }
}
