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
using Microsoft.VisualBasic;

namespace CustomWPF
{
   
    public partial class Principal : Window
    {
        private List<Socio> socios = new List<Socio>();

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
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            // Creamos el formulario en modo NUEVO (ID editable)
            var ventana = new NuevoSocio(new Socio(), false);
            if (ventana.ShowDialog() == true)
            {
                socios.Add(ventana.NuevoSocioUsuario);       // Agregamos el nuevo socio a la lista
                dataGridSocios.ItemsSource = null;           // Refrescamos la grilla
                dataGridSocios.ItemsSource = socios;
                dataGridSocios.ItemsSource = null;
                dataGridSocios.ItemsSource = socios;

                // Para mostrar u ocultar según haya socios:
                dataGridSocios.Visibility = socios.Count > 0 ? Visibility.Visible : Visibility.Collapsed;

            }
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Socio seleccionado = (Socio)dataGridSocios.SelectedItem;
            if (seleccionado == null)
            {
                MessageBox.Show("Selecciona un socio de la lista para editar.");
                return;
            }
            // Pasamos una copia del socio seleccionado al formulario de edición
            var copia = new Socio { ID = seleccionado.ID, Nombre = seleccionado.Nombre, Email = seleccionado.Email };
            var ventana = new NuevoSocio(copia, true); // true = modo edición (ID no editable)
            if (ventana.ShowDialog() == true)
            {
                seleccionado.Nombre = ventana.NuevoSocioUsuario.Nombre;
                seleccionado.Email = ventana.NuevoSocioUsuario.Email;
                dataGridSocios.ItemsSource = null;
                dataGridSocios.ItemsSource = socios;
                dataGridSocios.ItemsSource = null;
                dataGridSocios.ItemsSource = socios;

                // Para mostrar u ocultar según haya socios:
                dataGridSocios.Visibility = socios.Count > 0 ? Visibility.Visible : Visibility.Collapsed;


            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Socio seleccionado = (Socio)dataGridSocios.SelectedItem;
            if (seleccionado == null)
            {
                MessageBox.Show("Selecciona un socio de la lista para borrar.");
                return;
            }
            socios.Remove(seleccionado);
            dataGridSocios.ItemsSource = null;   // Refrescamos
            dataGridSocios.ItemsSource = socios;
            dataGridSocios.ItemsSource = null;
            dataGridSocios.ItemsSource = socios;

            // Para mostrar u ocultar según haya socios:
            dataGridSocios.Visibility = socios.Count > 0 ? Visibility.Visible : Visibility.Collapsed;

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
