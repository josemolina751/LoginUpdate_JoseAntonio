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

namespace CustomWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {

            
            string nombreUsuario = txtUsuario.Text;
            var principal = new Principal(nombreUsuario);
            
            
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese un usuario.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Password))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtContrasena.Focus();
                return;
            }

            if (!chkTerminos.IsChecked == true)
            {
                MessageBox.Show("Debe aceptar los términos y condiciones.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Password;

            MessageBox.Show($"Bienvenido, {usuario}!", "Login Exitoso", MessageBoxButton.OK, MessageBoxImage.Information);
            principal.Show();
            this.Close();

        }


        private void btnRegistrarse_Click(object sender, RoutedEventArgs e)
        {

            var MainWindow = new Register();
            MainWindow.Show();
            this.Close();

        }

        
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void btnCerrar(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void chkTerminos_Checked(object sender, RoutedEventArgs e)
        {

        }

    }
}
