namespace Catalog.API.Models
{
    public class CatalogType
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public CatalogType(string name)
        {
            Name = name;
        }
    }
}