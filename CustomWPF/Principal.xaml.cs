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
        public Principal()
        {
            InitializeComponent();
        }


        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            var Principal = new MainWindow();
            Principal.Show();

        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            // Aquí tu lógica de botón
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            // Aquí tu lógica para minimizar la ventana
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            // Aquí tu lógica para cerrar la ventana
        }
        private void btnRegistrarse_Click(object sender, RoutedEventArgs e)
        {
            // Aquí tu lógica para registrar usuario
        }
        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Aquí tu lógica para arrastrar la ventana (si la barra es personalizada)
        }


    }
}
