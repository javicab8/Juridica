using System.Collections.Generic;
using System.Threading.Tasks;
using Juridica.BackEnd.Core.Models;

namespace Juridica.BackEnd.Core.Repositories
{
    public interface IDocumentRepository : IRepository<Document>
    {
        Task<IEnumerable<Document>> GetAllWithDocumentTypeAsync();
        Task<Document> GetWithDocumentTypeByIdAsync(int id);
        Task<IEnumerable<Document>> GetAllWithDocumentTypeByDocumentTypeIdAsync(int id);
    }
}