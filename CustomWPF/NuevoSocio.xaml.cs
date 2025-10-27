using System.Windows;
using CustomWPF;


namespace CustomWPF
{
  
    public partial class NuevoSocio : Window
    {
        public Socio NuevoSocioUsuario { get; private set; }

        public NuevoSocio(Socio socio, bool esEdicion = false)
        {
            InitializeComponent();
            txtID.Text = socio.ID == 0 ?"" : socio.ID.ToString();
            txtNombre.Text = socio.Nombre;
            txtEmail.Text = socio.Email;
            
            txtID.IsEnabled = !esEdicion;
            NuevoSocioUsuario = new Socio
            {
                ID = socio.ID,
                Nombre = socio.Nombre,
                Email = socio.Email
            };
        }



        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                NuevoSocioUsuario = new Socio   
                {
                    ID = id,
                    Nombre = txtNombre.Text,
                    Email = txtEmail.Text
                };
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("ID inválido.");
            }
        }


        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

    }
}

