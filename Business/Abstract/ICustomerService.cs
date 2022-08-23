using Core.Utilities.Results;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<Customer> GetByUserId(int userId);
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetAllByCity(string city);
        IDataResult<List<Customer>> GetAllByContactMame(string contactName);
        IDataResult<List<Customer>> GetAllByCompanyName(string companyName);
        
    }
}
