using System.Threading.Tasks;
using AgileQuotation.Persistence.Contextos;
using AgileQuotation.Persistence.Contratos;

namespace AgileQuotation.Persistence
{
    public class GeralPersist : IGeralPersist
    {
        private readonly AgileQuotationContext _context;
        public GeralPersist(AgileQuotationContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.AddAsync(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}