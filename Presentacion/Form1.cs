using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        NRegion negocio = new NRegion();
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvRegion.DataSource = negocio.Listar(btnListar.Text);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                negocio.Insertar(txtRegionName.Text);
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con el Admin");
                throw;
            }
        }
    }
}
