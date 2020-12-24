namespace Catalog.API.Models
{
    public class CatalogBrand
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public CatalogBrand(string name)
        {
            Name = name;
        }
    }
}