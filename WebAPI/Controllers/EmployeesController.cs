using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _employeeService.GetAll();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Employee employee)
        {
            _employeeService.Add(employee);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(Employee employee)
        {
            _employeeService.Update(employee);
            return Ok();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Employee employee)
        {
            _employeeService.Delete(employee);
            return Ok();
        }
    }
}
