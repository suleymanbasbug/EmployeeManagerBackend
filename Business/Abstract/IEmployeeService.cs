using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
        List<Employee> GetAll();
        Employee GetById(int id);
    }
}
