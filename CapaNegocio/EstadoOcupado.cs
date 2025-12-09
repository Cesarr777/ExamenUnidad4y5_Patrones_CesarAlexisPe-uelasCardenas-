//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 4 y 5 – Patrones de Diseño (Object Pool, Singleton, State, Facade)

using System;

namespace EquiposObjectPool.CapaNegocio 
{
    public class EstadoOcupado : IEstadoEquipo
    {
        public void Ocupar(Equipos equipo, string cliente)
        {
            Console.WriteLine($"No se puede ocupar el equipo {equipo.Numero}, ya está ocupado.");
        }

        public void Liberar(Equipos equipo)
        {
            Console.WriteLine($"Equipo {equipo.Numero} liberado. Estaba con {equipo.ClienteActual}.");
            equipo.ClienteActual = "";
            equipo.CambiarEstado(new EstadoDisponible());
        }

        public string NombreEstado() => "Ocupado";
    }
}
