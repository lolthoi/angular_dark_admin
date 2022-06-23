using BikeStoreSimple.API.Models;

namespace BikeStoreSimple.API.Services
{
    public interface IProductService
    {
        List<Product> GetAllProduct();
        Product GetProductById(int Id);
        Product CreateProduct(Product model);
        Product UpdateProduct(Product model);
        bool DeleteProduct(int Id);
    }
    public class ProductService : IProductService
    {
        private BikeStoreContext _context;

        public ProductService(BikeStoreContext context)
        {
            _context = context;
        }

        public Product CreateProduct(Product model)
        {
            var entity = new Product
            {
                ProductName = model.ProductName,
                BrandId = model.BrandId,
                CategoryId = model.CategoryId,
                ModelYear = model.ModelYear,
                ListPrice = model.ListPrice,
            };

            _context.Products.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool DeleteProduct(int Id)
        {
            var entity = _context.Products.Find(Id);

            if (entity == null)
                return false;

            _context.Products.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Product> GetAllProduct()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int Id)
        {
            var entity = _context.Products.Find(Id);

            if (entity == null)
                throw new Exception("khong tim thay product");

            return entity;
        }

        public Product UpdateProduct(Product model)
        {
            var entity = _context.Products.Find(model.ProductId);

            if (entity == null)
                throw new Exception("khong tim thay product");

            entity.ProductName = model.ProductName;
            entity.BrandId = model.BrandId;
            entity.CategoryId = model.CategoryId;
            entity.ModelYear = model.ModelYear;
            entity.ListPrice = model.ListPrice;

            _context.Products.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
