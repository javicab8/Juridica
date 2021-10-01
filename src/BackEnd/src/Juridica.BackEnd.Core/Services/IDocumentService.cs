using System.Collections.Generic;
using System.Threading.Tasks;
using Juridica.BackEnd.Core.Models;

namespace Juridica.BackEnd.Core.Services
{
    public interface IDocumentService
    {
        Task<IEnumerable<Document>> GetAllWithDocumentType();
        Task<Document> GetDocumentById(int id);
        Task<IEnumerable<Document>> GetDocumentsByDocumentTypeId(int documentTypeId);
        Task<Document> CreateDocument(Document newDocument);
        Task UpdateDocument(Document documentToBeUpdated, Document document);
        Task DeleteDocument(Document document);
    }
}