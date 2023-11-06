using Logica;
using MemoramaLis_Cliente.ServicioChat;
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
using System.Windows.Shapes;

namespace MemoramaLis_Cliente
{
    /// <summary>
    /// Lógica de interacción para VentanaIngresaCodigo.xaml
    /// </summary>
    public partial class VentanaIngresaCodigo : Window
    {
        public string CodigoSala { get; private set; }

        public VentanaIngresaCodigo()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            CodigoSala = TBCodigo.Text;
            this.Close();  
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            CodigoSala = null;
        }

   
    }
}
