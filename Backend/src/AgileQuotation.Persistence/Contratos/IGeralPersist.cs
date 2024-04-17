using System.Threading.Tasks;
using AgileQuotation.Domain;

namespace AgileQuotation.Persistence.Contratos
{
    public interface IGeralPersist
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(T[] entity) where T : class;
        Task<bool> SaveChangesAsync();
    }
}