using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
    public class EmployeeBUS
    {
        UnitOfWork _unitOfWork = new UnitOfWork();

        public IEnumerable<Employee> getEntries()
        {
            return _unitOfWork.EmplyeeRepository.GetAll();
        }

        public Employee getEmployeeById(int id)
        {
            return _unitOfWork.EmplyeeRepository.GetByID(id);
        }

        public bool exists(int id)
        {
            return _unitOfWork.EmplyeeRepository.Exists(id);
        }

        public void deleteById(int id)
        {
            _unitOfWork.EmplyeeRepository.Delete(id);
        }

        public void update(Employee employee)
        {
            _unitOfWork.EmplyeeRepository.Update(employee);
        }

        public void add(Employee employee)
        {
            _unitOfWork.EmplyeeRepository.Insert(employee);
        }
    }
}
