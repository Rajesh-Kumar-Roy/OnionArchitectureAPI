using DomainLayer.Models;
using RepositoryLayer.RepositoryParttern;
using System.Collections.Generic;

namespace ServiceLayer.CustomerService
{
    public class CustomerService : ICustomerService
    {
        #region Property

        private IRepository<Customer> _repository;

        #endregion

        #region Constructor

        public CustomerService(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        #endregion

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repository.GetAll();
        }

        public Customer GetCustomer(int id)
        {
            return _repository.Get(id);
        }

        public void InsertCustomer(Customer customer)
        {
            _repository.Insert(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _repository.Update(customer);
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = GetCustomer(id);
            _repository.Remove(customer);
            _repository.SaveChange();
        }
    }
}
