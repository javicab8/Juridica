using System.Collections.Generic;
using System.Threading.Tasks;
using Juridica.BackEnd.Core.Models;

namespace Juridica.BackEnd.Core.Services
{
    public interface IDocumentTypeService
    {
        Task<IEnumerable<DocumentType>> GetAllDocumentTypes();
        Task<DocumentType> GetDocumentTypeById(int id);
        Task<DocumentType> CreateDocumentType(DocumentType newDocumentType);
        Task UpdateDocumentType(DocumentType documentTypeToBeUpdated, DocumentType documentType);
        Task DeleteDocumentType(DocumentType documentType);
    }
}