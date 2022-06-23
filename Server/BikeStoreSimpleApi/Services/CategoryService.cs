using BikeStoreSimple.API.Models;

namespace BikeStoreSimple.API.Services
{
    public interface ICategoryService
    {
        List<Category> GetAllCategory();
        Category GetCategoryById(int Id);
        Category CreateCategory(Category model);
        Category UpdateCategory(Category model);
        bool DeleteCategory(int Id);
    }
    public class CategoryService : ICategoryService
    {
        private BikeStoreContext _context;

        public CategoryService(BikeStoreContext context)
        {
            _context = context;
        }

        public Category CreateCategory(Category model)
        {
            var entity = new Category
            {
                CategoryName = model.CategoryName,
            };

            _context.Categories.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool DeleteCategory(int Id)
        {
            var entity = _context.Categories.Find(Id);

            if (entity == null)
                return false;

            _context.Categories.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Category> GetAllCategory()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int Id)
        {
            var entity = _context.Categories.Find(Id);

            if (entity == null)
                throw new Exception("khong tim thay category");

            return entity;
        }

        public Category UpdateCategory(Category model)
        {
            var entity = _context.Categories.Find(model.CategoryId);

            if (entity == null)
                throw new Exception("khong tim thay category");

            entity.CategoryName = model.CategoryName;

            _context.Categories.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
