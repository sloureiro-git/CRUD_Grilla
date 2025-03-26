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

        private void buttonA�adir_Click(object sender, EventArgs e)
        {

            Vehiculo objA�adirVehiculo = new Vehiculo(textBoxMatricula.Text, textBoxMarca.Text, int.Parse(textBoxA�o.Text), int.Parse(textBoxKilometraje.Text));

            objAccesoLogica.A�adirVehiculo(objA�adirVehiculo);

            ActualizarDataSource();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            objAccesoLogica.EliminarVehiculo(textBoxMatricula.Text);

            ActualizarDataSource();

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            objAccesoLogica.ModificarVehiculo(textBoxMatricula.Text, textBoxMarca.Text, int.Parse(textBoxA�o.Text), int.Parse(textBoxKilometraje.Text));

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
                textBoxA�o.Text = dataGridVehiculo.SelectedRows[0].Cells[0].Value.ToString();
                textBoxKilometraje.Text = dataGridVehiculo.SelectedRows[0].Cells[0].Value.ToString();
            }

        }
    }
}
