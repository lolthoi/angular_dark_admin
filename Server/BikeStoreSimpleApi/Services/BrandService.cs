using BikeStoreSimple.API.Models;

namespace BikeStoreSimple.API.Services
{
    public interface IBrandService
    {
        List<Brand> GetAllBrand();
        Brand GetBrandById(int Id);
        Brand CreateBrand(Brand model);
        Brand UpdateBrand(Brand model);
        bool DeleteBrand(int Id);
    }
    public class BrandService : IBrandService
    {
        private BikeStoreContext _context;

        public BrandService(BikeStoreContext context)
        {
            _context = context;
        }

        public Brand CreateBrand(Brand model)
        {
            var entity = new Brand
            {
                BrandName = model.BrandName,
            };

            _context.Brands.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool DeleteBrand(int Id)
        {
            var entity = _context.Brands.Find(Id);

            if (entity == null)
                return false;

            _context.Brands.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Brand> GetAllBrand()
        {
            return _context.Brands.ToList();
        }

        public Brand GetBrandById(int Id)
        {
            var entity = _context.Brands.Find(Id);

            if (entity == null)
                throw new Exception("khong tim thay brand");

            return entity;
        }

        public Brand UpdateBrand(Brand model)
        {
            var entity = _context.Brands.Find(model.BrandId);

            if (entity == null)
                throw new Exception("khong tim thay brand");

            entity.BrandName = model.BrandName;

            _context.Brands.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
