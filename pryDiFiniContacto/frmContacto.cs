using System.Diagnostics.Eventing.Reader;

namespace pryDiFiniContacto
{
    public partial class frmContacto : Form
    {
        string Contacto = "";
        string Telefono = "";
        int Contador = 0;
        int Indice = 0;

        string[] vecContacto = new string[4];
        string[] vecTelefono = new string[4];
        public frmContacto()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Contador++;
            Contacto = txtContacto.Text;
            Telefono = mtbTelefono.Text;

            string Resultados = Contador + "-" + Contacto + "-" + Telefono;

            lstResultados.Items.Add(Resultados);

            vecContacto[Indice] = Contacto;
            vecTelefono[Indice] = Telefono;

            Indice++;

            if (Contador >= 10) // límite de 100 registros
            {
                MessageBox.Show("Se alcanzó el límite de registros.");
                return;
            }

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
