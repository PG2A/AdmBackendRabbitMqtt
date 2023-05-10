using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces.Inventario;
using MicroRabbit.Transfer.Domain.Models;


namespace MicroRabbit.Transfer.Data.Repository
{
    public class Nivel1Repository : INivelRepository
    {
        private Nivel1DbContext _context;

        public Nivel1Repository(Nivel1DbContext context)
        {
            _context = context;
        }

        public void AddNivel1(Nivel1Tabla nivel1)
        {
            _context.Add(nivel1);
            _context.SaveChanges();
        }
    }
}
