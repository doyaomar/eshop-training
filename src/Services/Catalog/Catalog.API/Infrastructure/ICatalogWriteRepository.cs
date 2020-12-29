using Catalog.API.Models;

using System.Threading.Tasks;

namespace Catalog.API.Infrastructure
{
    public interface ICatalogWriteRepository
    {
        Task CreateAsync(CatalogItem catalog);
    }
}