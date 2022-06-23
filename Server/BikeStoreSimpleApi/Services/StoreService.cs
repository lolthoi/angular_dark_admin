using BikeStoreSimple.API.Models;

namespace BikeStoreSimple.API.Services
{
    public interface IStoreService
    {
        List<Store> GetAllStore();
        Store GetStoreById(int Id);
        Store CreateStore(Store model);
        Store UpdateStore(Store model);
        bool DeleteStore(int Id);
    }
    public class StoreService : IStoreService
    {
        private BikeStoreContext _context;

        public StoreService(BikeStoreContext context)
        {
            _context = context;
        }

        public Store CreateStore(Store model)
        {
            var entity = new Store
            {
                StoreName = model.StoreName,
                Phone = model.Phone,
                Email = model.Email,
                Street = model.Street,
                City = model.City,
                State = model.State,
                ZipCode = model.ZipCode
            };

            _context.Stores.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool DeleteStore(int Id)
        {
            var entity = _context.Stores.Find(Id);

            if (entity == null)
                return false;

            _context.Stores.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Store> GetAllStore()
        {
            return _context.Stores.ToList();
        }

        public Store GetStoreById(int Id)
        {
            var entity = _context.Stores.Find(Id);

            if (entity == null)
                throw new Exception("khong tim thay store");

            return entity;
        }

        public Store UpdateStore(Store model)
        {
            var entity = _context.Stores.Find(model.StoreId);

            if (entity == null)
                throw new Exception("khong tim thay store");

            entity.StoreName = model.StoreName;
            entity.Phone = model.Phone;
            entity.Email = model.Email;
            entity.Street = model.Street;
            entity.City = model.City;
            entity.State = model.State;
            entity.ZipCode = model.ZipCode;

            _context.Stores.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
