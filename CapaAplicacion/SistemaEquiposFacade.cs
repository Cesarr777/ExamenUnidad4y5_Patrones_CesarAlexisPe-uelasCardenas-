//Nombre: Cesar Alexis Peñuelas Cardenas
//NumControl: 22210335
//Examen Unidad 4 y 5 – Patrones de Diseño (Object Pool, Singleton, State, Facade)

using EquiposObjectPool.CapaDatos;    
using EquiposObjectPool.CapaNegocio;  

namespace EquiposObjectPool.CapaAplicacion 
{
    public class SistemaEquiposFacade
    {
        private AdministradorEquipos _admin;

        public SistemaEquiposFacade()
        {
            _admin = AdministradorEquipos.Instancia;
            _admin.Inicializar(5);
        }

        public void MostrarEstatus()
        {
            _admin.Pool.MostrarEstatus();
        }

        public void OcuparEquipo(int num, string cliente)
        {
            var eq = _admin.Pool.BuscarEquipo(num);
            if (eq == null)
            {
                Console.WriteLine("Equipo no encontrado.");
                return;
            }
            eq.Ocupar(cliente);
        }

        public void LiberarEquipo(int num)
        {
            var eq = _admin.Pool.BuscarEquipo(num);
            if (eq == null)
            {
                Console.WriteLine("Equipo no encontrado.");
                return;
            }
            eq.Liberar();
        }
    }
}
