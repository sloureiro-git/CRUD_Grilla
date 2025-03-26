using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Logica objAccesoLogica = new Logica();

        private void buttonAñadir_Click(object sender, EventArgs e)
        {

            Vehiculo objAñadirVehiculo = new Vehiculo(textBoxMatricula.Text, textBoxMarca.Text, int.Parse(textBoxAño.Text), int.Parse(textBoxKilometraje.Text));

            objAccesoLogica.AñadirVehiculo(objAñadirVehiculo);

            ActualizarDataSource();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            objAccesoLogica.EliminarVehiculo(textBoxMatricula.Text);

            ActualizarDataSource();

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            objAccesoLogica.ModificarVehiculo(textBoxMatricula.Text, textBoxMarca.Text, int.Parse(textBoxAño.Text), int.Parse(textBoxKilometraje.Text));

            ActualizarDataSource();
        }

        public void ActualizarDataSource()
        {
            dataGridVehiculo.DataSource = null;
            dataGridVehiculo.DataSource = objAccesoLogica.ObtenerLista();
        }

        private void dataGridVehiculo_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridVehiculo.SelectedRows.Count > 0)
            {
                textBoxMatricula.Text = dataGridVehiculo.SelectedRows[0].Cells[0].Value.ToString();
                textBoxMarca.Text = dataGridVehiculo.SelectedRows[0].Cells[0].Value.ToString();
                textBoxAño.Text = dataGridVehiculo.SelectedRows[0].Cells[0].Value.ToString();
                textBoxKilometraje.Text = dataGridVehiculo.SelectedRows[0].Cells[0].Value.ToString();
            }

        }
    }
}
