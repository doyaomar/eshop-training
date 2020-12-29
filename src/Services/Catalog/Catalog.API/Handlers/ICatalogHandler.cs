using Catalog.API.Models;

using System.Threading.Tasks;

namespace Catalog.API.Handlers
{
    public interface ICatalogHandler
    {
        Task CreateProductAsync(CatalogItem catalog);
    }
}