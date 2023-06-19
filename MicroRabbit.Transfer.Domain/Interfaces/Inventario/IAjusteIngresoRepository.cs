using MicroRabbit.Transfer.Domain.Models.Inventario;


namespace MicroRabbit.Transfer.Domain.Interfaces.Inventario
{
    public interface IAjusteIngresoRepository
    {
        void Grabar(VenCabingresoTabla vencabegreso);
        void GrabarDetalle(VenDetingresoTabla vendetegreso);
        void GrabarBod(VenCabingresoBodTabla vencabegreso);
        void GrabarDetalleBod(VenDetingresoBodTabla vendetegreso);
        void ActualizarInventario(VenAgregarStockProductoBodAjusteIngresoProc invproducto);
    }
}
