//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 4 y 5 – Patrones de Diseño (Object Pool, Singleton, State, Facade)

namespace EquiposObjectPool.CapaNegocio 
{
    public interface IEstadoEquipo
    {
        void Ocupar(Equipos equipo, string cliente);
        void Liberar(Equipos equipo);
        string NombreEstado();
    }
}
