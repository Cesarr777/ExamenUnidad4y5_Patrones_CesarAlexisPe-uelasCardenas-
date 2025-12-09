//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 4 y 5 – Patrones de Diseño (Object Pool, Singleton, State, Facade)

using System;

namespace EquiposObjectPool.CapaNegocio 
{
    public class Equipos
    {
        public int Numero { get; private set; }
        public string ClienteActual { get; set; }

        private IEstadoEquipo _estado;

        public Equipos(int numero)
        {
            Numero = numero;
            ClienteActual = "";
            _estado = new EstadoDisponible();
        }

        public void CambiarEstado(IEstadoEquipo nuevo)
        {
            _estado = nuevo;
        }

        public void Ocupar(string cliente)
        {
            _estado.Ocupar(this, cliente);
        }

        public void Liberar()
        {
            _estado.Liberar(this);
        }

        public override string ToString()
        {
            string clienteTxt = ClienteActual == "" ? "" : $" - Cliente: {ClienteActual}";
            return $"Equipo {Numero} - Estado: {_estado.NombreEstado()}{clienteTxt}";
        }
    }
}
