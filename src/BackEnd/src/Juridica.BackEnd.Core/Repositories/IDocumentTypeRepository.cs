using System.Collections.Generic;
using System.Threading.Tasks;
using Juridica.BackEnd.Core.Models;

namespace Juridica.BackEnd.Core.Repositories
{
    public interface IDocumentTypeRepository : IRepository<DocumentType>
    {
        Task<IEnumerable<DocumentType>> GetAllWithDocumentsAsync();
        Task<DocumentType> GetWithDocumentsByIdAsync(int id);
    }
}