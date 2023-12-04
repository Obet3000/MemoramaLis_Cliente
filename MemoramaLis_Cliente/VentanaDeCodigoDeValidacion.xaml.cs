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
    public partial class VentanaIngresaCodigoDeValidacion : Window
    {
        public int CodigoValidacion { get; private set; }
        

        public VentanaIngresaCodigoDeValidacion()
        {
            InitializeComponent();
            CodigoValidacion = -1;
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            string codigoStr = TBCodigo.Text;

            if (EsCodigoValido(codigoStr))
            {
                if (int.TryParse(codigoStr, out int codigoParseado))
                {
                    CodigoValidacion = codigoParseado;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al convertir el código a un número, intentanlo nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código válido de 6 caracteres numéricos.");
            }
        }

        private bool EsCodigoValido(string codigo)
        {
            return !string.IsNullOrEmpty(codigo) && codigo.Length == 6 && codigo.All(char.IsDigit);
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            CodigoValidacion = -1;
            this.Close();
        }


    }
}
