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

namespace CustomWPF
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal(string nombreUsuario)
        {
            InitializeComponent();
            txtBienvenida.Text = $"Bienvenido {nombreUsuario}";
        }

        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            var Principal = new MainWindow();
            Principal.Show();

        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            // Lo dejo vacio por que si no salta error por no utilizarlo
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            // Lo dejo vacio por que si no salta error por no utilizarlo
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            // Lo dejo vacio por que si no salta error por no utilizarlo
        }
        private void btnRegistrarse_Click(object sender, RoutedEventArgs e)
        {
            // Lo dejo vacio por que si no salta error por no utilizarlo
        }
        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Lo dejo vacio por que si no salta error por no utilizarlo
        }


    }
}
