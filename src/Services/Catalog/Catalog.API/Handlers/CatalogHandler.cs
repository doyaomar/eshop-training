using Catalog.API.Infrastructure;
using Catalog.API.Models;

using System.Threading.Tasks;

namespace Catalog.API.Handlers
{
    public class CatalogHandler : ICatalogHandler
    {
        private readonly ICatalogWriteRepository _catalogWriteRepository;

        public CatalogHandler(ICatalogWriteRepository catalogWriteRepository)
        {
            _catalogWriteRepository = catalogWriteRepository;
        }

        public async Task CreateProductAsync(CatalogItem catalog)
        {
            await _catalogWriteRepository.CreateAsync(catalog);
        }
    }
}