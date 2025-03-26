namespace Entidades
{
    public class Vehiculo
    {
        private string matricula;
        private string marca;
        private int año;
        private int kilometraje;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int Año
        {
            get { return año; }
            set { año = value; }
        }

        public int Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }

        }

        public Vehiculo(string matricula, string marca, int año, int kilometraje)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.año = año;
            this.kilometraje = kilometraje;
        }

        public Vehiculo()
        {
            matricula = "Default";
            marca = "Default";
            año = 0000;
            kilometraje = 00000;
        }
    }
}
