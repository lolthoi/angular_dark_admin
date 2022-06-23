using BikeStoreSimple.API.Models;

namespace BikeStoreSimple.API.Services
{
    public interface IStaffService
    {
        List<Staff> GetAllStaff();
        Staff GetStaffById(int Id);
        Staff CreateStaff(Staff model);
        Staff UpdateStaff(Staff model);
        bool DeleteStaff(int Id);
    }
    public class StaffService : IStaffService
    {
        private BikeStoreContext _context;

        public StaffService(BikeStoreContext context)
        {
            _context = context;
        }

        public Staff CreateStaff(Staff model)
        {
            var entity = new Staff
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Phone = model.Phone,
                Active = model.Active,
                StoreId = model.StoreId,
                ManagerId = model.ManagerId,
            };

            _context.Staffs.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool DeleteStaff(int Id)
        {
            var entity = _context.Staffs.Find(Id);

            if (entity == null)
                return false;

            _context.Staffs.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Staff> GetAllStaff()
        {
            var result = _context.Staffs.ToList();
            return result;
        }

        public Staff GetStaffById(int Id)
        {
            var entity = _context.Staffs.Find(Id);

            if (entity == null)
                throw new Exception("khong tim thay brand");

            return entity;
        }

        public Staff UpdateStaff(Staff model)
        {
            var entity = _context.Staffs.Find(model.StaffId);

            if (entity == null)
                throw new Exception("khong tim thay brand");

            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.Email = model.Email;
            entity.Phone = model.Phone;
            entity.Active = model.Active;
            entity.StoreId = model.StoreId;
            entity.ManagerId = model.ManagerId;

            _context.Staffs.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
