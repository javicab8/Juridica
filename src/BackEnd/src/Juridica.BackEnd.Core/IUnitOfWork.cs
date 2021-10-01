using System;
using System.Threading.Tasks;
using Juridica.BackEnd.Core.Repositories;

namespace Juridica.BackEnd.Core
{
    public interface IUnitOfwork : IDisposable
    {
        IDocumentRepository Documents { get; }
        IDocumentTypeRepository DocumentTypes { get; }
        Task<int> CommitAsync();
    }
}