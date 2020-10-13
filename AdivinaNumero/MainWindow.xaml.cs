using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numeroAleatorio;

        public MainWindow()
        {
            InitializeComponent();
            numeroAleatorio = NumeroAleatorio();
        }

        private int NumeroAleatorio()
        {
            Random rng = new Random();
            return rng.Next(1, 101);
        }


        private void ComprobarButton_Click(object sender, RoutedEventArgs e)
        {
            int numeroUsuario = int.Parse(numeroTextBox.Text);

            if(numeroUsuario < numeroAleatorio)
            {
                respuestaTextBlock.Text = "Te has quedado corto";
            }
            else if(numeroUsuario > numeroAleatorio)
            {
                respuestaTextBlock.Text = "Te has pasado";
            }
            else
            {
                respuestaTextBlock.Text = "¡Has acertado!";
            }
        }
        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroAleatorio = NumeroAleatorio();
            numeroTextBox.Text = "";
            respuestaTextBlock.Text = "";
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
