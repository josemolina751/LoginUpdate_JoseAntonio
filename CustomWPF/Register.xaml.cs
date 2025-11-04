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
    /// Lógica de interacción para Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        

        public Register()
        {
            InitializeComponent();
        }

        
        private void btnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            var Register= new MainWindow();
            Register.Show();
            this.Close();

        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            

            string nombreUsuario = txtUsuarioNuevo.Text;

            var principal = new Principal(nombreUsuario);

             if (string.IsNullOrWhiteSpace(txtUsuarioNuevo.Text))
            {
                MessageBox.Show("Por favor, ingrese un usuario.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtUsuarioNuevo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, ingrese un mail válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrasenaRegistro.Password))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtContrasenaRegistro.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRepetirContrasena.Password))
            {
                MessageBox.Show("Por favor, confirme la contraseña", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!chkTerminos.IsChecked == true)
            {
                MessageBox.Show("Debe aceptar los términos y condiciones.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            
            string usuario = txtUsuarioNuevo.Text;
            string contrasena = txtContrasenaRegistro.Password;

            MessageBox.Show($"Bienvenido, {usuario}!", "Registro Exitoso", MessageBoxButton.OK, MessageBoxImage.Information);
            principal.Show();
            this.Close();
            principal.Show();
            this.Close();
        }
        private void btnCerrar(object sender, RoutedEventArgs e)
        {

            this.Close();
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
