namespace Catalog.API.Models
{
    public class Catalog
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public string PictureFileName { get; private set; }

        public decimal Price { get; private set; }

        public CatalogType CatalogType { get; private set; }

        public CatalogBrand CatalogBrand { get; private set; }

        public Catalog(string name, string description, string pictureFileName, decimal price, CatalogType catalogType, CatalogBrand catalogBrand)
        {
            Name = name;
            Description = description;
            PictureFileName = pictureFileName;
            Price = price;
            CatalogType = catalogType;
            CatalogBrand = catalogBrand;
        }
    }
}