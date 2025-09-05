using System.Diagnostics.Eventing.Reader;

namespace pryDiFiniContacto
{
    public partial class frmContacto : Form
    {
        public frmContacto()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string Contacto = "";
        string Telefono = "";
        int Contador = 0;
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Contador++;
            Contacto = txtContacto.Text;
            Telefono = mtbTelefono.Text;

            string Resultados = Contador + "-" + Contacto + "-" + Telefono;

            lstResultados.Items.Add(Resultados);

            txtContacto.Text = "";
            mtbTelefono.Text = "";
            txtContacto.Focus();
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void mtbTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
