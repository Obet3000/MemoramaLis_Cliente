using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PartidaSingleton
    {
        private static PartidaSingleton _PartidaIniciada;
        private static readonly object bloqueo = new object();

        public string codigoDePartida { get; set; }
        public bool tipoDeJuego { get; set; }
        public int numeroDeJugadores { get; set; }
        public Dictionary<int, string> tablero { get; set; }
        private PartidaSingleton()
        {
        }

        public static PartidaSingleton ObtenerInstancia()
        {
            if (_PartidaIniciada == null)
            {
                lock (bloqueo)
                {
                    if (_PartidaIniciada == null)
                    {
                        _PartidaIniciada = new PartidaSingleton();
                    }
                }
            }
            return _PartidaIniciada;
        }
    }
}
