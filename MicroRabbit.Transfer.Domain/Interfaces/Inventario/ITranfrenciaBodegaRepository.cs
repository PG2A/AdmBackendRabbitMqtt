using MicroRabbit.Transfer.Domain.Models.Inventario;

namespace MicroRabbit.Transfer.Domain.Interfaces.Inventario
{
    public interface ITranfrenciaBodegaRepository
    {
        void Grabar(VenCabEgresoTabla vencabegreso);
        void GrabarDetalle(VenDetEgresoTabla vendetegreso);
        void ActualizarInventario(InvProductoBodegaTabla invproducto);
    
    }
}
