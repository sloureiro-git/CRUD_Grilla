using Entidades;
using Persistencia;

namespace Negocio
{
    public class Logica
    {
        PersistenciaVehiculo objAccesoPersistencia = new PersistenciaVehiculo();
        public void AñadirVehiculo(Vehiculo objAñadirVehiculo)
        {

            objAccesoPersistencia.ListaVehiculos.Add(objAñadirVehiculo);
        }

        public void EliminarVehiculo(string matricula)
        {
            for(int i = 0; i < objAccesoPersistencia.ListaVehiculos.Count; i++)
            {
                if (objAccesoPersistencia.ListaVehiculos[i].Matricula.Equals(matricula))
                {
                    objAccesoPersistencia.ListaVehiculos.Remove(objAccesoPersistencia.ListaVehiculos[i]);
                }
            }
        }

        public void ModificarVehiculo(string matricula, string marca, int año, int kilometraje)
        {
            for(int i = 0; i < objAccesoPersistencia.ListaVehiculos.Count; i++)
            {
                if (objAccesoPersistencia.ListaVehiculos[i].Matricula.Equals(matricula))
                {
                    objAccesoPersistencia.ListaVehiculos[i].Matricula = matricula;
                    objAccesoPersistencia.ListaVehiculos[i].Marca = marca;
                    objAccesoPersistencia.ListaVehiculos[i].Año = año;
                    objAccesoPersistencia.ListaVehiculos[i].Kilometraje = kilometraje;
                }
            }
        }

        public List<Vehiculo> ObtenerLista()
        {
            return objAccesoPersistencia.ListaVehiculos;
        }
    }
}
