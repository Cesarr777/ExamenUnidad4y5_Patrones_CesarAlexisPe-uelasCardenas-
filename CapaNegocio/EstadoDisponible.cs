//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 4 y 5 – Patrones de Diseño (Object Pool, Singleton, State, Facade)

using System;

namespace EquiposObjectPool.CapaNegocio{
    public class EstadoDisponible : IEstadoEquipo
    {
        public void Ocupar(Equipos equipo, string cliente)
        {
            equipo.ClienteActual = cliente;
            equipo.CambiarEstado(new EstadoOcupado());
            Console.WriteLine($"Equipo {equipo.Numero} ahora está ocupado por {cliente}.");
        }

        public void Liberar(Equipos equipo)
        {
            Console.WriteLine($"El equipo {equipo.Numero} ya está disponible.");
        }

        public string NombreEstado() => "Disponible";
    }
}
