using BikeStoreSimple.API.Models;

namespace BikeStoreSimple.API.Services
{

    public interface ICustomerService
    {
        List<Customer> GetAllCustomer();
        Customer GetCustomerById(int Id);
        Customer CreateCustomer(Customer model);
        Customer UpdateCustomer(Customer model);
        bool DeleteCustomer(int Id);
    }
    public class CustomerService : ICustomerService
    {
        private BikeStoreContext _context;

        public CustomerService(BikeStoreContext context)
        {
            _context = context;
        }

        public Customer CreateCustomer(Customer model)
        {
            var entity = new Customer
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Phone = model.Phone,
                Email = model.Email,
                Street = model.Street,
                City = model.City,
                State = model.State,
                ZipCode = model.ZipCode,
            };

            _context.Customers.Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public bool DeleteCustomer(int Id)
        {
            var entity = _context.Customers.Find(Id);

            if (entity == null)
                return false;

            _context.Customers.Remove(entity);
            _context.SaveChanges();

            return true;
        }

        public List<Customer> GetAllCustomer()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerById(int Id)
        {
            var entity = _context.Customers.Find(Id);

            if (entity == null)
                throw new Exception("khong tim thay brand");

            return entity;
        }

        public Customer UpdateCustomer(Customer model)
        {
            var entity = _context.Customers.Find(model.CustomerId);

            if (entity == null)
                throw new Exception("khong tim thay brand");

            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.Phone = model.Phone;
            entity.Email = model.Email;
            entity.Street = model.Street;
            entity.City = model.City;
            entity.State = model.State;
            entity.ZipCode = model.ZipCode;

            _context.Customers.Update(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
