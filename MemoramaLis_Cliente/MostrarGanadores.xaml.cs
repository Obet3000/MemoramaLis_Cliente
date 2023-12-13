using MemoramaLis_Cliente.ServicioPartida;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Lógica de interacción para MostrarGanadores.xaml
    /// </summary>
    public partial class MostrarGanadores : Page
    {
        public MostrarGanadores(JugadoresDTO ganador)
        {
            InitializeComponent();
            ImgGanador.Source = new BitmapImage(new Uri(ganador.Fotos, UriKind.Relative));
            TBPuntuacion.Text = ""+ganador.puntos;
        }
    }
}
