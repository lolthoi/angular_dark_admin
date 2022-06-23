using BikeStoreSimple.API.Models;
using BikeStoreSimple.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace BikeStoreSimple.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService storeService)
        {
            _categoryService = storeService;
        }

        [HttpGet]
        public List<Category> GetAllCategory()
        {
            return _categoryService.GetAllCategory();
        }
        [HttpGet("{Id:int}")]
        public Category GetCategoryById(int Id)
        {
            return _categoryService.GetCategoryById(Id);
        }
        [HttpPost]
        public Category CreateCategory(Category model)
        {
            return _categoryService.CreateCategory(model);
        }
        [HttpPut]
        public Category UpdateCategory(Category model)
        {
            return _categoryService.UpdateCategory(model);
        }
        [HttpDelete("{Id:int}")]
        public bool DeleteCategory(int Id)
        {
            return _categoryService.DeleteCategory(Id);
        }
    }
}
