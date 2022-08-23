using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.AllCustomersGot);
        }

        public IDataResult<List<Customer>> GetAllByCity(string city)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.City == city),Messages.CustomersGotByCity);
        }

        public IDataResult<List<Customer>> GetAllByCompanyName(string companyName)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.CompanyName == companyName),Messages.CustomersGotByCompanyName);
        }

        public IDataResult<List<Customer>> GetAllByContactMame(string contactName)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.ContactName == contactName), Messages.CustomersGotByContactName);
        }

        public IDataResult<Customer> GetByUserId(int userId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.UserId == userId), Messages.CustomerGotByUserId);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);  
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
